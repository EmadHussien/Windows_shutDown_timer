using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
namespace shutdownTimer
{
    public partial class logoff : Form
    {
        public logoff()
        {
            InitializeComponent();
        }

        int timeinMin , TimeinSec;

        private void button1_Click(object sender, EventArgs e)
        {
            try {

                if (Time.Text == "")
                    MessageBox.Show("please fill the field");
                else
                {
                    timeinMin = int.Parse(Time.Text);
                    TimeinSec = timeinMin * 60;
                    Process.Start("Shutdown", "-s" + " -t " + TimeinSec);
                    timer1.Start();


                }

            }
            catch
            {
                MessageBox.Show("input must be numbers");
                Time.Text = "";
            }           





        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            if (Time.Text == "")
                MessageBox.Show("timer is off already");
            else
            {
                Time.Text = "";
                Process.Start("Shutdown", "-a");
                timer1.Stop();
            }
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Time_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
