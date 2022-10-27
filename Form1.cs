using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public double AWG(string a, string b, string c, string d)
        {
            double sum = a.Length + b.Length + c.Length + d.Length;            
            return sum/4;
        }
        public double Sum(string a, string b, string c, string d)
        {
            int sum = a.Length + b.Length + c.Length + d.Length;
            return sum ;
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            if (textB1.Text.Length==0 || textB2.Text.Length == 0 || textB3.Text.Length == 0)
            {
                MessageBox.Show("Error , you don`t write evrething");
            }
            else
            {
                MessageBox.Show($"Name - { textB1.Text} \nSurname - { textB2.Text} \n Age - { textB3.Text}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textB4.Text.Length == 0 )
            {
                MessageBox.Show($"Error , {textB4.Name.ToString()} is empty!");
            }
            else
            {
                MessageBox.Show($"Brief informations - { textB4.Text}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textB1.Text.Length == 0 || textB2.Text.Length == 0 || textB3.Text.Length == 0 || textB4.Text.Length == 0 )
            {
                MessageBox.Show("Error , you don`t write evrething");
            }
            else
            {
                MessageBox.Show($"AWG sum of symvol - {AWG(textB1.Text ,textB2.Text, textB3.Text, textB4.Text)}\nSum of symvol - {Sum(textB1.Text, textB2.Text, textB3.Text, textB4.Text)} \nName - { textB1.Text} \nSurname - { textB2.Text} \n Age - { textB3.Text} \n Brief informations {textB4.Text}");
            }
        }
    }
}
