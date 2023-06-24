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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // First Name

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form f2 = new Form2();
            f2.ShowDialog();
            //string name = textBox1.Text;
            //string lastname = textBox10.Text;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string name = textBox1.Text;
            string lastname = textBox10.Text;
            string Username = textBox9.Text;
            string E_mail = textBox7.Text;
            string Gender = textBox8.Text;
            string Blood_Group = textBox6.Text;
            string Contact_Number = textBox2.Text;
            string Date = dateTimePicker1.Text;
            string path = @"C:\Users\Ahmed\source\repos\WindowsFormsApp1\WindowsFormsApp1\Teacher.txt";
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
                label10.Text = "Data Saved";
                sw.Close();
            }
            
        }
        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
