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

        private void StartGame_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length==0)
            {
                MessageBox.Show($"Введіть своє число");
            }
            else
            {
                DialogResult result;
                int numDialog = 1;
                while (true)
                {
                    result = MessageBox.Show($"{new Random().Next(1,20)}", "Ви загадали число", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        MessageBox.Show($"Кількість запитів {numDialog}", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        numDialog = 0;
                        result = MessageBox.Show($"Хочете продовжити?", "Вихід", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (result == DialogResult.No) this.Close();
                    }
                    numDialog++;
                }
            }
        }
    }
}
