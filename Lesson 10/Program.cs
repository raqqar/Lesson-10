using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_10
{
    // Угол задан с помощью целочисленных значений gradus - градусов, min - угловых минут, sec - угловых секунд.
    // Реализовать класс, в котором указанные значения представлены в виде свойств.
    // Для свойств предусмотреть проверку корректности данных.
    // Класс должен содержать конструктор для установки начальных значений, а также метод ToRadians для перевода угла в радианы.
    // Создать объект на основе разработанного класса. Осуществить использование объекта в программе.
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Введите значение градусов");
                int grad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите значение минут градусов ");
                int grMin = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите значение секунд градусов");
                int grSec = Convert.ToInt32(Console.ReadLine());

                ConvToRadian conv = new ConvToRadian(grad, grMin, grSec);
                conv.ToRadian();

                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
            }

        }

        class ConvToRadian
        {
            int gradus;
            int min;
            int sec;
            public int Gradus
            {
                set
                {
                    if (value > 0)
                    {
                        gradus = value;
                    }
                    else
                    {
                        Console.WriteLine("Значение градусов не может быть меньше 0");
                    }
                }
                get
                {
                    return gradus;
                }

            }
            public int Min
            {
                set
                {
                    if (value > 0)
                    {
                        min = value;
                    }
                    else
                    {
                        Console.WriteLine("Значение минут градусов не может быть меньше 0");

                    }
                }
                get
                {
                    return min;
                }
            }
            public int Sec
            {
                set
                {
                    if (value > 0)
                    {
                        sec = value;
                    }
                    else
                    {
                        Console.WriteLine("Значение минут градусов секунд не может быть меньше 0");
                    }
                }
                get
                {
                    return sec;
                }
            }

            public ConvToRadian(int gradus = 1, int min = 1, int sec = 1)
            {
                Gradus = gradus;
                Min = min;
                Sec = sec;
            }
            public void ToRadian()
            {
                double ToRadian = (Math.PI / 180) * (Gradus + (Min / 60) + (Sec / 3600));
                Console.WriteLine("При переводе в радианы получаем {0:N4}", ToRadian);
                return;
            }
        }


    }

}
