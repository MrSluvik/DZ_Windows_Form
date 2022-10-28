using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DZ_WF
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MouseMove += Mouse_Move;
            MouseClick += Mouse_Click;
        }
        private void Mouse_Click(object sender, MouseEventArgs e)
        {
            string text = "";
            if (e.Button == MouseButtons.Left)
            {
                if (ModifierKeys == Keys.Control)
                {
                    Close();
                }

                if (e.X >= 0 && e.X <= 100 && e.Y == 0 || e.X >= 0 && e.X <= 100 && e.Y == 100 || e.Y >= 0 && e.Y <= 100 && e.X == 0 || e.Y >= 0 && e.Y <= 100 && e.X == 100)
                {
                    text = "Нажаття на ліву клавішу миші було на межі прямокутника!";
                }
                else if (e.X < 100 && e.X>0 && e.Y < 100 && e.Y > 0)
                {
                    text = "Нажаття на ліву клавішу миші було в середині прямокутника!";
                }              
                else
                {
                    text = "Нажаття на ліву клавішу миші було зовні прямокутника!";
                }
                MessageBox.Show(text,"" ,MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (e.Button == MouseButtons.Right)
            {
                Text = $"Розмір клієнської частини вікна!\n Ширина : {ClientSize.Width}|| Висота : {ClientSize.Height}";
                Thread.Sleep(2000);
            }
        }
        private  void Mouse_Move(object sender, MouseEventArgs e)
        {
            Text = $"X - {e.X} || Y - {e.Y}";
        }
    }
}
