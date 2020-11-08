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
    public class RadarPlane 
    {
        /// <summary>
        /// Ширина отрисовки самолета
        /// </summary>
        private readonly int planeWidth = 150;

        /// <summary>
        /// Высота отрисовки самолета
        /// </summary>
        private readonly int planeHeight = 120;

        /// <summary>
        /// Левая координата отрисовки автомобиля
        /// </summary>
        protected float _startPosX;

        /// <summary>
        /// Правая кооридната отрисовки автомобиля
        /// </summary>
        protected float _startPosY;

        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        protected int _pictureWidth;

        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        protected int _pictureHeight;

        /// <summary>
        /// Максимальная скорость
        /// </summary>
        public int MaxSpeed { protected set; get; }

        /// <summary>
        /// Вес автомобиля
        /// </summary>
        public float Weight { protected set; get; }

        /// <summary>
        /// Основной цвет кузова
        /// </summary>
        public Color MainColor { protected set; get; }

        /// <summary>
        /// Дополнительный цвет
        /// </summary>
        public Color DopColor { private set; get; }

        /// <summary>
        /// Тип двигателей
        /// </summary>
        public bool EngineType { private set; get; }

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
            bool radar, int typeRadar, bool antenns, bool engineType)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
            DopColor = dopColor;

            Radar = radar;
            TypeRadar = typeRadar;
            Antenns = antenns;
            EngineType = engineType;
            
        }

        public void SetPosition(int x, int y, int width, int height)
        {
            _startPosX = x;
            _startPosY = y;
            _pictureHeight = height;
            _pictureWidth = width;

        }

        /// <summary>
        /// Изменение направления пермещения
        /// </summary>
        /// <param name="direction">Направление</param>
        public void MoveTransport(Direction direction)
        {
            float step = MaxSpeed * 100 / Weight;
            switch (direction)
            {
                // вправо
                case Direction.Right:
                    if (_startPosX + step < _pictureWidth - planeWidth)
                    {
                        _startPosX += step;
                    }
                    break;
                //влево
                case Direction.Left:
                    if (_startPosX - step > 0)
                    {
                        _startPosX -= step;
                    }
                    break;
                //вверх
                case Direction.Up:
                    if (_startPosY - step > 0)
                    {
                        _startPosY -= step;
                    }
                    break;
                //вниз
                case Direction.Down:
                    if (_startPosY + step < _pictureHeight - planeHeight)
                    {
                        _startPosY += step;
                    }
                    break;
            }
        }

        /// <summary>
        /// Отрисовка автомобиля
        /// </summary>
        /// <param name="g"></param>
        public void DrawTransport(Graphics g)
        {

            Pen pen = new Pen(Color.Black);
            Brush brMain = new SolidBrush(MainColor);

            // Рисуем корпус

            g.FillEllipse(brMain, _startPosX + 80, _startPosY + 50, 50, 20);
            g.FillEllipse(brMain, _startPosX, _startPosY + 50, 40, 20);
            g.FillRectangle(brMain, _startPosX + 10, _startPosY + 50, 100, 20);
            g.FillEllipse(brMain, _startPosX + 10, _startPosY + 30, 20, 60);
            g.FillEllipse(brMain, _startPosX + 70, _startPosY, 20, 120);

            Brush brDop = new SolidBrush(DopColor);

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
                            g.FillEllipse(brMain, _startPosX + 45, _startPosY + 40, 40, 40);
                            g.DrawLine(pen, _startPosX + 65, _startPosY + 40, _startPosX + 65, _startPosY + 80);
                            g.DrawLine(pen, _startPosX + 45, _startPosY + 60, _startPosX + 85, _startPosY + 60);
                        }
                        break;
                }
            }
        }
    }
}