using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.App
{
    public class CsvOutput : IOutput
    {
        public void Write(Record[] records, bool isCompare)
        {
            StringBuilder csvData = new StringBuilder();

            csvData.AppendLine(GetHeader(isCompare));
            foreach (var record in records) csvData.AppendLine(GetLine(record, isCompare));

            string date = $"{records.Max(t => t.Date).ToString("yyyy_MM_dd")}";
            string outputFile = $"mtgo_data_{date}.csv";

            if (File.Exists(outputFile)) File.Delete(outputFile);
            File.WriteAllText(outputFile, csvData.ToString());
        }

        private string GetHeader(bool isCompare)
        {
            if (isCompare) return $"EVENT,META,WEEK,DATE,RESULT,POINTS,PLAYER,URL,ARCHETYPE,COLOR,COMPANION,REFERENCE_ARCHETYPE,REFERENCE_COLOR,REFERENCE_COMPANION";
            else return $"EVENT,META,WEEK,DATE,RESULT,POINTS,PLAYER,URL,ARCHETYPE,COLOR,COMPANION";
        }

        private string GetLine(Record record, bool isCompare)
        {
            if (isCompare) return $"{record.Tournament},{record.Meta},{record.Week},{record.Date.ToString("yyyy-MM-dd")},{record.Result},{record.Points},{record.Player},{record.AnchorUri},{record.Archetype.Archetype},{record.Archetype.Color},{record.Archetype.Companion},{record.ReferenceArchetype.Archetype},{record.ReferenceArchetype.Color},{record.ReferenceArchetype.Companion}";
            else return $"{record.Tournament},{record.Meta},{record.Week},{record.Date.ToString("yyyy-MM-dd")},{record.Result},{record.Points},{record.Player},{record.AnchorUri},{record.Archetype.Archetype},{record.Archetype.Color},{record.Archetype.Companion}";
        }
    }
}
