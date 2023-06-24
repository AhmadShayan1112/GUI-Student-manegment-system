using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string path2 = @"C:\Users\Ahmed\source\repos\WindowsFormsApp1\WindowsFormsApp1\Student.txt";
            StreamReader sr = new StreamReader(path2);
            while (!sr.EndOfStream)
            {


                label1.Text = label1.Text + "\n" + sr.ReadLine();

                label1.Text = label1.Text + "\n" + sr.ReadLine();

                label1.Text = label1.Text + "\n" + sr.ReadLine();

                label1.Text = label1.Text + "\n" + sr.ReadLine();

                label1.Text = label1.Text + "\n" + sr.ReadLine();

                label1.Text = label1.Text + "\n" + sr.ReadLine();

                label1.Text = label1.Text + "\n" + sr.ReadLine();

                label1.Text = label1.Text + "\n" + sr.ReadLine();

                label1.Text = label1.Text + "\n" + sr.ReadLine();
            }
            sr.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f2 = new Form2();
            f2.ShowDialog();
        }
    }
}
