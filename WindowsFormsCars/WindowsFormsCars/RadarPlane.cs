using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsPlane
{
    /// <summary>
    /// Класс отрисовки самолета
    /// </summary>
    public class RadarPlane : Plane
    {
        /// <summary>
        /// Дополнительный цвет
        /// </summary>
        public Color DopColor { private set; get; }

        /// <summary>
        /// Тип двигателей
        /// </summary>
        public bool Engine { private set; get; }

        /// <summary>
        /// Наличие радара
        /// </summary>
        public bool Radar { private set; get; }

        /// <summary>
        /// Наличие антены
        /// </summary>
        public bool Antenns { private set; get; }

        /// <summary>
        /// Форма радара
        /// </summary>
        public int TypeRadar { private set; get; }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        /// <param name="dopColor">Дополнительный цвет</param>
        /// <param name="frontSpoiler">Признак наличия переднего спойлера</param>
        /// <param name="sideSpoiler">Признак наличия боковых спойлеров</param>
        /// <param name="backSpoiler">Признак наличия заднего спойлера</param>
        /// <param name="sportLine">Признак наличия гоночной полосы</param>
        public RadarPlane(int maxSpeed, float weight, Color mainColor, Color dopColor, 
            bool radar, int typeRadar, bool antenns, bool engine) : base( maxSpeed,  weight,  mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;

            Radar = radar;
            TypeRadar = typeRadar;
            Antenns = antenns;
            Engine = engine;
            
        }

        /// <summary>
        /// Отрисовка автомобиля
        /// </summary>
        /// <param name="g"></param>
        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush brMain = new SolidBrush(MainColor);
            Brush brDop = new SolidBrush(DopColor);

            if (Engine)
            {
                g.FillRectangle(brDop, _startPosX + 75, _startPosY + 20, 30, 10);
                g.FillRectangle(brDop, _startPosX + 75, _startPosY + 92, 30, 10);
            }

            base.DrawTransport(g);

            // Рисуем радар 
            if (Antenns)
            {
                g.DrawLine(pen, _startPosX + 150, _startPosY + 60, _startPosX + 130, _startPosY + 60);
            }

            // Рисуем радар
            if (Radar)
            {
                switch (TypeRadar)
                {
                    case 0: 
                        {
                            g.FillEllipse(brDop, _startPosX + 45, _startPosY + 40, 40, 40);
                            g.DrawEllipse(pen, _startPosX + 45, _startPosY + 40, 40, 40);
                        }
                        break;

                    case 1:
                        {
                            g.DrawEllipse(pen, _startPosX + 45, _startPosY + 40, 40, 40);
                            g.FillEllipse(brDop, _startPosX + 45, _startPosY + 40, 40, 40);
                            g.DrawLine(pen, _startPosX + 65, _startPosY + 40, _startPosX + 65, _startPosY + 80);
                            g.DrawLine(pen, _startPosX + 45, _startPosY + 60, _startPosX + 85, _startPosY + 60);
                        }
                        break;
                }
            }
        }

        /// <summary>
        /// Смена дополнительного цвета
        /// </summary>
        /// <param name="color"></param>
        public void SetDopColor(Color color)
        {
            DopColor = color;
        }
    }
}