using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.Metas.Modern
{
    public static class Loader
    {
        public static ArchetypeMeta[] GetMetas()
        {
            var types = typeof(Loader).Assembly
                .GetTypes()
                .Where(t => typeof(ArchetypeMeta).IsAssignableFrom(t))
                .ToArray();

            return types.Select(t => (ArchetypeMeta)t.GetConstructor(new Type[0]).Invoke(new object[0])).OrderBy(m => m.StartDate).ToArray();
        }
    }
}
