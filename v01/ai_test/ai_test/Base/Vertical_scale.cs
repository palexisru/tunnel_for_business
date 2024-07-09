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
            val = 0;
            val += (short) lv;
            val += (short) al;
            val += (short) s;
            if (ab == Abstraction.Subtract)
                val = (short)-val;
        }
    }
}
