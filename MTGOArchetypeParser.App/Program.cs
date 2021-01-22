using MTGOArchetypeParser.Data;
using MTGOArchetypeParser.Data.Model;
using MTGOArchetypeParser.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace MTGOArchetypeParser.App
{
    class Program
    {
        static string _settingsFile = "settings.json";

        static void Main(string[] args)
        {
            try
            {
                var settings = ExecutionSettings.FromJsonFile(_settingsFile);
                settings.ApplyOverrides(args);
                settings.Validate();

                // Loading format daa
                Console.WriteLine("Loading format data");
                ArchetypeFormat format = Formats.FromJson.Loader.GetFormat(settings.FormatDataFolder, settings.Format);

                ArchetypeFormat referenceFormat = null;
                if (!String.IsNullOrEmpty(settings.ReferenceFormat))
                {
                    referenceFormat = Formats.FromJson.Loader.GetFormat(settings.FormatDataFolder, settings.ReferenceFormat);
                }

                Console.WriteLine("Loading tournaments");
                Tournament[] tournaments = settings.TournamentFolder.SelectMany(c => TournamentLoader.GetTournamentsByDate(c, format.Metas.First().StartDate.AddDays(1))).ToArray();

                foreach (string filter in settings.Filter)
                {
                    tournaments = tournaments.Where(t => t.Information.Name.Contains(filter, StringComparison.InvariantCultureIgnoreCase) || t.Information.Uri.ToString().Contains(filter, StringComparison.InvariantCultureIgnoreCase)).ToArray();
                }
                foreach (string exclude in settings.Exclude)
                {
                    tournaments = tournaments.Where(t => !t.Information.Name.Contains(exclude, StringComparison.InvariantCultureIgnoreCase) && !t.Information.Uri.ToString().Contains(exclude, StringComparison.InvariantCultureIgnoreCase)).ToArray();
                }

                Record[] records = RecordLoader.GetRecords(tournaments, format, referenceFormat);

                if (!String.IsNullOrEmpty(settings.Meta))
                {
                    records = records.Where(r => r.Meta.Contains(settings.Meta, StringComparison.InvariantCultureIgnoreCase);
                }

                if (settings.Action == ExecutionAction.Compare)
                {
                    records = records.Where(r => !r.Archetype.Equals(r.ReferenceArchetype)).ToArray();
                }

                if (settings.Output == ExecutionOutput.Console)
                {
                    new ConsoleOutput().Write(records, settings.Action == ExecutionAction.Compare);
                }
                else
                {
                    Console.WriteLine("Saving data to CSV file");
                    new CsvOutput().Write(records, settings.Action == ExecutionAction.Compare);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                if (ex is ValidationException) Console.WriteLine(_usage);
            }
        }

        static string _usage = @"Usage: MTGOArchetypeParser.App [OUTPUT] [ACTION] [SETTINGS]

Sample:
MTGOArchetypeParser.App csv detect filter=challenge
MTGOArchetypeParser.App console compare filter=modern-preliminary-2021-01-21 referenceformat=Modern-Old

Outputs:
* console: Prints the results in-line
* csv: Generates a csv file with the results

Actions:
* detect: Detects archetypes
* compare: Compares the results between two format data sets

Settings (can also be specified using settings.json):
* format: Format data to be used for detection
* referenceformat: Format data to be used for comparison
* meta: Only generate data for events that belong to this meta
* filter: Only generate data for events that match this string, can be specified more than once
* exclude: Only generate data for events that do NOT match this string, can be specified more than once
* tournamentfolder: Specifies the location of folders with the tournament data, can be specified more than once
* formatdatafolder: Specifies the location of the folders with the format data";
    }
}
