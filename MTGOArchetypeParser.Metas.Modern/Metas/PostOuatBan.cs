using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Metas.Modern
{
    public class PostOuatBan : ArchetypeMeta
    {
        public PostOuatBan()
        {
            this.StartDate = new DateTime(2020, 03, 11, 00, 00, 00, DateTimeKind.Utc);
        }
    }
}
