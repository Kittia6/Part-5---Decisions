using System;

namespace Part_5___Decisions
{
    class Program
    {
        static void Main(string[] args)
        {
            int age, category, inputnum, randomnum;

            //Stages
            Console.WriteLine("Stages:");
            Console.WriteLine("Please enter your age: ");
            Int32.TryParse(Console.ReadLine(),out age);

            if (age > 18)
            {
                Console.WriteLine("Adult");
            }
            else if (age <= 0)
            {
                Console.WriteLine("Error");
            }
            else if (age <= 5)
            {
                Console.WriteLine("Toddler");
            }
            else if (age <= 10)
            {
                Console.WriteLine("Child");
            }
            else if (age <= 12)
            {
                Console.WriteLine("Preteen");
            }
            else if (age > 12)
            {
                Console.WriteLine("Teen");
            }
           

            Console.WriteLine("");

            //Hurricane
            Console.WriteLine("Hurricane:");
            Console.WriteLine("Please enter your category:");
            Int32.TryParse(Console.ReadLine(), out category);

            if (category == 1)
            {
                Console.WriteLine("74-95mph or 62-82kt or 119-153km/hr");
            }
            else if (category == 2)
            {
                Console.WriteLine("96-110mph or 83-95kt or 154-177km/hr");
            }
            else if (category == 3)
            {
                Console.WriteLine("111-130mph or 96-113kt or 178-209km/hr");
            }
            else if (category == 4)
            {
                Console.WriteLine("131-155mph or 114-135kt or 210-249km/hr");
            }
            else if (category == 5)
            {
                Console.WriteLine("greater than 155mph or 135kt or 249km/hr");
            }
            else
            {
                Console.WriteLine("ERROR");
            }

            Console.WriteLine("");

            //Random Divisible
            Random generator = new Random();

            randomnum = generator.Next(2, 7);
            Console.WriteLine("Random Divisible:");
            Console.WriteLine($"Please enter a number larger than {randomnum}: ");
            Int32.TryParse(Console.ReadLine(), out inputnum);
            if (inputnum < randomnum)
            {
                Console.WriteLine("ERROR");
            }

            else if  (inputnum % randomnum == 0)
            {
                Console.WriteLine("Divisible");
            }

            else if (inputnum % randomnum != 0)
            {
                Console.WriteLine("Not Divisible");
            }

            else
            {
                Console.WriteLine("ERROR");
            }

        }
    }
}
