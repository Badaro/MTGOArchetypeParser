using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Tests.SampleData
{
    public interface ISampleDeck
    {
        string[] Mainboard { get; }
        string[] Sideboard { get; }
    }
}
