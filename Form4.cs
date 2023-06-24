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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form f2 = new Form2();
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        //private void button2_Click_1(object sender, EventArgs e);
        private void button2_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string lastname = textBox10.Text;
            string Username = textBox9.Text;
            string E_mail = textBox7.Text;
            string Gender = textBox8.Text;
            string Blood_Group = textBox6.Text;
            string Contact_Number = textBox2.Text;
            string Date = dateTimePicker1.Text;
            string path = @"C:\Users\Ahmed\source\repos\WindowsFormsApp1\WindowsFormsApp1\Student.txt";
            using (StreamWriter sw = File.AppendText(path))
            {
                sw.WriteLine(name);
                sw.WriteLine(lastname);
                sw.WriteLine(Username);
                sw.WriteLine(E_mail);
                sw.WriteLine(Gender);
                sw.WriteLine(Blood_Group);
                sw.WriteLine(Contact_Number);
                sw.WriteLine(Date);
                if (radioButton1.Checked)
                {
                    sw.WriteLine("Paid");
                }
                else
                {
                    sw.WriteLine("Unpaid");
                }
                label10.Text = "Data Saved";
                sw.Close();
            }

        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Hide();
            Form f2 = new Form2();
            f2.ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
