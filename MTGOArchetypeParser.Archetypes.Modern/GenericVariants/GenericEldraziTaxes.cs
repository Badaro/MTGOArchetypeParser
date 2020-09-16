using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.Archetypes.Modern
{
    public class GenericEldraziTaxes : GenericTaxes
    {
        public GenericEldraziTaxes()
        {
            CommonCards = CommonCards.Concat<string>(new string[] {
                "Eldrazi Temple"
            }).ToArray();
        }
    }
}
