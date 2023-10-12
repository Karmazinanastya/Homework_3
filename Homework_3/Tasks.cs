using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_3
{
    public static class Tasks
    {
        public static void Task1()
        {
            Console.WriteLine("Введіть рядок:");
            string str = Console.ReadLine();

            int countA = 0;
            int countO = 0;
            int countI = 0;
            int countE = 0;

            foreach (char c in str)
            {
                switch (char.ToLower(c))
                {
                    case 'a':
                        countA++;
                        break;
                    
                    case 'o':
                        countO++;
                        break;
                    
                    case 'i':
                        countI++;
                        break;
                      
                    case 'e':
                        countE++;
                        break;
                   
                }
            }

            Console.WriteLine($"Кількість символів 'а': {countA}");
            Console.WriteLine($"Кількість символів 'о': {countO}");
            Console.WriteLine($"Кількість символів 'і': {countI}");
            Console.WriteLine($"Кількість символів 'е': {countE}");
        }

        public static void Task2()
        {

            Console.WriteLine("Введіть нормер місяця:");
            if (int.TryParse(Console.ReadLine(), out int monthNumber))
            {

            if (monthNumber >= 1 && monthNumber <= 12)
            {
                int daysInMonth = DateTime.DaysInMonth(DateTime.Now.Year, monthNumber);
                Console.WriteLine($"У {monthNumber} місяці {daysInMonth} днів");
            }
            else
            {
                Console.WriteLine("Некоректний номер місяця. Введіть число від 1 до 12.");
            }
            }
            
        }
        public static void Task3()
        {
            int[] numbers = new int[10];

            Console.WriteLine("Введіть 10 цілих чисел:");

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Число {i + 1}: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            int sum = 0;
            int product = 1;
            int positive = 0;

            for (int i = 0; i < 10; i++)
            {
                if (numbers[i] > 0)
                {
                    sum += numbers[i];
                    positive++;
                }
                else
                {
                    product *= numbers[i];
                }
                if (positive == 5)
                    break;
            }
            if (positive == 5)
            {
                Console.WriteLine($"Сума перших 5 додатних елементів: {sum}");
            }
            else
            {
                Console.WriteLine($"Добуток останніх 5 елементів: {product}");
            }

        }
    }    
}
