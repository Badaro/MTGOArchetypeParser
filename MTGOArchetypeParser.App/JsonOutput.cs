using Newtonsoft.Json;
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

            if (File.Exists(outputFile)) File.Delete(outputFile);
            File.WriteAllText(outputFile, JsonConvert.SerializeObject(new JsonOutputRoot()
            {
                Data = records
            }));
        }
    }

    public class JsonOutputRoot
    {
        public Record[] Data { get; set; }
    }
}
