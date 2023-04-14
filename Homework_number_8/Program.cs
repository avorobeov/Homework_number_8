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
            int numberOfSms;

            Console.Write("Укажите сколько раз вам вывести смс: ");
            numberOfSms = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < numberOfSms; i++)
            {
                Console.WriteLine($"Смс номер: {i}");
            }
        }
    }
}
