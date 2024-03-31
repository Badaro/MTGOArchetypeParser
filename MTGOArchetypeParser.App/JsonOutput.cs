using MTGOArchetypeParser.Model;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.App
{
    public class JsonOutput : IOutput
    {
        public void WriteRecords(Record[] records, ExecutionSettings settings)
        {
            WriteJsonFile<Record[], Record>(records, settings);
        }

        public void WriteCards(Dictionary<string, int> cards, ExecutionSettings settings)
        {
            WriteJsonFile<Dictionary<string, int>, KeyValuePair<string, int>>(cards, settings, "cards");
        }

        public void WriteBreakdown(Dictionary<string, int> archetypes, ExecutionSettings settings)
        {
            WriteJsonFile<Dictionary<string, int>, KeyValuePair<string, int>>(archetypes, settings, "breakdown");
        }

        public void WriteWinrates(Dictionary<string, RecordMatchup> archetypes, ExecutionSettings settings)
        {
            WriteJsonFile<Dictionary<string, RecordMatchup>, KeyValuePair<string, RecordMatchup>>(archetypes, settings, "winrates");
        }

        public void WriteMatchups(Dictionary<string, RecordMatchup> archetypes, ExecutionSettings settings)
        {
            WriteJsonFile<Dictionary<string, RecordMatchup>, KeyValuePair<string, RecordMatchup>>(archetypes, settings, "matchupsfor");
        }

        private void WriteJsonFile<TList, TObject>(TList records, ExecutionSettings settings, string suffix = null)
            where TList : IEnumerable<TObject>
        {
            string outputFile = settings.OutputFile;
            if (String.IsNullOrEmpty(outputFile)) outputFile = $"mtgo_data_{DateTime.Now.ToString("yyyy_MM_dd")}.json";
            if (suffix != null) outputFile = $"{Path.GetFileNameWithoutExtension(outputFile)}_{suffix}.json";

            JsonSerializer serializer = new JsonSerializer();

            if (File.Exists(outputFile)) File.Delete(outputFile);
            using (StreamWriter stream = new StreamWriter(File.Create(outputFile)))
            {
                using (JsonTextWriter writer = new JsonTextWriter(stream))
                {
                    writer.WriteStartObject();

                    writer.WritePropertyName("Data");

                    writer.WriteStartArray();
                    foreach (var record in records)
                    {
                        JObject obj = JObject.FromObject(record, serializer);
                        obj.WriteTo(writer);
                    }
                    writer.WriteEndArray();

                    writer.WriteEndObject();
                }
            }

        }

    }
}
