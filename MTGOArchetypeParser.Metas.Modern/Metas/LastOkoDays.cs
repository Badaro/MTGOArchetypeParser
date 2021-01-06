using MTGOArchetypeParser.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Metas.Modern
{
    public class LastOkoDays : ArchetypeMeta
    {
        public LastOkoDays()
        {
            this.StartDate = new DateTime(2019, 12, 03, 00, 00, 00, DateTimeKind.Utc);
        }
    }
}
