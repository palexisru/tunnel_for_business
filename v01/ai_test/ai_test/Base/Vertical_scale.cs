using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ai_test.Base
{
    public class Vertical_scale
    {
        private short val; 
        public Vertical_scale(Abstraction ab, Level lv, Algorithm al, Signal s) {
            val = (short)(((short) ab) >> 7 + ((short) lv) >> 5);
            val = (short)(val * 5 + ((short) al) >> 2);
            val += (short) s;
            if (ab == Abstraction.Substrate)
                val = (short)-val;
        }
        public short value { get { return val; } }
    }
}
