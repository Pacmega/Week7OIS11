using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factorial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcButton_Click(object sender, EventArgs e)
        {
            long basenr = Convert.ToInt64(InputBox.Text);
            long resultnr = basenr;

            if(basenr == 0)
            {
                ResultBox.Text = "1";
            }
            if(basenr > 0)
            {
                resultnr = Calc(basenr, resultnr);
            }

            ResultBox.Text = Convert.ToString(resultnr);
        }

        public long Calc(long basenr, long resultnr)
        {
            while (basenr > 1)
            {
                basenr = basenr - 1;
                resultnr = resultnr * basenr;
            }
            return resultnr;
        }
    }
}
