﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MTGOArchetypeParser.App
{
    public interface IOutput
    {
        void Write(Record[] records, ExecutionSettings settings);
    }
}
