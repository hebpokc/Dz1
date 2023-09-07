using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dz1
{
    class Program
    {
        private static double StringToNum(string input)
        {
            double res;
            if (input.Contains('.'))
            {
                input = input.Replace('.', ',');
            }
            if (double.TryParse(input, out res) == false)
            {
                return double.PositiveInfinity;
            }
            return res;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1");
            Console.WriteLine("a. Мир Труд Май");
            Console.WriteLine("b. Мир\n\tТруд\n\t\tМай");

            Console.WriteLine("\n");

            Console.WriteLine("Задание 2");
            double number1;
            double number2;
            do
            {
                Console.WriteLine("Введите 2 числовые переменные: ");
                number1 = StringToNum(Console.ReadLine());
                number2 = StringToNum(Console.ReadLine());
            } while (number1 == double.PositiveInfinity || number2 == double.PositiveInfinity);

            Console.WriteLine($"\n{number2}\n{number1}");

            Console.WriteLine("\n");

            Console.WriteLine("Задание 3");
            Console.Write("Введите радиус окружности: ");
            int radius = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Длина окружности: {radius * 2 * Math.PI}\nПлощадь круга: {Math.Pow(radius, 2) * Math.PI}");

            Console.WriteLine("\n");

            Console.WriteLine("Задание 4");
            Console.WriteLine("Выберите ввод: \n1) Угол в градусах\n2) Угол в радианах");
            int choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("Введите угол в градусах: ");
                double angle = Convert.ToDouble(Console.ReadLine());
                double radian = (angle * (Math.PI)) / 180;
                Console.WriteLine($"cos({angle}) = {Math.Cos(radian)}");
            }
            else
            {
                Console.WriteLine("Введите угол в радианах: ");
                double angle = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine($"cos({angle}) = {Math.Cos(angle)}");
            }

            Console.WriteLine("\n");

            Console.WriteLine("Задание 5");
            Console.WriteLine("Введите коэффиценты квадратного уравнения: (ax^2+bx+c)");
            Console.Write("a = ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("c = ");
            int c = Convert.ToInt32(Console.ReadLine());
            double discriminant = Math.Pow(b, 2) - (4 * a * c);
            Console.WriteLine($"\nДискриминант = {discriminant}");
            Console.Write("\n");
            if (discriminant > 0)
            {
                double x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                double x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine($"x1 = {x1}\nx2 = {x2}");
            }
            else if (discriminant == 0)
            {
                double x1 = -b / (2 * a);
                Console.WriteLine($"x1 = {x1}");
            }
            else
            {
                Console.WriteLine("Нет корней");
            }

            Console.WriteLine("\n");

            Console.WriteLine("Задание 6");
            Console.WriteLine("Введите значения для обмена:");
            Console.Write("a = ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("b = ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("c = ");
            int num3 = Convert.ToInt32(Console.ReadLine());
            int temp1 = num1;
            int temp2 = num2;
            int temp3 = num3;
            Console.WriteLine($"\na. \na = {num1 = num2}\nb = {num2 = num3}\nc = {num3 = temp1}");
            Console.WriteLine($"\nb. \na = {num1 = temp3}\nb = {num2 = temp1}\nc = {num3 = temp2}");

            Console.WriteLine("\n");

            Console.WriteLine("Задание 7");
            Console.WriteLine("Вывод столбиком 4 случайных чисел");
            Random rnd = new Random();
            int randnum;
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine($"{randnum = rnd.Next(-10, 10)}");
            }

            Console.WriteLine("\n");

            Console.WriteLine("Задание 8");
            Console.WriteLine("Введите трехзначное число: ");
            string num = Console.ReadLine();
            while (num.Length != 3)
            {
                Console.WriteLine("Введено не трехзначное число. Повторите: ");
                num = Console.ReadLine();
            }
            string last = num.Substring(num.Length - 1);
            num = num.Substring(0, num.Length - 1);
            Console.WriteLine(last + num);

            Console.WriteLine("\n");

            Console.WriteLine("Задание 9");
            Console.WriteLine("Цены за 1 кг: конфеты - 500р, печенья - 200р, яблоки - 40р");
            Console.Write("Введите, кол-во кг конфет: ");
            double candies = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите, кол-во кг печенья: ");
            double cookies = Convert.ToDouble(Console.ReadLine());
            Console.Write("Введите, кол-во кг яблок: ");
            double apples = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"\nОбщая стоимость: {(candies * 500) + (cookies * 200) + (apples * 40)} рублей");

            Console.ReadKey();
        }
    }
}
