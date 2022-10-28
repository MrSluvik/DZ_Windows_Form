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
           MouseMove+=Mouse_move;
        }       

        private void Mouse_move(object sender, MouseEventArgs e)
        {
            if (e.X > label.Location.X - 30 && e.X < label.Location.X + label.Width + 30 && e.Y > label.Location.Y - 30 && e.Y < label.Location.Y + label.Height + 30)
            {
                if (e.X > label.Location.X - 30 && e.X < label.Location.X)
                {
                    label.Left += 15;
                }
                else if (e.X < label.Location.X + label.Width + 30 && e.X > label.Location.X + label.Width)
                {
                    label.Left -= 15;
                }
                else if (e.Y > label.Location.Y - 30 && e.Y < label.Location.Y)
                {
                    label.Top += 15;
                }
                else if (e.Y < label.Location.Y + label.Height + 30 && e.Y > label.Location.Y + label.Height)
                {
                    label.Top -= 15;
                }
              
                if (label.Location.X < 0 || label.Location.X > ClientSize.Width - label.Width || label.Location.Y < 0 || label.Location.Y > ClientSize.Height - label.Height)
                {
                    label.Left = ClientSize.Width / 2;
                    label.Top = ClientSize.Height / 2;
                }
            }
        }
    }
}
