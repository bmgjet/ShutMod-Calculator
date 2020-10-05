using System;
using System.Windows.Forms;

namespace ShuntCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            Setdefaultlimiter();
        }


        private void Setdefaultlimiter()
        {
            try
            {
                float defpl = float.Parse(maskedTextBox1.Text);
                float maxpl = float.Parse(maskedTextBox2.Text);
                float defaulshunt = float.Parse(maskedTextBox3.Text);
                float newshunt = float.Parse(maskedTextBox4.Text);

                float newrestance = (defaulshunt * newshunt) / (defaulshunt + newshunt);
                float sensevoltage1 = (defpl / 12f) * defaulshunt;
                float sensevoltage2 = (maxpl / 12f) * defaulshunt;
                if (checkBox1.Checked)
                {
                    newrestance = newshunt;
                }
                    Double dc = Math.Round(newrestance, 2);
                label9.Text = "New Shunt Restance = " + dc.ToString() + "MΩ";


                label10.Text = defpl.ToString() + "W = " + Math.Round(sensevoltage1, 2).ToString() + "mv Sensor voltage";

                float NewAmps1 = sensevoltage1 / newrestance;
                float NewAmps2 = sensevoltage2 / newrestance;

                double newdefpl = Math.Round(NewAmps1 * 12, 2);
                double newmaxpl = Math.Round(NewAmps2 * 12, 2);


                label11.Text = Math.Round(sensevoltage1, 2).ToString() + "mv now = " + Math.Round(NewAmps1, 2).ToString() + "Amp with " + dc.ToString() + "MΩ";
                label7.Text = newdefpl.ToString() + "W";
                label8.Text = newmaxpl.ToString() + "W";

                label12.Text = "2 Plug: Slot=" + Math.Round(0.205 * newdefpl, 1).ToString() + "W Plug1=" + Math.Round(0.395 * newdefpl, 1).ToString() + "W Plug2=" + Math.Round(0.395 * newdefpl, 1).ToString() + "w";
                label13.Text = "3 Plug: Slot=" + Math.Round(0.19 * newdefpl, 1).ToString() + "W Plug1=" + Math.Round(0.27 * newdefpl, 1).ToString() + "W Plug2=" + Math.Round(0.27 * newdefpl, 1).ToString() + "W Plug3=" + Math.Round(0.27 * newdefpl, 1).ToString() + "W";
            }
            catch
            {

            }
        }


        private void maskedTextBox3_TextChanged(object sender, EventArgs e)
        {
            Setdefaultlimiter();
        }

        private void maskedTextBox2_TextChanged(object sender, EventArgs e)
        {
            Setdefaultlimiter();
        }

        private void maskedTextBox4_TextChanged(object sender, EventArgs e)
        {
            Setdefaultlimiter();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                label4.Text = "Replaced With";
            }
            else
            {
                label4.Text = "Added Shunt";
            }
        }
    }
}
