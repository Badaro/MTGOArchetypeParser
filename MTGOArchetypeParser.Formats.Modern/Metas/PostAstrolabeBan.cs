using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Metas.Modern
{
    public class PostAstrolabeBan : ArchetypeMeta
    {
        public PostAstrolabeBan()
        {
            this.StartDate = new DateTime(2020, 07, 14, 00, 00, 00, DateTimeKind.Utc);
        }
    }
}
