using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practical_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void card1_Click(object sender, EventArgs e)
        {
            label1.Text = "Eight of Diamond";
        }

        private void card2_Click(object sender, EventArgs e)
        {
            label1.Text = "Two of Clubs";
        }

        private void card3_Click(object sender, EventArgs e)
        {
            label1.Text = "Ten of Spade";
        }

        private void card4_Click(object sender, EventArgs e)
        {
            label1.Text = "Seven of Hearts";
        }

        private void card5_Click(object sender, EventArgs e)
        {
            label1.Text = "Four of Spade";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
