using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgeCalculator
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime DOB = Convert.ToDateTime(dateTimePicker1.Text);
            DateTime current = DateTime.Now;
            TimeSpan t = current - DOB;
            DateTime age = DateTime.MinValue.AddDays(t.Days);
            label3.Text = "your" + (age.Year - 1) + " year " + (age.Month) + "months" + (age.Day - 1) + "days old. ";        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
