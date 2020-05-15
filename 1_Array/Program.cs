using System;

namespace _1_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] monthsOfYear =
            {              
                "January",
                "Febru",
                "March",
                "April",
                "May",
                "June",
                "July",
                "August",
                "September",
                "October",
                "November",
                "December"
            };
            Console.WriteLine("Przed zmianą: ");

            foreach (var month in monthsOfYear)

                Console.WriteLine(month);


            monthsOfYear[1] = "February";

            Console.WriteLine("\nPo zmnianie: ");

            foreach (var month in monthsOfYear)

                Console.WriteLine(month);
            /*
        }
            
            Console.WriteLine("Wybierz miesiąc który chcesz wyświetlić ?");
            Console.WriteLine("January = 1, February = 2, itd . : ");

            int month = int.Parse(Console.ReadLine());
            string chosenMonth = monthsOfYear[month - 1];

            Console.WriteLine($"Wybrany miesiąc to {chosenMonth}");
            */
        }
    }
}
