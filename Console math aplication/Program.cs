using System;
namespace AppBody
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("GENERAL MATH CALCULATOR");
            Console.WriteLine("1.Start");
            Console.WriteLine("2.Exit");
			Console.WriteLine("Choose option:");
            string choose1 = Console.ReadLine();

			if (choose1 == "1")
			{
				Console.Clear();
				Console.WriteLine("Choose topic:");
                Console.WriteLine("1.Figure fields");
                Console.WriteLine("2.Quadratic function");
				

					


            }
            else if (choose1 == "2")
            {
                Console.Clear();
				Console.WriteLine("You closed this app");
            }
			else
			{
				Console.Clear();
				Console.WriteLine("Wrong input, try again");
			}

		
			Console.ReadLine();



        }

	
	}

}