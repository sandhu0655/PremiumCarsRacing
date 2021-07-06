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
    public partial class Form2 : Form
    {
        // variables holding values
        int Plyr = 0,cr=0,win=0;
        int amt1 = 50, amt2 = 50, amt3 = 50;
        RceTsk Tsk = new RceTsk();
        runer rceTsk = new runer();

        public Form2()
        {
            InitializeComponent();
            genamount();
        }

        //  it is genrating amount
        public void genamount() {
            int y = 5;
            while (y<=50) {
                Bet_selector.Items.Add(y.ToString());
                y = y + 5;
            }
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void lockevery_button_Click(object sender, EventArgs e)
        {
            //here we need to set the vlue 
            if (Tsk.setting(Plyr) == 1 && amt1>=Convert.ToInt32(Bet_selector.SelectedItem.ToString()) &&  amt1>0)
            {
                ghumble_pl.Text = "Ghumble select Car" + cr + " with $" +
                    "" + Bet_selector.SelectedItem;
                race_run_button.Enabled = true;
            }
            else if (Tsk.setting(Plyr) == 2 && amt2 >= Convert.ToInt32(Bet_selector.SelectedItem.ToString()) && amt2>0)
            {
                Manki_pl.Text = "Manki select Car " + cr + " with $" + Bet_selector.SelectedItem;
                race_run_button.Enabled = true;
            }
            else if (Tsk.setting(Plyr) == 3 && amt3 >= Convert.ToInt32(Bet_selector.SelectedItem.ToString()) && amt3>0)
            {
                rao_pl.Text = "Rao select Car " + cr + " with $" + Bet_selector.SelectedItem;
                race_run_button.Enabled = true;
            }
            else {
                MessageBox.Show("Here you need to select the Player and Car with the Bet amount with the balance budget");
            }

            cr = 0; Plyr = 0;
            Manki_pl.Checked = false;
            rao_pl.Checked = false;
            ghumble_pl.Checked = false;
            logonda_car.Checked=false; ferrari_car.Checked = false; bmw_pl.Checked = false; masserti_pl.Checked = false;
        }

        // player value according to checked values

        private void ghumble_pl_CheckedChanged(object sender, EventArgs e)
        {
            if (ghumble_pl.Checked == true) {
                Plyr = 1;
                Manki_pl.Checked = false;
                rao_pl.Checked = false;
            }
        }

        // player value according to checked values

        private void Manki_pl_CheckedChanged(object sender, EventArgs e)
        {
            if (Manki_pl.Checked == true) {
                Plyr = 2;
                ghumble_pl.Checked = false;
                rao_pl.Checked = false;
            }
        }

        // player value according to checked values

        private void logonda_car_CheckedChanged(object sender, EventArgs e)
        {
            if (logonda_car.Checked == true) {
                cr = 1;
                ferrari_car.Checked = false;bmw_pl.Checked = false;masserti_pl.Checked = false;
            }
        }

        // player value according to checked values
        private void ferrari_car_CheckedChanged(object sender, EventArgs e)
        {
            if (ferrari_car.Checked == true) {
                cr = 2;
                logonda_car.Checked = false;masserti_pl.Checked = false;bmw_pl.Checked = false;
            }
        }

        // When run button clicked it starts timer function

        private void race_run_button_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        // accoeding to timer it runs and show the result
        private void timer1_Tick(object sender, EventArgs e)
        {
            logonda1.Left += rceTsk.mve();
            masserti3.Left += rceTsk.mve();
            ferrari2.Left += rceTsk.mve();
            bmw4.Left += rceTsk.mve();
            if (logonda1.Left > rceTsk.stp()) {
                timer1.Stop();
                MessageBox.Show("Logonda won the race");
                win = 1;
                Ghumble(); Mnki(); Rao();
            }

            if (ferrari2.Left > rceTsk.stp()) {
                timer1.Stop();
                MessageBox.Show("Ferrari Won the Race");
                win = 2;
                Ghumble(); Mnki(); Rao();
            }

            if (masserti3.Left > rceTsk.stp())
            {
                timer1.Stop();
                MessageBox.Show("Masserti Won the Race");
                win = 3;
                Ghumble(); Mnki(); Rao();
            }
            if (bmw4.Left > rceTsk.stp())
            {
                timer1.Stop();
                MessageBox.Show("BMW won the race");
                win = 4;
                Ghumble();Mnki();Rao();
            }



        }

         // public fuuctions according to players that can be called 
        public void Ghumble() {
            if (ghumble_pl.Text.Contains("with")) {
                String []h = ghumble_pl.Text.Split(' ');
                if (Convert.ToInt32(h[2]) ==win) {
                    amt1 += Convert.ToInt32(h[4]);
                }
                else
                {
                    amt1 -= Convert.ToInt32(h[4]);
                }
                ghumble_pl.Text = "Sir Ghumble has $" + amt1 + " to Bet ";
                logonda1.Left = 0;masserti3.Left = 0;bmw4.Left = 0; ferrari2.Left = 0;
                ghumble_pl.Checked = false;Manki_pl.Checked = false;rao_pl.Checked = false;
                logonda_car.Checked = false;masserti_pl.Checked = false;ferrari_car.Checked = false;
                bmw_pl.Checked = false;
                Bet_selector.Text = "";
                Plyr = 0;cr = 0;
                win = 0;
                race_run_button.Enabled = false;
            }
        }
        public void Mnki()
        {
            if (Manki_pl.Text.Contains("with"))
            {
                String[] h = Manki_pl.Text.Split(' ');
                if (Convert.ToInt32(h[2]) == win)
                {
                    amt2 += Convert.ToInt32(h[4]);
                }
                else {
                    amt2 -= Convert.ToInt32(h[4]);
                }
                Manki_pl.Text = "Dr Manki has $" + amt2 + " to Bet ";
                logonda1.Left = 0; masserti3.Left = 0; bmw4.Left = 0; ferrari2.Left = 0;
                ghumble_pl.Checked = false; Manki_pl.Checked = false; rao_pl.Checked = false;
                logonda_car.Checked = false; masserti_pl.Checked = false; ferrari_car.Checked = false;
                bmw_pl.Checked = false;
                Bet_selector.Text = "";
                Plyr = 0; cr = 0;
                win = 0;
                race_run_button.Enabled = false;
            }
        }
        public void Rao()
        {
            if (rao_pl.Text.Contains("with"))
            {
                String[] h =rao_pl.Text.Split(' ');
                if (Convert.ToInt32(h[2]) == win)
                {
                    amt3 += Convert.ToInt32(h[4]);
                }
                else
                {
                    amt3 -= Convert.ToInt32(h[4]);
                }
                rao_pl.Text = "Mr Rao has $"+amt3+" to Bet ";
                logonda1.Left = 0; masserti3.Left = 0; bmw4.Left = 0; ferrari2.Left = 0;
                ghumble_pl.Checked = false; Manki_pl.Checked = false; rao_pl.Checked = false;
                logonda_car.Checked = false; masserti_pl.Checked = false; ferrari_car.Checked = false;
                bmw_pl.Checked = false;
                Bet_selector.Text = "";
                Plyr = 0; cr = 0;
                win = 0;
                race_run_button.Enabled = false;
            }
        }

        private void masserti_pl_CheckedChanged(object sender, EventArgs e)
        {
            if (masserti_pl.Checked == true) {
                cr = 3;
                logonda_car.Checked = false; ferrari_car.Checked = false;bmw_pl.Checked = false;
            }
        }

        private void bmw_pl_CheckedChanged(object sender, EventArgs e)
        {
            if (bmw_pl.Checked == true) {
                cr = 4;
                masserti_pl.Checked = false;ferrari_car.Checked = false;logonda_car.Checked = false;
            }
        }

        private void rao_pl_CheckedChanged(object sender, EventArgs e)
        {
            if (rao_pl.Checked == true) {
                Plyr = 3;
                Manki_pl.Checked = false;
                ghumble_pl.Checked = false;
            }
        }
    }
}
