using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {

            double x, y, u; bool r;
            x = WriteDouble("Введите координату x: ");//присваивание 
            y = WriteDouble("Введите координату y: ");//присваивание 

            if (r = (y >= Math.Pow(x, 2) && y >= 0 && y <= 1 && y <= Math.Exp(-x) && y <= Math.Exp(x)) == true)//проверка условия
            {
                u = x + y;
                Console.WriteLine($"Точки x = {x} и y = {y} принадлежат заштрихованной части плоскости; u = {u}");
            }
            else
            {
                u = x - y;
                Console.WriteLine($"Точки x = {x} и y = {y} не принадлежат заштрихованной части плоскости; u = {u}");
            }
            Console.ReadKey();
        }
        public static double WriteDouble(string t)//вспомогательная фукция ввода вещественного числа
        {
            bool ok; double a;
            do
            {
                Console.WriteLine(t);
                string buf = Console.ReadLine();
                ok = double.TryParse(buf, out a);
                if (!ok)
                    Console.WriteLine("Ошибка, введите число");
            } while (!ok);
            return a;
        }
    }
}

