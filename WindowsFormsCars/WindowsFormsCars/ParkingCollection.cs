using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WindowsFormsPlane
{
    public class ParkingCollection
    {
        /// <summary>
        /// Словарь (хранилище) с парковками
        /// </summary>
        readonly Dictionary<string, Parking<APlane>> parkingStages;
        /// <summary>
        /// Возвращение списка названий праковок
        /// </summary>
        public List<string> Keys => parkingStages.Keys.ToList();
       
        /// <summary>
        /// Ширина окна отрисовки
        /// </summary>
        private readonly int pictureWidth;

        /// <summary>
        /// Высота окна отрисовки
        /// </summary>
        private readonly int pictureHeight;

        /// <summary>
        /// Разделитель для записи информации в файл
        /// </summary>
        private readonly char separator = ':';

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="pictureWidth"></param>
        /// <param name="pictureHeight"></param>
        public ParkingCollection(int pictureWidth, int pictureHeight)
        {
            parkingStages = new Dictionary<string, Parking<APlane>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }

        /// <summary>
        /// Добавление парковки
        /// </summary>
        /// <param name="name">Название парковки</param>
        public void AddParking(string name)
        {
            if (parkingStages.ContainsKey(name))
            {
                return;
            }
            parkingStages.Add(name, new Parking<APlane>(pictureWidth, pictureHeight));
        }

        /// <summary>
        /// Удаление парковки
        /// </summary>
        /// <param name="name">Название парковки</param>
        public void DelParking(string name)
        {
            var list = parkingStages.AsEnumerable();

            if (parkingStages.ContainsKey(name))
            {
                parkingStages.Remove(name);
            }
        }

        public void DelParking(int name)
        {
            if (name < Keys.Count && name >= 0)
            {
                if (Keys.Contains(Keys[name]))
                {
                    parkingStages.Remove(Keys[name]);
                }
            }
        }

        /// <summary>
        /// Доступ к парковке
        /// </summary>
        /// <param name="ind"></param>
        /// <returns></returns
        public Parking<APlane> this[string ind]
        {
            get
            {
                if (parkingStages.ContainsKey(ind))
                {
                    
                    return parkingStages[ind];
                }
                return null;
            }
        }

        /// <summary>
        /// Метод записи информации в файл
        /// </summary>
        /// <param name="text">Строка, которую следует записать</param>
        /// <param name="stream">Поток для записи</param>
        private void WriteToFile(string text, FileStream stream)
        {
            byte[] info = new UTF8Encoding(true).GetBytes(text);
            stream.Write(info, 0, info.Length);
        }

        /// <summary>
        /// Сохранение информации по автомобилям на парковках в файл
        /// </summary>
        /// <param name="filename">Путь и имя файла</param>
        /// <returns></returns>
        public bool SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (StreamWriter fs = new StreamWriter(filename))
            {
                fs.Write($"ParkingCollection{Environment.NewLine}");
                foreach (var level in parkingStages)
                {
                    fs.Write($"Parking{separator}{level.Key}{Environment.NewLine}");
                    ITransport plane = null;
                    for (int i = 0; (plane = level.Value.GetNext(i)) != null; i++)
                    {
                        if (plane != null)
                        {
                            //если место не пустое
                            //Записываем тип машины
                            if (plane.GetType().Name == "Plane")
                            {
                                fs.Write($"Plane{separator}");
                            }
                            if (plane.GetType().Name == "RadarPlane")
                            {
                                fs.Write($"RadarPlane{separator}");
                            }
                            //Записываемые параметры
                            fs.Write(((Plane)plane).GetPlaneString() + Environment.NewLine);
                        }
                    }
                }
            }
            return true;
        }

        /// <summary>
        /// Загрузка нформации по автомобилям на парковках из файла
        /// </summary>
        /// <param name="filename"></param>
        /// <returns></returns>
        public void LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }
            using (StreamReader fs = new StreamReader(filename))
            {
                UTF8Encoding temp = new UTF8Encoding(true);
                string strs = fs.ReadLine();
                if (strs.Contains("ParkingCollection"))
                {
                    //очищаем записи
                    parkingStages.Clear();
                }
                else
                {
                    //если нет такой записи, то это не те данные
                    throw new ArgumentException("Неверный формат файла");
                }

                APlane plane = null;
                string key = string.Empty;
                for (int i = 0; (strs = fs.ReadLine()) != null; i++)
                {
                    //идем по считанным записям
                    if (strs.Contains("Parking"))
                    {
                        key = strs.Split(separator)[1];
                        parkingStages.Add(key, new Parking<APlane>(pictureWidth, pictureHeight));
                    }
                    else if (strs.Contains(separator))
                    {
                        if (strs.Contains("Plane"))
                        {
                            plane = new Plane(strs.Split(separator)[1]);
                            ((Plane)plane).LoadPlane(strs, separator);
                        }
                        if (strs.Contains("RadarPlane"))
                        {
                            plane = new RadarPlane(strs.Split(separator)[1]);

                        }
                        if (!(parkingStages[key] + plane))
                        {
                            throw new IndexOutOfRangeException("Не удалось загрузить автомобиль на парковку");
                        }
                    }
                }
            }
        }
    }
}
