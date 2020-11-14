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
    public partial class FormPlaneConfig : Form
    {
    
        /// <summary>
        /// Переменная-выбранная машина
        /// </summary>
        APlane plane = null;

        /// <summary>
        /// Событие
        /// </summary>
        private event PlaneDelegate eventAddPlane;

        public FormPlaneConfig()
        {
            InitializeComponent();
            buttonCancel.Click += (object sender, EventArgs e) => { Close(); };
            panelColor_Brown.MouseDown += panelColor_MouseDown;
            panelColor_Red.MouseDown += panelColor_MouseDown;
            panelColor_Olive.MouseDown += panelColor_MouseDown;
            panelColor_Green.MouseDown += panelColor_MouseDown;
            panelColor_White.MouseDown += panelColor_MouseDown;
            panelColor_Cyan.MouseDown += panelColor_MouseDown;
            panelColor_Blue.MouseDown += panelColor_MouseDown;
            panelColor_Black.MouseDown += panelColor_MouseDown;
        }

        /// <summary>
        /// Отрисовать машину
        /// </summary>
        private void DrawPlane()
        {
            if (plane != null)
            {
                Bitmap bmp = new Bitmap(pictureBoxPlane.Width, pictureBoxPlane.Height);
                Graphics gr = Graphics.FromImage(bmp);
                plane.SetPosition(5, 5, pictureBoxPlane.Width, pictureBoxPlane.Height);
                plane.DrawTransport(gr);
                pictureBoxPlane.Image = bmp;
            }
        }

        /// <summary>
        /// Добавление события
        /// </summary>
        /// <param name="ev"></param>
        public void AddEvent(PlaneDelegate ev)
        {
            if (eventAddPlane == null)
            {
                eventAddPlane = new PlaneDelegate(ev);
            }
            else
            {
                eventAddPlane += ev;
            }
        }


        /// <summary>
        /// Передаем информацию при нажатии на Label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelBasePlane_MouseDown(object sender, MouseEventArgs e)
        {
            labelBasePlane.DoDragDrop(labelBasePlane.Text, DragDropEffects.Move |
           DragDropEffects.Copy);
        }

        /// <summary>
        /// Передаем информацию при нажатии на Label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void labelRadarPlame_MouseDown(object sender, MouseEventArgs e)
        {
            labelBasePlane.DoDragDrop(labelRadarPlane.Text, DragDropEffects.Move |
           DragDropEffects.Copy);
        }

        /// <summary>
        /// Проверка получаемой информации (ее типа на соответствие требуемому)
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelPlane_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.Text))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        /// <summary>
        /// Действия при приеме перетаскиваемой информации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void planePlane_DragDrop(object sender, DragEventArgs e)
        {
            switch (e.Data.GetData(DataFormats.Text).ToString())
            {
                case "Обычный самолет":
                    plane = new Plane(100, 500, Color.White);
                    break;
                case "Самолет с радаром":
                    plane = new RadarPlane(100, 500.0f, Color.White, Color.Black, checkBox_Radar.Checked,
                        1, checkBox_Antena.Checked, checkBox_Engine.Checked);
                    break;
            }
            DrawPlane();
        }

        /// <summary>
        /// Отправляем цвет с панели
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelColor_MouseDown(object sender, MouseEventArgs e)
        {
            if (sender is Control)
            {
                Control control = sender as Control;
                control.DoDragDrop(control.BackColor, DragDropEffects.Move |
                    DragDropEffects.Copy);
            }
        }

        private void labelBaseColor_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(Color)))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void labelBaseColor_DragDrop(object sender, DragEventArgs e)
        {
            plane.SetMainColor((Color)e.Data.GetData(typeof(Color)));
            DrawPlane();
        }

        private void labelDopColor_DragDrop(object sender, DragEventArgs e)
        {
            if (plane is RadarPlane)
            {
                (plane as RadarPlane).SetDopColor((Color)e.Data.GetData(typeof(Color)));
                DrawPlane();
            }
        }

        private void buttonOk_Click(object sender, EventArgs e)
        {
            eventAddPlane?.Invoke(plane);
            Close();
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
