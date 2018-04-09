/*
 * Created by: Allison Cook
 * Created on: 9 April, 2018
 * Created for: ICS3U Programming
 * Daily Assignment – Day # - Unicode
 * This program shows the letters A - Z with the corrisponding unicdoe number
*/
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UnicodeAllisonC
{
    public partial class frmUnicode : Form
    {
        public frmUnicode()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            //clearing list box
            lstNumber.Items.Clear();

            //variables
            string letter;
            int counter;

            //looping throught letters A(65) to Z(90)
            for (counter = 65; counter <= 90; counter++)
            {

            }

        }
    }
}
