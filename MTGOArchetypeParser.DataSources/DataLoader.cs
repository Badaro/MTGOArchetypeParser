using System;
using MTGOArchetypeParser.DataSources.Model;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.IO;
using Newtonsoft.Json;
using System.Globalization;

namespace MTGOArchetypeParser.DataSources
{
    public static class DataLoader
    {
        public static CacheItem[] GetTournaments(string cacheFolder, DateTime startDate, Func<string, bool> filter = null)
        {
            if (filter == null) filter = n => true;

            List<CacheItem> result = new List<CacheItem>();

            for (DateTime date = startDate; date < DateTime.UtcNow; date = date.AddDays(1))
            {
                string folder = Path.Combine(cacheFolder, date.Year.ToString(), date.Month.ToString("D2"), date.Day.ToString("D2"));
                if (!Directory.Exists(folder)) continue;

                foreach (string file in Directory.GetFiles(folder, "*.json"))
                {
                    CacheItem item = JsonConvert.DeserializeObject<CacheItem>(File.ReadAllText(file));
                    if (filter(item.Tournament.Name)) result.Add(item);
                }
            }

            return result.ToArray();
        }

        public static CacheItem GetTournament(string cacheFolder, string eventName)
        {
            DateTime date = ExtractDateFromName(eventName);

            string folder = Path.Combine(cacheFolder, date.Year.ToString(), date.Month.ToString("D2"), date.Day.ToString("D2"));
            string file = Path.Combine(folder, $"{eventName}.json");
            if (!Directory.Exists(folder)) throw new Exception("Event not found");
            if (!File.Exists(file)) throw new Exception("Event not found");

            CacheItem item = JsonConvert.DeserializeObject<CacheItem>(File.ReadAllText(file));
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
