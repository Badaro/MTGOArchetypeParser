using System;
using MTGOArchetypeParser.Data.Model;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;
using Newtonsoft.Json;
using System.Globalization;
using System.Text.RegularExpressions;

namespace MTGOArchetypeParser.Data
{
    public static class TournamentLoader
    {
        public static Tournament[] GetTournamentsByDate(string cacheFolder, DateTime startDate, Func<string, bool> filter = null)
        {
            string[] subFolders = Directory.GetDirectories(cacheFolder);
            bool isSingleLevelStructure = subFolders.All(d => Regex.IsMatch(Path.GetFileName(d), "\\d\\d\\d\\d"));

            if (isSingleLevelStructure)
            {
                return GetTournamentsByDateInternal(cacheFolder, startDate, filter);
            }
            else
            {
                List<Tournament> tournaments = new List<Tournament>();
                foreach (string subFolder in subFolders) tournaments.AddRange(GetTournamentsByDateInternal(subFolder, startDate, filter));
                return tournaments.ToArray();
            }
        }

        private static Tournament[] GetTournamentsByDateInternal(string cacheFolder, DateTime startDate, Func<string, bool> filter = null)
        {
            if (filter == null) filter = n => true;

            List<Tournament> result = new List<Tournament>();

            for (DateTime date = startDate; date < DateTime.UtcNow.AddMonths(1); date = date.AddDays(1))
            {
                string folder = Path.Combine(cacheFolder, date.Year.ToString(), date.Month.ToString("D2"), date.Day.ToString("D2"));
                if (!Directory.Exists(folder)) continue;

                foreach (string file in Directory.GetFiles(folder, "*.json"))
                {
                    if (filter(Path.GetFileName(file)))
                    {
                        Tournament item = GetTournamentFromFile(file);
                        item.JsonFile = Path.GetFileName(file);
                        result.Add(item);
                    }
                }
            }

            return result.ToArray();
        }
        private static Tournament GetTournamentFromFile(string file)
        {
            Tournament item = JsonConvert.DeserializeObject<Tournament>(File.ReadAllText(file));
            item.File = Path.GetFileName(file);

            foreach (Deck deck in item.Decks)
            {
                if (deck.Date == null) deck.Date = item.Information.Date;
            }

            return item;
        }


        private static DateTime ExtractDateFromName(string eventName)
        {
            string[] eventNameSegments = eventName.Split("-").Where(e => e.Length > 1).ToArray();
            string eventDate = String.Join("-", eventNameSegments.Skip(eventNameSegments.Length - 3).ToArray());

            return DateTime.Parse(eventDate, CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal).ToUniversalTime();
        }

    }
}
