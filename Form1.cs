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
    
    public partial class Static : Form
    {
        int X;
        int Y;
        int numberStatic = 1;
        public Static()
        {
            InitializeComponent();
            MouseDown += Mouse_down;
            MouseUp += Mouse_up;
        }

        private void Mouse_down(object sender, MouseEventArgs e)//отримую координати першої точки
        {
            if (e.Button == MouseButtons.Left)
            {
                X = e.X;
                Y = e.Y;
            }
        }

        private void Mouse_up(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Label label = new Label();                
                if (e.X > X && e.Y > Y)
                {
                    label.Location = new Point(X, Y);
                }
                else if (e.X > X && e.Y < Y)
                {
                    label.Location = new Point(X, e.Y);
                }
                else if (e.X < X && e.Y < Y)
                {
                    label.Location = new Point(e.X, e.Y);
                }
                else
                {
                    label.Location = new Point(e.X, Y);
                }
                if (Math.Abs(e.X - X) < 10 || Math.Abs(e.Y - Y) < 10)
                {
                    MessageBox.Show("Неможна створити статік менший ніж 10х10","Попередження!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    //заполнение опций нового статика
                    label.Size = new Size(Math.Abs(e.X - X), Math.Abs(e.Y - Y));
                    label.Text = $"{numberStatic}";
                    label.ForeColor = Color.White;
                    label.BackColor = Color.Blue;
                    Controls.Add(label);//Добавление нвого статика в коллекцию элементов управления.
                    Text = $"«Статік» №{label.Text} створений!";
                    label.MouseClick += Mouse_click;//подписываем на два события для статика
                    label.MouseDoubleClick += Mouse_Double_click;
                    numberStatic++;
                }
            }           
        }

        private void Mouse_click(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                foreach (Label item in Controls)
                {
                    Point location = item.PointToScreen(Point.Empty);
                    if (MousePosition.X > location.X && MousePosition.X < location.X + item.Width && MousePosition.Y > location.Y && MousePosition.Y < location.Y + item.Height)
                    {
                        Text = $"«Статік» номер №{item.Text}, Площа {item.Width * item.Height}, Координати Х = {item.Location.X} Y = {item.Location.Y}";
                    }
                }
            }
        }

        private void Mouse_Double_click(object sender, MouseEventArgs e)
        {
            int numLabel = numberStatic;
            if (e.Button == MouseButtons.Left)
            {
                foreach (Label item in Controls)
                {
                    Point location = item.PointToScreen(Point.Empty);
                    if (MousePosition.X > location.X && MousePosition.X < location.X + item.Width && MousePosition.Y > location.Y && MousePosition.Y < location.Y + item.Height)
                    {
                        if (numLabel > Convert.ToInt32(item.Text))
                        {
                            numLabel = Convert.ToInt32(item.Text);
                            if (numLabel == Convert.ToInt32(item.Text))
                            {
                                Text = $"«Статік» №{item.Text} видалений!";
                                Controls.Remove(item);
                            }
                        }
                    }
                }              
            }
        }

    }
}
