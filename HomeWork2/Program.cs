//Шадрин Максим
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{    
    class Program
    { 
        /// <summary>
        /// Авторизация
        /// </summary>
        /// <param name="Login"></param>
        /// <param name="Password"></param>
        /// <returns>Результат авторизации</returns>
        static bool Authorization(string Login, string Password)
        {
        string MyLogin = "root";
        string MyPassword = "GeekBrains";
        if (Login == MyLogin && Password == MyPassword)
            return true;
        else
            return false;
        }

       /// <summary>
        /// Определение количества цифр в числе
        /// </summary>
        /// <param name="number"></param>
        /// <returns>Количество цифр</returns>
        static int AmountOfDigits(int number)
        {
            int i = 0;
            while (number > 0)
            {
                number = number / 10;
                i++;
            }
            return i;
        }

        /// <summary>
        /// Минимальное из трех чисел
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        /// <returns>Минимальное из трех чисел</returns>
        static int Minimal(int x, int y, int z)
        {
            int Min;
            if (x <= y && x <= z)
                Min = x;
            else if (y <= x && y <= z)
                Min = y;
            else
                Min = z;
            return Min;
        }

        /// <summary>
        /// Сумма цифр числа
        /// </summary>
        /// <param name="a"></param>
        /// <returns>Сумма цифр числа</returns>
        static long RecursiveSum(long a)                    // рекурсивный метод
        {
            if (a == 0)                                  // если a =0
                return 0;                              // возвращаем 0
            else return RecursiveSum(a / 10) + a % 10;   // иначе вызываем рекурсивно сами себя
        }

        /// <summary>
        /// Выводит числа из диапазона
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        static void Chisla(long a, long b)                    // рекурсивный метод
        {
            Console.WriteLine(a);
            a++;
            if (a <= b)                                            
                Chisla(a, b);                 
        }

        /// <summary>
        /// Сумма чисел из диапазона
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>Сумма чисел</returns>
        static int SummaChisel(int a, int b)                    // рекурсивный метод
        {
            if (a <= b)
                return a + SummaChisel(a + 1, b);
            else
                return 0;
        }
        
        static void Main(string[] args)
        {
            #region Задание 1
            /*
            1. Написать метод, возвращающий минимальное из трех чисел.
            */
            Console.Clear();
            Console.WriteLine("Введите 3 числа!");
            Console.Write("Введите 1 число: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Введите 2 число: ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("Введите 3 число: ");
            int z = int.Parse(Console.ReadLine());
            int Min = Minimal(x, y, z);
            Console.WriteLine($"Минимальное число {Min}");
            Console.ReadKey();
            #endregion

            #region Задание 2
            /*
            2.Написать метод подсчета количества цифр числа.
            */
            Console.Clear();
            Console.Write("Введите число: ");
            int number = int.Parse(Console.ReadLine());
            int adigits = AmountOfDigits(number);
            Console.WriteLine($"В числе {adigits} цифр!");
            Console.ReadKey();
            #endregion

            #region Задание 3
            /*
            3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
            */
            int i = 0;
            int num;
            int s = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("Вводите числа. Для окончания введите 0");
                i++;
                Console.Write($"Введите {i} число: ");
                num = int.Parse(Console.ReadLine());
                if (num > 0 && num % 2 > 0)
                    s = s + num;
            }
            while (num != 0);
            Console.Clear();
            Console.WriteLine($"Сумма введенных положительных нечетных чисел равна {s}!");
            Console.ReadKey();
            #endregion

            #region Задание 4
            /*
            4. Реализовать метод проверки логина и пароля. На вход подается логин и пароль. 
            На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
            Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает. 
            С помощью цикла do while ограничить ввод пароля тремя попытками.
            */
            Console.Clear();
            string Login, Password;
            i = 3;
            bool a;
            do
            {
                Console.WriteLine("Введите логин и пароль!");
                Console.Write("Введите логин: ");
                Login = Console.ReadLine();
                Console.Write("Введите пароль: ");
                Password = Console.ReadLine();
                i--;
                a = Authorization(Login, Password);
                if (a)
                    i = 0;
                else
                {
                    Console.Clear();
                    Console.WriteLine($"Логин или пароль введены не верно! Осталось {i} попыток");
                }
            }
            while (i != 0);
            Console.Clear();
            if (a)
                Console.WriteLine("Авторизация прошла успешно!");
            else
                Console.WriteLine("Ошибка авторизации!");
            Console.ReadKey();
            #endregion

            #region Задание 5
            /*
            5. а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
            б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
            */
            Console.Clear();
            Console.WriteLine("Вычисление индекса массы тела.");
            Console.Write("Введите Ваш вес (кг): ");
            double m = double.Parse(Console.ReadLine());
            Console.Write("Введите Ваш рост (см): ");
            double h = double.Parse(Console.ReadLine());
            h = h / 100;
            double l = m / (h * h);
            double dm = 0;
            //определяем на сколько похудеть или поправиться до границы нормы
            if (l < 18.5)
                dm = 18.5 * (h * h) - m;
            else if (l > 25)
                dm = m - 25 * (h * h);

            if (l <= 16)
                Console.WriteLine("Ваш ИМТ равен: {0:F2}. Выраженный дефицит массы тела. Требуется набрать {1:F2} кг", l, dm);
            else if (l > 16 && l < 18.5)
                Console.WriteLine("Ваш ИМТ равен: {0:F2}. Недостаточная (дефицит) масса тела. Требуется набрать {1:F2} кг", l, dm);
            else if (l >= 18.5 && l < 25)
                Console.WriteLine("Ваш ИМТ равен: {0:F2}. Норма.", l);
            else if (l >= 25 && l < 30)
                Console.WriteLine("Ваш ИМТ равен: {0:F2}. Избыточная масса тела (предожирение). Требуется похудеть на {1:F2} кг", l, dm);
            else if (l >= 30 && l < 35)
                Console.WriteLine("Ваш ИМТ равен: {0:F2}. Ожирение. Требуется похудеть на {1:F2} кг", l, dm);
            else if (l >= 35 && l < 40)
                Console.WriteLine("Ваш ИМТ равен: {0:F2}. Ожирение резкое. Требуется похудеть на {1:F2} кг", l, dm);
            else if (l >= 40)
                Console.WriteLine("Ваш ИМТ равен: {0:F2}. Очень резкое ожирение. Требуется похудеть на {1:F2} кг", l, dm);

            Console.ReadKey();
            #endregion

            #region Задание 6
            /*
            6. *Написать программу подсчета количества «Хороших» чисел в диапазоне от 1 до 1 000 000 000. 
            Хорошим называется число, которое делится на сумму своих цифр. 
            Реализовать подсчет времени выполнения программы, используя структуру DateTime.
            */
            Console.Clear();
            DateTime start = DateTime.Now;
            int sum = 0;
            for (i = 1; i <= 1000000; i++)
                if (i % RecursiveSum(i) == 0)
                    sum++;
            DateTime finish = DateTime.Now;
            Console.WriteLine("Количество \"Хороших\" чисел в диапазоне от 1 до 1 000 000 000 равно {0}. Время выполнения {1}", sum, finish - start);
            Console.ReadKey();
            #endregion

            #region Задание 7
            /*
            7. a) Разработать рекурсивный метод, который выводит на экран числа от a до b (a<b);
            б) *Разработать рекурсивный метод, который считает сумму чисел от a до b.
            */
            Console.Clear();
            Console.WriteLine("Рекурсия.");
            Console.Write("Введите число a: ");
            int a1 = int.Parse(Console.ReadLine());
            Console.Write("Введите число b: ");
            int b1 = int.Parse(Console.ReadLine());
            Chisla(a1, b1);
            Console.WriteLine("Сумма чисел: {0}", SummaChisel(a1, b1));
            Console.ReadKey();
            #endregion
        }
    }
}
