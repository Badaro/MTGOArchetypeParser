using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.Formats.Modern
{
    public static class Loader
    {
        public static ArchetypeFormat GetFormat()
        {
            return new ArchetypeFormat()
            {
                NonLands = Cards.Modern.CardList.GetNonLands(),
                Lands = Cards.Modern.CardList.GetLands(),
                Archetypes = GetArchetypes(),
                Metas = GetMetas()
            };
        }

        private static Archetype[] GetArchetypes()
        {
            var types = typeof(Loader).Assembly
                .GetTypes()
                .Where(t => typeof(Archetype).IsAssignableFrom(t))
                .ToArray();

            return types.Select(t => (Archetype)t.GetConstructor(new Type[0]).Invoke(new object[0])).ToArray();
        }

        private static ArchetypeMeta[] GetMetas()
        {
            var types = typeof(Loader).Assembly
                .GetTypes()
                .Where(t => typeof(ArchetypeMeta).IsAssignableFrom(t))
                .ToArray();

            return types.Select(t => (ArchetypeMeta)t.GetConstructor(new Type[0]).Invoke(new object[0])).OrderBy(m => m.StartDate).ToArray();
        }
    }
}
