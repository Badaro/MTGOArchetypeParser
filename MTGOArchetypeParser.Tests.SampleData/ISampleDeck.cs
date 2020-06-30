using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Tests.SampleData
{
    public interface ISampleDeck
    {
        ISampleCard[] Mainboard { get; }
        ISampleCard[] Sideboard { get; }
    }
}
