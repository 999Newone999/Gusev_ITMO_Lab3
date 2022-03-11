using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gusev_ITMO_Lab3
{
    /* 
      1. Обязательная задача*. Ввести целочисленные координаты трех вершин прямоугольника, стороны которого параллельны координатным осям. 
     Найти координаты его четвертой вершины. Если пользователь введёт координаты точек так, что нельзя получить прямоугольник со сторонами, 
     параллельными координатным осям, вывести соответствующее сообщение.
      2. На числовой оси расположены три точки: A, B, C. Определить, какая из двух последних точек (B или C) расположена ближе к A, 
     и вывести эту точку и ее расстояние от точки A. Если пользователь введёт координаты B и C так, что они будут равноотстоящими от А,
     совпадать с А или между собой - выдать соответствующее сообщение.\
      3. Обязательная задача*. Дано целое число в диапазоне 20–69, определяющее возраст (в годах). Вывести строку-описание указанного возраста,
     обеспечив правильное согласование числа со словом «год», например: 20 — «двадцать лет», 32 — «тридцать два года», 41 — «сорок один год».
     Если пользователь введёт данные не соответствующие условию задачи - выдать сообщение об ошибке.
      4. Дано целое число в диапазоне 100–999. Вывести строку-описание данного числа, например: 256 — «двести пятьдесят шесть»,
     814 — «восемьсот четырнадцать». Если пользователь введёт данные не соответствующие условию задачи - выдать сообщение об ошибке. 
      */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задачи:");
            Console.WriteLine();
            AboutTask1();
            Console.WriteLine();
            AboutTask2();
            Console.WriteLine();
            AboutTask3();
            Console.WriteLine();
            AboutTask4();
            Console.WriteLine();
            Console.WriteLine();
           
            
            byte taskNumber;
            Console.Write("Введите номер решаемой задачи: ");
            taskNumber = Convert.ToByte(Console.ReadLine());

            while ((taskNumber != 1) & (taskNumber != 2) & (taskNumber != 3) & (taskNumber != 4))
            {
                Console.WriteLine("Задача с введенным номером отсутствует.");
                Console.WriteLine("Первый Commit пошел!");
                Console.Write("Введите номер решаемой задачи: ");
                taskNumber = Convert.ToByte(Console.ReadLine());
            }
            Console.WriteLine();
            Console.WriteLine("Выбрана задача №{0}.", taskNumber);
            if (taskNumber == 1)
            {
                AboutTask1();
                Console.WriteLine();
                Task1();
            }
            else if (taskNumber == 2)
            {
                AboutTask2();
                Console.WriteLine();
                Task2();
            }
            else if (taskNumber == 3)
            {
                AboutTask3();
                Console.WriteLine();
                Task3();
            }
            else // taskNumber == 4
            {
                AboutTask4();
                Console.WriteLine();
                Task4();
            }
            Console.ReadKey();
        }

        static void AboutTask1()
        {
            Console.WriteLine("1. Обязательная задача*. Ввести целочисленные координаты трех вершин прямоугольника, стороны которого параллельны координатным осям. ");
            Console.WriteLine("Найти координаты его четвертой вершины. Если пользователь введёт координаты точек так, что нельзя получить прямоугольник со сторонами,");
            Console.WriteLine("параллельными координатным осям, вывести соответствующее сообщение.");
        }

        static void AboutTask2()
        {
            Console.WriteLine();
            Console.WriteLine("2. На числовой оси расположены три точки: A, B, C. Определить, какая из двух последних точек (B или C) расположена ближе к A,");
            Console.WriteLine("и вывести эту точку и ее расстояние от точки A. Если пользователь введёт координаты B и C так, что они будут равноотстоящими от А,");
            Console.WriteLine("совпадать с А или между собой - выдать соответствующее сообщение.");
        }

        static void AboutTask3()
        {
            Console.WriteLine();
            Console.WriteLine("3. Обязательная задача*. Дано целое число в диапазоне 20–69, определяющее возраст (в годах). Вывести строку-описание указанного возраста,");
            Console.WriteLine("обеспечив правильное согласование числа со словом «год», например: 20 — «двадцать лет», 32 — «тридцать два года», 41 — «сорок один год».");
            Console.WriteLine("Если пользователь введёт данные не соответствующие условию задачи - выдать сообщение об ошибке.");
        }

        static void AboutTask4()
        {
            Console.WriteLine();
            Console.WriteLine(" 4. Дано целое число в диапазоне 100–999. Вывести строку-описание данного числа, например: 256 — «двести пятьдесят шесть»,");
            Console.WriteLine("814 — «восемьсот четырнадцать». Если пользователь введёт данные не соответствующие условию задачи - выдать сообщение об ошибке.");
        }

        static void Task1()
        {
            int X1, Y1, X2, Y2, X3, Y3, X4, Y4;

            Console.WriteLine("Введите координату X первой вершины:");
            X1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату Y первой вершины:");
            Y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите координату X второй вершины:");
            X2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату Y второй вершины:");
            Y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите координату X третьей вершины:");
            X3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите координату Y третьей вершины:");
            Y3 = Convert.ToInt32(Console.ReadLine());

            if (((X1 != X2) & (X1 != X3) & (X2 != X3)) || ((Y1 != Y2) & (Y1 != Y3) & (Y2 != Y3)))
            {
                while (((X1 != X2) & (X1 != X3) & (X2 != X3)) || ((Y1 != Y2) & (Y1 != Y3) & (Y2 != Y3)))
                {
                    Console.WriteLine();
                    Console.WriteLine("Введенные вершины не образуют прямоугольник со сторонами, паралельными координатным осям.");
                    Console.WriteLine();

                    Console.WriteLine("Введите координату X первой вершины:");
                    X1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите координату Y первой вершины:");
                    Y1 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите координату X второй вершины:");
                    X2 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите координату Y второй вершины:");
                    Y2 = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Введите координату X третьей вершины:");
                    X3 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Введите координату Y третьей вершины:");
                    Y3 = Convert.ToInt32(Console.ReadLine());
                }

            }

            if (X1 == X2)
            {
                X4 = X3;
            }
            else
            {
                X4 = X2;
            }

            if (Y1 == Y2)
            {
                Y4 = Y3;
            }
            else
            {
                Y4 = Y2;
            }
            Console.WriteLine();
            Console.WriteLine("координаты четвертой вершины прямоугольника: X4 = {0}, Y4 = {1}.", X4, Y4);
            Console.ReadKey();
        }


        static void Task2()
        {
            double A, B, C;

            Console.WriteLine("Введите значение точки А на числовой оси:");
            Console.Write("А = ");
            A = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение точки B на числовой оси:");
            Console.Write("B = ");
            B = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Введите значение точки C на числовой оси:");
            Console.Write("C = ");
            C = Convert.ToDouble(Console.ReadLine());


            if (Math.Abs(A - B) > Math.Abs(A - C))
            {
                if (A == C)
                {
                    Console.WriteLine("Точка C совпадает с точкой А, а B нет.");
                    Console.WriteLine("Расстояние между точками А и С равно 0.");
                }
                else
                {
                    Console.WriteLine("Точка C ближе к точке А, чем точка B");
                    Console.WriteLine("Расстояние между точками А и С равно {0}.", Math.Abs(A - C));
                }
            }
            else if (Math.Abs(A - B) == Math.Abs(A - C))
            {
                if ((A == B) & (A == C))
                {
                    Console.WriteLine("Точки B и С совпадают с точкой А.");
                    Console.WriteLine("Расстояние между точками А, B и С равно 0.");
                }
                else if (B == C)
                {
                    Console.WriteLine("Точки B и С совпадают.");
                    Console.WriteLine("Расстояние между точками А и B(С) равно {0}.", Math.Abs(A - B));
                }
                else
                {
                    Console.WriteLine("Расстояние между точками А и B равно расстоянию между точками А и С и равно {0}.", Math.Abs(A - B));
                }
            }
            else // Math.Abs(A - B) < Math.Abs(A - C)
            {
                if (A == B)
                {
                    Console.WriteLine("Точка B совпадает с точкой А, а C нет.");
                    Console.WriteLine("Расстояние между точками А и B равно 0.");
                }
                else
                {
                    Console.WriteLine("Точка B ближе к точке А, чем точка C");
                    Console.WriteLine("Расстояние между точками А и B равно {0}.", Math.Abs(A - B));
                }
            }
            Console.ReadKey();
        }

        static void Task3()
        {
            int Age, Dozens, Ones;

            Console.Write("Введите возраст в диапазоне от 22 до 69 лет: ");
            Age = Convert.ToInt32(Console.ReadLine());

            while ((Age < 22) || (Age > 69))
            {
                Console.WriteLine("Вы указали возраст вне разрешенного диапазона.");
                Console.WriteLine();
                Console.Write("Введите возраст в диапазоне от 22 до 69 лет: ");
                Age = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Указанный Вами возраст: ");
            Dozens = Age / 10;
            Ones = Age % 10;

            switch (Dozens)
            {
                case 2:
                    {
                        Console.Write("Двадцать ");
                        break;
                    }
                case 3:
                    {
                        Console.Write("Тридцать ");
                        break;
                    }
                case 4:
                    {
                        Console.Write("Сорок ");
                        break;
                    }
                case 5:
                    {
                        Console.Write("Пятьдесят ");
                        break;
                    }
                case 6:
                    {
                        Console.Write("Шестьдесят ");
                        break;
                    }
                default:
                        {
                        Console.Write("Чушь какая то с десятками! ");
                        break;
                        }
            }

            switch (Ones)
            {
                case 1:
                    {
                        Console.Write("один год.");
                        break;
                    }
                case 2:
                    {
                        Console.Write("два года.");
                        break;
                    }
                case 3:
                    {
                        Console.Write("три года.");
                        break;
                    }
                case 4:
                    {
                        Console.Write("четыре года.");
                        break;
                    }
                case 5:
                    {
                        Console.Write("пять лет.");
                        break;
                    }
                case 6:
                    {
                        Console.Write("шесть лет.");
                        break;
                    }
                case 7:
                    {
                        Console.Write("семь лет.");
                        break;
                    }
                case 8:
                    {
                        Console.Write("восемь лет.");
                        break;
                    }
                case 9:
                    {
                        Console.Write("девять лет.");
                        break;
                    }
                default:
                    {
                        Console.Write("Чушь какая то с единицами! ");
                        break;
                    }
            }

           // Console.WriteLine("Dozens = {0}; Ones = {1}.", Dozens, Ones);
            Console.ReadKey();
        }

        static void Task4()
        {
            int Number, Hundreds, Dozens, Ones;

            Console.Write("Введите целое число в диапазоне от 100 до 999 лет: ");
            Number = Convert.ToInt32(Console.ReadLine());

            while ((Number < 100) || (Number > 999))
            {
                Console.WriteLine("Вы указали возраст вне разрешенного диапазона.");
                Console.WriteLine();
                Console.Write("Введите возраст в диапазоне от 22 до 69 лет: ");
                Number = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("Указанное Вами число: ");
            Hundreds = Number / 100;
            Dozens = (Number % 100) / 10;
            Ones = (Number % 100) % 10;

            switch (Hundreds)
            {
                case 1:
                    {
                        Console.Write("Сто ");
                        break;
                    }
                case 2:
                    {
                        Console.Write("Двести ");
                        break;
                    }
                case 3:
                    {
                        Console.Write("Триста ");
                        break;
                    }
                case 4:
                    {
                        Console.Write("Четыреста ");
                        break;
                    }
                case 5:
                    {
                        Console.Write("Пятьсот ");
                        break;
                    }
                case 6:
                    {
                        Console.Write("Шестьсот ");
                        break;
                    }
                case 7:
                    {
                        Console.Write("семьсот ");
                        break;
                    }
                case 8:
                    {
                        Console.Write("восемьсот ");
                        break;
                    }
                case 9:
                    {
                        Console.Write("девятьсот ");
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            switch (Dozens)
            {
                case 2:
                    {
                        Console.Write("двадцать ");
                        break;
                    }
                case 3:
                    {
                        Console.Write("тридцать ");
                        break;
                    }
                case 4:
                    {
                        Console.Write("сорок ");
                        break;
                    }
                case 5:
                    {
                        Console.Write("пятьдесят ");
                        break;
                    }
                case 6:
                    {
                        Console.Write("шестьдесят ");
                        break;
                    }
                case 7:
                    {
                        Console.Write("семьдесят ");
                        break;
                    }
                case 8:
                    {
                        Console.Write("восемьдесят ");
                        break;
                    }
                case 9:
                    {
                        Console.Write("девяносто ");
                        break;
                    }
                default:
                        {
                        break;
                        }
            }

            switch (Ones)
            {
                case 1:
                    {
                        Console.Write("один.");
                        break;
                    }
                case 2:
                    {
                        Console.Write("два.");
                        break;
                    }
                case 3:
                    {
                        Console.Write("три.");
                        break;
                    }
                case 4:
                    {
                        Console.Write("четыре.");
                        break;
                    }
                case 5:
                    {
                        Console.Write("пять.");
                        break;
                    }
                case 6:
                    {
                        Console.Write("шесть.");
                        break;
                    }
                case 7:
                    {
                        Console.Write("семь.");
                        break;
                    }
                case 8:
                    {
                        Console.Write("восемь.");
                        break;
                    }
                case 9:
                    {
                        Console.Write("девять.");
                        break;
                    }
                default:
                    {
                        break;
                    }
            }

           // Console.WriteLine("Dozens = {0}; Ones = {1}.", Dozens, Ones);
            Console.ReadKey();
        }
    }
}
