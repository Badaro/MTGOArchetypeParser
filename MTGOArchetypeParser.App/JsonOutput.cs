﻿using Newtonsoft.Json;
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
        public void Write(Record[] records, ExecutionSettings settings)
        {
            string outputFile = settings.OutputFile;
            if(String.IsNullOrEmpty(outputFile)) outputFile = $"mtgo_data_{records.Max(t => t.Date).ToString("yyyy_MM_dd")}.json";

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

    public class JsonOutputRoot
    {
        public Record[] Data { get; set; }
    }
}
