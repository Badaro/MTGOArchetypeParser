using System;
using MTGOArchetypeParser.Data.Model;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;
using Newtonsoft.Json;
using System.Globalization;

namespace MTGOArchetypeParser.Data
{
    public static class TournamentLoader
    {
        public static MTGOTournament GetTournamentByName(string cacheFolder, string eventName)
        {
            DateTime date = ExtractDateFromName(eventName);

            string folder = Path.Combine(cacheFolder, date.Year.ToString(), date.Month.ToString("D2"), date.Day.ToString("D2"));
            string file = Path.Combine(folder, $"{eventName}.json");
            if (!Directory.Exists(folder)) throw new Exception("Event not found");
            if (!File.Exists(file)) throw new Exception("Event not found");

            MTGOTournament item = JsonConvert.DeserializeObject<MTGOTournament>(File.ReadAllText(file));
            item.File = Path.GetFileName(file);
            return item;
        }

        public static MTGOTournament[] GetTournamentsByDate(string cacheFolder, DateTime startDate, Func<string, bool> filter = null)
        {
            if (filter == null) filter = n => true;

            List<MTGOTournament> result = new List<MTGOTournament>();

            for (DateTime date = startDate; date < DateTime.UtcNow; date = date.AddDays(1))
            {
                string folder = Path.Combine(cacheFolder, date.Year.ToString(), date.Month.ToString("D2"), date.Day.ToString("D2"));
                if (!Directory.Exists(folder)) continue;

                foreach (string file in Directory.GetFiles(folder, "*.json"))
                {
                    MTGOTournament item = JsonConvert.DeserializeObject<MTGOTournament>(File.ReadAllText(file));
                    item.File = Path.GetFileName(file);
                    if (filter(item.Tournament.Name)) result.Add(item);
                }
            }

            return result.ToArray();
        }

        private static DateTime ExtractDateFromName(string eventName)
        {
            string[] eventNameSegments = eventName.Split("-").Where(e => e.Length > 1).ToArray();
            string eventDate = String.Join("-", eventNameSegments.Skip(eventNameSegments.Length - 3).ToArray());

            return DateTime.Parse(eventDate, CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal).ToUniversalTime();
        }
    }
}
