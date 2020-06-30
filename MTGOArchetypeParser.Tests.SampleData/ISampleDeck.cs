using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Tests.SampleData
{
    public interface ISampleDeck
    {
        (int Count, string Name)[] Mainboard { get; }
        (int Count, string Name)[] Sideboard { get; }
    }
}
