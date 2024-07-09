using ai_test.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ai_test
{
    public partial class Form_test : Form
    {
        public Form_test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vertical_scale v;
            v = new Vertical_scale(Abstraction.Substrate, Level.Real, Algorithm.Evolution, Signal.Rise);
            text_target.Text = v.value.ToString();
        }
    }
}
