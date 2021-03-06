﻿using System;
using System.Windows.Forms;

namespace ShuntCalculator
{
    public partial class Form1 : Form
    {
        private double[] storedpowerlimit = new double[4];

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
                //load value from powerlimit.
                float defpl = float.Parse(maskedTextBox1.Text);

                //set up power split
                float slot = int.Parse(maskedTextBox2.Text);
                float plug1 = (defpl - int.Parse(maskedTextBox2.Text)) / 2;
                float plug2 = (defpl - int.Parse(maskedTextBox2.Text)) / 2;
                float plug3 = 0; //Zero since 2 plug card doesnt have this input.

                //3 plug card split
                if (radioButton2.Checked)
                {
                    plug1 = (defpl - int.Parse(maskedTextBox2.Text)) / 3;
                    plug2 = (defpl - int.Parse(maskedTextBox2.Text)) / 3;
                    plug3 = (defpl - int.Parse(maskedTextBox2.Text)) / 3;
                }


                //load shunt values
                float defaulshunt = float.Parse(maskedTextBox3.Text);
                float newshunt = float.Parse(maskedTextBox4.Text);

                //workout new shunt value
                float newrestance = (defaulshunt * newshunt) / (defaulshunt + newshunt);


                //Work out what the sense voltage is for wattage reading circuit.
                float sensevoltage1 = (plug1 / 12f) * defaulshunt;
                float sensevoltage2 = (plug2 / 12f) * defaulshunt;
                float sensevoltage3 = (plug3 / 12f) * defaulshunt;
                float sensevoltageslot = (slot / 12f) * defaulshunt;

                //Check if stacking or replacing
                if (checkBox1.Checked)
                {
                    newrestance = newshunt;
                }


                //output new resistance value on screen.
                Double dc = Math.Round(newrestance, 2);
                label9.Text = "New Shunt Restance = " + dc.ToString() + "mΩ";


                
                //Work out what sense circuit voltage is for wattage.
                float NewAmps1 = sensevoltage1 / newrestance;
                float NewAmps2 = sensevoltage2 / newrestance;
                float NewAmps3 = sensevoltage3 / newrestance;
                float NewAmpsslot = sensevoltageslot / newrestance;


                //work out new power from each input.
                double newslot = Math.Round((slot), 1);
                double newplug1 = Math.Round((NewAmps1 * 12), 2);
                double newplug2 = Math.Round((NewAmps2 * 12), 2);
                double newplug3 = Math.Round((NewAmps3 * 12), 2);


                // check if slot shunt modded
                if (checkBox2.Checked)
                {
                    newslot = Math.Round((NewAmpsslot * 12), 2);
                }


                double newdefpl = newslot + newplug1 + newplug2 + newplug3;
                storedpowerlimit[0] = newslot;
                storedpowerlimit[1] = newplug1;
                storedpowerlimit[2] = newplug2;
                storedpowerlimit[3] = newplug3;

                    label7.Text = (newdefpl).ToString() + "W";
                    trackbar1.Value = 100;
                    plugmaths(newslot, newplug1, newplug2, newplug3);
                    label11.Text = "HWInfo/GPUz Multiplyer: " + Math.Round((newdefpl / defpl),2).ToString();



            }
            catch
            {

            }
        }


        private void plugmaths(double newslot,double newplug1, double newplug2, double newplug3)
        {
            newslot = Math.Round(newslot, 1);
            newplug1 = Math.Round(newplug1, 1);
            newplug2 = Math.Round(newplug2, 1);
            newplug3 = Math.Round(newplug3, 1);

            if (radioButton1.Checked)
            {
                label10.Text = "Slot = " + newslot + "W Plug1 = " + Math.Round(newplug1, 1).ToString() + "W Plug2 = " + Math.Round(newplug2, 1).ToString() + "w";
            }
            else if (radioButton3.Checked)
            {
                label10.Text = "Slot = " + newslot + "W Plug = " + Math.Round(newplug1 + newplug2, 1).ToString() + "W";
            }
            else
            {
                label10.Text = "Slot = " + newslot + "W Plug1 = " + Math.Round(newplug1, 1).ToString() + "W Plug2 = " + Math.Round(newplug2, 1).ToString() + "W Plug3 = " + Math.Round(newplug3, 1).ToString() + "W";
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
            Setdefaultlimiter();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            Setdefaultlimiter();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Setdefaultlimiter();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            Setdefaultlimiter();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Setdefaultlimiter();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/bmgjet/ShutMod-Calculator");
        }

        private void trackbar1_ValueChanged(object sender, EventArgs e)
        {
            label8.Text = trackbar1.Value.ToString() + "%";
            float diff = (trackbar1.Value / 100f);
            double boardpower = storedpowerlimit[0] + storedpowerlimit[1] + storedpowerlimit[2] + storedpowerlimit[3];
            label7.Text = (Math.Round(diff * boardpower, 2)).ToString() + "W";
            plugmaths(diff * storedpowerlimit[0], diff * storedpowerlimit[1],diff * storedpowerlimit[2],diff * storedpowerlimit[3]);
        }

        private void maskedTextBox2_TextChanged_1(object sender, EventArgs e)
        {
            Setdefaultlimiter();
        }
    }
}
