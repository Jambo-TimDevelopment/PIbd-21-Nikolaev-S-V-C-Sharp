using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsPlane
{
    public partial class FormPlane : Form
    {
        private Plane plane;

        /// <summary>
        /// Конструктор
        /// </summary>
        public FormPlane()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Метод отрисовки машины
        /// </summary>
        private void Draw()
        {

            Bitmap bmp = new Bitmap(picturePlane.Width, picturePlane.Height);
            Graphics gr = Graphics.FromImage(bmp);
            plane.DrawTransport(gr);
            picturePlane.Image = bmp;
        }
        /// <summary>
        /// Обработка нажатия кнопки "Создать"
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CreateButton_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();

            plane = new Plane(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Gray);
            plane.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), picturePlane.Width,
           picturePlane.Height);
            Draw();
        }
       
        /// <summary>
        /// Обработка нажатия кнопок управления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMove_Click(object sender, EventArgs e)
        {
            //получаем имя кнопки
            string name = (sender as Button).Name;
            switch (name)
            {
                case "buttonUp":
                    plane.MoveTransport(Direction.Up);
                    break;
                case "buttonDown":
                    plane.MoveTransport(Direction.Down);
                    break;
                case "buttonLeft":
                    plane.MoveTransport(Direction.Left);
                    break;
                case "buttonRight":
                    plane.MoveTransport(Direction.Right);
                    break;
            }
            Draw();
        }

        private void buttonUp_Click(object sender, EventArgs e)
        {
            buttonMove_Click(sender, e);
        }

        private void DownMoveButton_Click(object sender, EventArgs e)
        {
            buttonMove_Click(sender, e);
        }

        private void buttonRight_Click(object sender, EventArgs e)
        {
            buttonMove_Click(sender, e);
        }

        private void buttonLeft_Click(object sender, EventArgs e)
        {
            buttonMove_Click(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int radarType = 1;
            plane = new RadarPlane(rnd.Next(100, 300), rnd.Next(1000, 2000), Color.Gray,
           Color.Black, true, radarType, true, true);
            plane.SetPosition(rnd.Next(10, 100), rnd.Next(10, 100), picturePlane.Width,
           picturePlane.Height);
            Draw();
        }
    }
}
