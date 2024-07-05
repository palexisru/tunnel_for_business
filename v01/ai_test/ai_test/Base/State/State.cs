using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ai_test.Base
{
    public enum State
    {
        Unknown = 0,
        Positive = 32,
        Normal = 96,
        Badly = 64,
        Mask = 96
    }
}
