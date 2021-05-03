using MTGOArchetypeParser.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;

namespace MTGOArchetypeParser.Formats.FromJson
{
    public class Loader
    {
        static string _colorFile = "card_colors.json";
        static string _colorOverrideFile = "color_overrides.json";
        static string _metasFile = "metas.json";
        static string _archetypeFolder = "Archetypes";
        static string _fallbackFolder = "Fallbacks";

        public static ArchetypeFormat GetFormat(string rootFolder, string format)
        {
            string colorFile = Path.Combine(rootFolder, _colorFile);
            string colorOverrideFile = Path.Combine(rootFolder, format, _colorOverrideFile);
            string metasFile = Path.Combine(rootFolder, format, _metasFile);
            string archetypeFolder = Path.Combine(rootFolder, format, _archetypeFolder);
            string fallbackFolder = Path.Combine(rootFolder, format, _fallbackFolder);

            var colors = GetColors(colorFile, colorOverrideFile);
            var metas = GetMetas(metasFile);
            var archetypes = GetArchetypes(archetypeFolder, fallbackFolder);

            return new ArchetypeFormat()
            {
                Lands = colors.Lands,
                NonLands = colors.NonLands,
                Archetypes = archetypes,
                Metas = metas
            };
        }

        private static (Dictionary<string, ArchetypeColor> Lands, Dictionary<string, ArchetypeColor> NonLands) GetColors(string colorFile, string colorOverrideFile)
        {
            Dictionary<string, ArchetypeColor> lands = new Dictionary<string, ArchetypeColor>();
            Dictionary<string, ArchetypeColor> nonLands = new Dictionary<string, ArchetypeColor>();

            dynamic colorsJson = JsonConvert.DeserializeObject(File.ReadAllText(colorFile));
            if (colorsJson.Lands != null) foreach (var card in colorsJson.Lands) AddCard(lands, card);
            if (colorsJson.NonLands != null) foreach (var card in colorsJson.NonLands) AddCard(nonLands, card);

            colorsJson = JsonConvert.DeserializeObject(File.ReadAllText(colorOverrideFile));
            if (colorsJson.Lands != null) foreach (var card in colorsJson.Lands) AddCard(lands, card);
            if (colorsJson.NonLands != null) foreach (var card in colorsJson.NonLands) AddCard(nonLands, card);

            return (lands, nonLands);
        }

        private static void AddCard(Dictionary<string, ArchetypeColor> target, dynamic card)
        {
            string name = card.Name;
            string color = card.Color;

            ArchetypeColor colorValue;
            if (!Enum.TryParse<ArchetypeColor>(color, out colorValue))
            {
                throw new InvalidDataException($"Failed to parse color {color} for card {name}");
            }

            if (!target.ContainsKey(name)) target.Add(name, colorValue);
            else target[name] = colorValue;
        }

        private static ArchetypeMeta[] GetMetas(string metasFile)
        {
            List<ArchetypeMeta> metas = new List<ArchetypeMeta>();
            dynamic metasJson = JsonConvert.DeserializeObject(File.ReadAllText(metasFile));

            foreach (var meta in metasJson.Metas)
            {
                string name = meta.Name;
                string date = meta.StartDate;

                DateTime parsedDate;
                if (!DateTime.TryParse(date, CultureInfo.InvariantCulture, DateTimeStyles.AssumeUniversal, out parsedDate))
                {
                    throw new InvalidDataException($"Failed to parse date {date} for meta {name}");
                }
                parsedDate = parsedDate.ToUniversalTime();

                metas.Add(new ArchetypeMeta()
                {
                    Name = name,
                    StartDate = parsedDate
                });
            }

            return metas.ToArray();
        }

        private static Archetype[] GetArchetypes(string archetypeFolder, string fallbackFolder)
        {
            List<Archetype> archetypes = new List<Archetype>();

            foreach (var archetypeFile in Directory.GetFiles(archetypeFolder, "*.json"))
            {
                var archetype = JsonConvert.DeserializeObject<ArchetypeSpecific>(File.ReadAllText(archetypeFile));
                if (archetype.Conditions == null || archetype.Conditions.Length == 0) throw new Exception($"Archetype file {Path.GetFileName(archetypeFile)} is invalid, no conditions declared");
                archetypes.Add(archetype);
            }
            foreach (var archetypeFile in Directory.GetFiles(fallbackFolder, "*.json"))
            {
                var archetype = JsonConvert.DeserializeObject<ArchetypeGeneric>(File.ReadAllText(archetypeFile));
                if (archetype.CommonCards == null || archetype.CommonCards.Length == 0) throw new Exception($"Fallback file {Path.GetFileName(archetypeFile)} in invalid, no common cards declared");
                archetypes.Add(archetype);
            }

            return archetypes.ToArray();
        }
    }
}
