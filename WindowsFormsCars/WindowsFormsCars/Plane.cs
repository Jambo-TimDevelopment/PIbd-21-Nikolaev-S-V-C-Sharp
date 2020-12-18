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
    public class Plane : APlane, IEquatable<Plane>
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
        /// Разделитель для записи информации по объекту в файл
        /// </summary>
        protected readonly char separator = ';';

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="maxSpeed">Максимальная скорость</param>
        /// <param name="weight">Вес автомобиля</param>
        /// <param name="mainColor">Основной цвет кузова</param>
        public Plane(int maxSpeed, float weight, Color mainColor)
        {
            MaxSpeed = maxSpeed;
            Weight = weight;
            MainColor = mainColor;
        }
        /// <summary>
        /// Конструктор для загрузки с файла
        /// </summary>
        /// <param name="info">Информация по объекту</param>
        public Plane(string info)
        {
            string[] strs = info.Split(separator);
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
            }
        }

        /// <summary>
        /// Изменение направления пермещения
        /// </summary>
        /// <param name="direction">Направление</param>
        public override void MoveTransport(Direction direction)
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
        public override void DrawTransport(Graphics g)
        {
            Pen pen = new Pen(Color.Black);
            Brush brMain = new SolidBrush(MainColor);

            // Рисуем корпус

            g.FillEllipse(brMain, _startPosX + 80, _startPosY + 50, 50, 20);
            g.FillEllipse(brMain, _startPosX, _startPosY + 50, 40, 20);
            g.FillRectangle(brMain, _startPosX + 10, _startPosY + 50, 100, 20);
            g.FillEllipse(brMain, _startPosX + 10, _startPosY + 30, 20, 60);
            g.FillEllipse(brMain, _startPosX + 70, _startPosY, 20, 120);
        }

        public override string ToString()
        {
            return $"{MaxSpeed}{separator}{Weight}{separator}{MainColor.Name}";
        }

        public string GetPlaneString()
        {
            return $"{MaxSpeed}{separator}{Weight}{separator}{MainColor.Name}";
        }

        public void LoadPlane(string info, char dopSeparator)
        {
            string[] strs = info.Split(separator)[1].Split(dopSeparator);
            if (strs.Length == 3)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                Weight = Convert.ToInt32(strs[1]);
                MainColor = Color.FromName(strs[2]);
            }
        }

        /// <summary>
        /// Метод интерфейса IEquatable для класса Car
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        public bool Equals(Plane other)
        {
            if (other == null)
            {
                return false;
            }
            if (GetType().Name != other.GetType().Name)
            {
                return false;
            }
            if (MaxSpeed != other.MaxSpeed)
            {
                return false;
            }
            if (Weight != other.Weight)
            {
                return false;
            }
            if (MainColor != other.MainColor)
            {
                return false;
            }
            return true;
        }
      
        /// <summary>
        /// Перегрузка метода от object
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(Object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if (!(obj is Plane carObj))
            {
                return false;
            }
            else
            {
                return Equals(carObj);
            }
        }
    }
}