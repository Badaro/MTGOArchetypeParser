using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.Archetypes.Modern
{
    public class GenericReclamation : GenericControl
    {
        public GenericReclamation()
        {
            CommonCards = CommonCards.Concat<string>(new string[] {
                "Wilderness Reclamation"
            }).ToArray();
        }
    }
}
