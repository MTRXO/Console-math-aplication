using System;
using System.Text.RegularExpressions;

namespace AppBody
{
	class Program
	{
		static void Main(string[] args) //This is a main display function
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
				string choose2 = Console.ReadLine();	
				if(choose2 == "1")
				{
                    //Figure fields
                }
                else if (choose2 == "2")
				{
					Console.Clear();
                    Console.WriteLine("Write below a,b and c and I'll count delta and zero places for you ");
					Console.WriteLine("a:");
					string a = Console.ReadLine();
                    Console.WriteLine("b:");
                    string b = Console.ReadLine();
                    Console.WriteLine("c:");
                    string c = Console.ReadLine();
                    Convert.ToDouble(a);
                    Convert.ToDouble(b);
                    Convert.ToDouble(c);
                    Console.Clear();
                    double Delt= Delta(Convert.ToDouble(a), Convert.ToDouble(b), Convert.ToDouble(c));
                    Console.WriteLine(Delt);
                    Console.WriteLine(IsZeroPlaces(Delt));
                    if (Delt > 0)
                    {
                        Console.WriteLine("Value of zero places:");
                        Console.WriteLine(ZeroPlacesCounterx1(Convert.ToDouble(a), Convert.ToDouble(b), Delt));
                        Console.WriteLine(ZeroPlacesCounterx2(Convert.ToDouble(a), Convert.ToDouble(b), Delt));
                        Console.ReadLine();

                    }
                    else if (Delt < 0)
                    {
                        Console.WriteLine("This function have no zero places");
                        
                    }
                    else if(Delt == 0)
                    {
                        Console.WriteLine("This function have one zero place");
                        Console.WriteLine(OneZeroPlace(Convert.ToDouble(a), Convert.ToDouble(b)));
                       
                    }   

               
                    
                   

                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Wrong input, try again");
                }



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

        }

		static double Delta (double a, double b, double c) //this function count delta value
        {

            double del = (b * b) - (4 * a * c);
            return del;

        }


        static string IsZeroPlaces(double d) //this function check if delta have any zero places
        {
            if (d > 0)
            {
                return "This function have two zero places";

            }
            else if (d < 0)
            {
                return "This function have not zero place";
            }
            else if (d == 0)
            {
                return "This function have one zero place";
            }
            else return "wrong input";
            
        }
        static double ZeroPlacesCounterx1(double a , double b, double delta)
        {
            double x1 = (-b- Math.Sqrt(delta));
            return x1/(2*a);
            
        }
        static double ZeroPlacesCounterx2(double a, double b, double delta)
        {
            double x2 = (-b + Math.Sqrt(delta));
            return x2/(2*a);

        }
        static  double OneZeroPlace(double a, double b)
        {
            double x0 = -b / (2 * a);
            return x0;
        }





    }

}