using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Okorokov
    {
        public static void Main()
        {
            //Переворачивает массив чисел
            Reverse_list(new int[] { 1, 2, 3 });

            //Начисление премии 
            Console.Write("Введите зарплату: ");
            int salary = int.Parse(Console.ReadLine());
            Console.Write("Имеется ли премия? (True/False): ");
            bool bonus = bool.Parse(Console.ReadLine());
            Bonus(salary, bonus);
            //Рисует пирамиду
            Console.Write("Введите количество строк пирамиды: ");
            int row = int.Parse(Console.ReadLine());
            Drawing_the_pyramid(row);
            //Сражение персонажей
            Battle_of_the_characters("ONE", "TWO");


            Console.ReadKey();
        }
        public static void Reverse_list(int[] array)
        {        
            Array.Reverse(array);
            foreach (var i in array)
                Console.Write($"{i} ");

        }
        public static void Bonus(int salary, bool bonus)
        {
            if (bonus == true)
            {
                salary = salary * 10;
                Console.WriteLine($"$" + salary);
            }
            else
                Console.WriteLine($"$" + salary);
        }
        public static void Drawing_the_pyramid(int row)
        {
            int consoleCenter = Console.WindowWidth / 16;
            for (int i = 0; i < row; i++)
                Console.WriteLine(
                    "*".PadLeft(1 + i * 2, '*').PadLeft(consoleCenter + i, '_').PadRight(i, '_'));
        }

        static void Battle_of_the_characters(string x, string y)
        {
            var letters = new string(Enumerable.Range('a', 'z' - 'a' + 1).Select(c => (char)c).ToArray()).ToUpper();
            var sum_x = get_sum(x, letters);
            var sum_y = get_sum(y, letters);
            if (sum_x > sum_y)
                Console.WriteLine($"{x} - сильнее");
                
            else if (sum_x < sum_y)
                Console.WriteLine($"{y} - сильнее");                
            else
                Console.WriteLine("Ничья");
                
        }
        static int get_sum(string a, string letters)
        {
            int sum = 0;
            for (int i = 0; i < a.Length; i++)
            {
                sum += letters.IndexOf(a[i]) + 1;
            }
            return sum;
        }

    }
}
