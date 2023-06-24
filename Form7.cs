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
using static System.Net.Mime.MediaTypeNames;

namespace WindowsFormsApp1
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
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
            string path2 = @"C:\Users\Ahmed\source\repos\WindowsFormsApp1\WindowsFormsApp1\Teacher.txt";
           // LinkedList<LinkedList<string>> myList = new LinkedList<LinkedList<string>>();
           // LinkedList<string> myList1 = new LinkedList<string>();
            List<List<string>> mylist = new List<List<string>>();
            //mylist.Add(new List<string>());
            //mylist[0].Add(name);
            string data="/0";
            int i = 0;
            StreamReader sr = new StreamReader(path2);
            while (!sr.EndOfStream)
            {
                mylist.Add(new List<string>());
                mylist[i].Add(sr.ReadLine());
                mylist[i].Add(sr.ReadLine());
                mylist[i].Add(sr.ReadLine());
                mylist[i].Add(sr.ReadLine());
                mylist[i].Add(sr.ReadLine());
                mylist[i].Add(sr.ReadLine());
                mylist[i].Add(sr.ReadLine());
                mylist[i].Add(sr.ReadLine());
                data = mylist[i][7];
                i = i + 1;
            }
            sr.Close();
            for(int j = 0; j < i; j++)
            {
                for(int k = 0; k < 8; k++)
                {
                    if ((this.id-1)==j)
                    {
                        if (k == 0)
                        {
                            mylist[j][k] = name;
                        }
                        if (k == 1)
                        {
                            mylist[j][k] = lastname;
                        }
                        if (k == 2)
                        {
                            mylist[j][k] = Username;
                        }
                        if (k == 3)
                        {
                            mylist[j][k] = E_mail;
                        }
                        if (k == 4)
                        {
                            mylist[j][k] = Gender; 
                        }
                        if (k == 5)
                        {
                            mylist[j][k] = Blood_Group;
                        }
                        if (k == 6)
                        {
                            mylist[j][k] = Contact_Number;
                        }
                        if (k == 7)
                        {
                            mylist[j][k] = Date;
                        }
                    }
                }
            }
            using (StreamWriter sw = new StreamWriter(path2))
            {

            }
            for (int j = 0; j < i; j++)
            {
                for (int k = 0; k < 8; k++)
                {
                    using (StreamWriter sw = File.AppendText(path2))
                    {
                        sw.WriteLine(mylist[j][k]);
                        
                    }
                }
            }
            label10.Text = "Data Edited";
            //buckets[9] = new List<string>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.ShowDialog();
        }
    }
}
