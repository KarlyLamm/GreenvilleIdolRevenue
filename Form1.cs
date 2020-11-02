/*
 Author: Karly Lamm
Lindenwood University
C# Class
Date: October 30th, 2020
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

namespace GreenvilleRevenueGUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //declare and initialize variables
            int this_year_contestants = 0;
            int last_year_contestants = 0;
            int more_this_year = 0;
            int more_last_year = 0;
            double revenue_expected_2020 = 0.0;

            this_year_contestants = Convert.ToInt32(thisYeartxt.Text);
            last_year_contestants = Convert.ToInt32(lastYeartxt.Text);
            //Print results to screen
            lblContestants.Text = ($"The total number of contestants from 2019 was {last_year_contestants.ToString("")}, and the total number of contestants for this year is {this_year_contestants.ToString("")}");

            //Print if this year has more contestants than last year's
            more_this_year = (this_year_contestants - last_year_contestants);
            more_last_year = (last_year_contestants - this_year_contestants);

            if (this_year_contestants > last_year_contestants)
            {
                lblTurnouttxt.Text=($"This year has more contestants than last year by {more_this_year.ToString("")} people");

            }
            if (last_year_contestants > this_year_contestants)
            {
                lblTurnouttxt.Text=($"Last year has more contestants than this year by {more_last_year.ToString("")} people");
            }
            // Compute the revenue expected and print
            revenue_expected_2020 = (this_year_contestants * 25);
            lblResponse.Text = ($"The revenue this year is expected to be {revenue_expected_2020.ToString("C")}");
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
