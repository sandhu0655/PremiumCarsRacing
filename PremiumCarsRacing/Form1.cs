using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PremiumCarsRacing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Need to Fill Game in the box to start the Game ");
        }

        private void enter_btn_Click(object sender, EventArgs e)
        {
            if (enter_textBox.Text.Equals("Game"))
            {
                MessageBox.Show("Welcome to the Game ");
                Form2 form = new Form2();
                
                form.Show();
            }
            else {
                MessageBox.Show("You need to enter the Game in the Box ");
            }
        }
    }
}
