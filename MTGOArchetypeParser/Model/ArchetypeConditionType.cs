using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.Model
{
    public enum ArchetypeConditionType
    {
        InMainboard,
        InSideboard,
        InMainOrSideboard,
        OneOrMoreInMainboard,
        TwoOrMoreInMainboard,
        DoesNotContain,
        ColorIsExactly,
        ColorMustInclude
    }
}
