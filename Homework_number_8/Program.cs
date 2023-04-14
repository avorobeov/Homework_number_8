using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_number_8
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberRepeats;
            string message;

            Console.Write("Укажите сколько раз вам вывести смс: ");
            numberRepeats = Convert.ToInt32(Console.ReadLine());

            Console.Write("Укажите текст смс: ");
            message = Console.ReadLine();

            for (int i = 0; i < numberRepeats; i++)
            {
                Console.WriteLine(message);
            }
        }
    }
}
