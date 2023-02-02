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
            Console.WriteLine(Bonus(10000, true));
            Console.WriteLine(Bonus(10000, false));
            //Рисует пирамиду
            Console.Write("Введите количество строк пирамиды: ");
            int row = int.Parse(Console.ReadLine());
            Drawing_the_pyramid(row);
            //Сражение персонажей
            Console.WriteLine(Battle_of_the_characters("ONE", "TWO"));
            Console.WriteLine(Battle_of_the_characters("FOUR", "FIVE"));
            Console.WriteLine(Battle_of_the_characters("ONE", "NEO"));


            Console.ReadKey();
        }
        /* Описание задачи: Дается массив из целых чисел
         * Задача: Нужно вывести его же, но наоборот*/
        public static void Reverse_list(int[] array)
        {        
            Array.Reverse(array);
            foreach (var i in array)
                Console.Write($"{i} ");

        }

        /* Описание задачи: Даны два типа значений = зарплата и премия. Зарпалата будет целым числом, а премия - булевой функцией.
         * Задача: Если премия ложна, то вывод будет только зарплаты. 
         *         Итоговая Сумма должна быть со знаком "$"*/
        public static string Bonus(int salary, bool bonus)
        {
            if (bonus == true)
            {
                salary = salary * 10;
                return $"${salary}";
            }
            else
                return $"${salary}";
        }
        /* Описание задачи: Представьте что вы художник и у вас стоит задача нарисовать пирамиду. Чтобы ее нарисовать следует использовать символы * и _.
         * Задача: Нужно "Нарисовать" пирамиду, где row > 0.
                   В первой строке всегда лишь один символ *
                   В последней строке всегда все символы * */
        public static void Drawing_the_pyramid(int row)
        {
            int consoleCenter = Console.WindowWidth / 16;
            for (int i = 0; i < row; i++)
                Console.WriteLine("*".PadLeft(1 + i * 2, '*').PadLeft(consoleCenter + i, '_').PadRight(i, '_'));
        }

        /* Группы персонажей решили устроить битву.
         * 
           Правила:
           У каждого персонажа своя сила: A = 1, B = 2, ... Y = 25, Z = 26
           Строки состоят только из заглавных букв.
           В поединке могут участвовать только две группы.
           Побеждает та группа, чья общая сила (A + B + C + ...) больше.
        
           Если силы равно, то ничья
           Задача: Помогите им выяснить, какая группа сильнее и выведете её*/
        static string Battle_of_the_characters(string x, string y)
        {
            var letters = new string(Enumerable.Range('a', 'z' - 'a' + 1).Select(c => (char)c).ToArray()).ToUpper();
            var sum_x = get_sum(x, letters);
            var sum_y = get_sum(y, letters);
            if (sum_x > sum_y)
                return $"{x} - сильнее";
                
            else if (sum_x < sum_y)
                return $"{y} - сильнее";                
            else
                return "Ничья";
                
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
