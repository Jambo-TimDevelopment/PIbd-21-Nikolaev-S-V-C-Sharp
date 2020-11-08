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
        private ITransport plane;

        /// <summary>
        /// Конструктор
        /// </summary>
        public FormPlane()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Передача самолета на форму
        /// </summary>
        /// <param name="car"></param>
        public void SetCar(ITransport plane)
        {
            this.plane = plane;
            Draw();
        }

        /// <summary>
        /// Метод отрисовки самолета
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
        private void CreatePlaneButton_Click(object sender, EventArgs e)
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

        private void CreateRadarPlaneButton_Click(object sender, EventArgs e)
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
