using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.App
{
    public interface IOutput
    {
        void WriteRecords(Record[] records, ExecutionSettings settings);
        void WriteCards(Dictionary<string, int> cards, ExecutionSettings settings);
        void WriteBreakdown(Dictionary<string, int> archetypes, ExecutionSettings settings);
        void WriteWinrates(Dictionary<string, RecordMatchup> archetypes, ExecutionSettings settings);
        void WriteMatchups(Dictionary<string, RecordMatchup> archetypes, ExecutionSettings settings);
    }
}
