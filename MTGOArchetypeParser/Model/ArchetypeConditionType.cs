using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Model
{
    public enum ArchetypeConditionType
    {
        InMainboard,
        OneOfInMainboard,
        InSideboard,
        OneOfInSideboard,
        InMainOrSideboard,
        OneOfInMainOrSideboard,
        DoesNotContain
    }
}
