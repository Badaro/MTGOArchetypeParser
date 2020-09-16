using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.Archetypes.Modern
{
    public static class Loader
    {
        public static Archetype[] GetArchetypes()
        {
            var types = typeof(Loader).Assembly
                .GetTypes()
                .Where(t => typeof(Archetype).IsAssignableFrom(t))
                .ToArray();

            return types.Select(t => (Archetype)t.GetConstructor(new Type[0]).Invoke(new object[0])).ToArray();
        }
    }
}
