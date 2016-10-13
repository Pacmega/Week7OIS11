using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToetsopdrachtWk7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, EventArgs e)
        {
            //This isn't actually what we are supposed to do, but by repopulating the boxes after the button click the application can be tested several times
            Random Pop = new Random();
            int NewEntry;
            for(int i = 0; i < 20; i++)
            {
                NewEntry = Pop.Next(1, 100);
                if (i<10)
                {
                    FORlist.Items.Add(NewEntry);
                }
                else
                {
                    WHILElist.Items.Add(NewEntry);
                }
            }

            int FORtotal = FORmethod();
            int WHILEtotal = WHILEmethod();

            //FOR is the left list, WHILE is the right list
            if(FORtotal > WHILEtotal)
            {
                ResultBox.Text = "The left ListBox has the highest total value: " + FORtotal + "!";
                FORlist.BackColor = Color.Green;
                WHILElist.BackColor = Color.Red;
            }
            else
            {
                ResultBox.Text = "The right ListBox has the highest total value: " + WHILEtotal + "!";
                WHILElist.BackColor = Color.Green;
                FORlist.BackColor = Color.Red;
            }
        }

        public int FORmethod()
        {
            int FORtotal = 0;

            for (int i = 0; i < 10; i++)
            {
                FORtotal = FORtotal + Convert.ToInt32(FORlist.Items[i].ToString());
            }

            return FORtotal;
        }

        public int WHILEmethod()
        {
            int WHILEtotal = 0;

            //TODO: create while loop

            return WHILEtotal;
        }
    }
}
