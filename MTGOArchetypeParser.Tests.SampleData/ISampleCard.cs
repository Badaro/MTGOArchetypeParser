using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Tests.SampleData
{
    public interface ISampleCard
    {
        int Count { get; }
        string Name { get; }
    }

    public class SampleCard : ISampleCard
    {
        public int Count { get; private set; }
        public string Name { get; private set; }
        public SampleCard(int count, string name)
        {
            this.Count = count;
            this.Name = name;
        }
    }
}
