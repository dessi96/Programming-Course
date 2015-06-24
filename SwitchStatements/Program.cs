using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchStatements
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Random numberGenerator = new Random();

            int num01 = numberGenerator.Next(1, 11);
            int num02 = numberGenerator.Next(1, 11);

            Console.WriteLine("What is " + num01 + " times " + num02 + " ? ");

            int answer = Convert.ToInt32(Console.ReadLine());

            if (answer == num01 * num02)
            {
                int responseIndex = numberGenerator.Next(1, 4);

                switch (responseIndex)
                {
                    case 1:
              Console.WriteLine("Correct!");
              break;
                    case 2:
              Console.WriteLine("Good job!");
              break;
                    default:
              Console.WriteLine("Excellent!");
              break;
            }
            }
            else
            {
                int responseIndex = numberGenerator.Next(1, 4);

                switch (responseIndex)
                {
                    case 1:
                        Console.WriteLine("Are you even trying?");
                        break;
                    case 2:
                        Console.WriteLine("The answer is incorrect!");
                        break;
                    default:
                        Console.WriteLine("You can do better than that!");
                        break;

                }

              }

            Console.ReadKey();
        }
    }
}
