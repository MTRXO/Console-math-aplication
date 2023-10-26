using System;
using System.Text.RegularExpressions;

namespace AppBody
{
    public class Program
    {

        static void Main(string[] args) //This is a main display function
        {
            while (true)
            {
                Calculations calculations = new Calculations();
                Console.WriteLine("GENERAL MATH CALCULATOR");
                Console.WriteLine("1.Start");
                Console.WriteLine("2.Exit");
                Console.WriteLine("Choose option:");
                string choose1 = Console.ReadLine();

                if (choose1 == "1") // What will happen if u choose any option
                {
                    Console.Clear();
                    Console.WriteLine("Choose topic:");
                    Console.WriteLine("1.Figure fields");
                    Console.WriteLine("2.Quadratic function");
                    string choose2 = Console.ReadLine();

                    if (choose2 == "1") // when user choose firugre fields
                    {
                        Console.Clear();
                        Console.WriteLine("Choose figure");
                        Console.WriteLine("1.Square");
                        Console.WriteLine("2.Rectangle");
                        Console.WriteLine("3.Rectangular triangle");
                        string choose3 = Console.ReadLine();

                        switch (choose3) // Another types of figure fields
                        {
                            case "1":
                                Console.Clear();
                                Console.WriteLine("Square");
                                Console.WriteLine("Write below length of first side: ");
                                string value1 = Console.ReadLine();
                                Console.WriteLine("Field =  " + calculations.SquareField(Convert.ToDouble(value1)));
                                Console.ReadLine();

                                break;

                            case "2":
                                Console.Clear();
                                Console.WriteLine("Rectangle");
                                Console.WriteLine("Write below leanght of both sides");
                                Console.WriteLine("a:");
                                string value2 = Console.ReadLine();
                                Console.WriteLine("b:");
                                string value3 = Console.ReadLine();
                                Console.WriteLine("Field: " + calculations.RectangleField(Convert.ToDouble(value2), Convert.ToDouble(value3)));
                                Console.ReadLine();
                                break;

                            case "3":
                                Console.Clear();
                                Console.WriteLine("Rectangular triangle");
                                Console.WriteLine("Write below a and h ");
                                Console.WriteLine("a:");
                                string value4 = Console.ReadLine();
                                Console.WriteLine("h:");
                                string value5 = Console.ReadLine();
                                Console.WriteLine("Field: " + calculations.RectangularTriangleFiled(Convert.ToDouble(value4), Convert.ToDouble(value5)));
                                Console.ReadLine();

                                break;
                        }


                    }

                    else if (choose2 == "2") //if user choosed a quadratic fucntion
                    {
                        Console.Clear();
                        Console.WriteLine("Write below a,b and c and I'll count delta and zero places for you ");
                        Console.WriteLine("a:");
                        string a = Console.ReadLine();
                        Console.WriteLine("b:");
                        string b = Console.ReadLine();
                        Console.WriteLine("c:");
                        string c = Console.ReadLine();

                        Console.Clear();
                        double Delt = calculations.Delta(Convert.ToDouble(a), Convert.ToDouble(b), Convert.ToDouble(c));
                        Console.WriteLine("Delta: " + Delt);
                        Console.WriteLine(calculations.IsZeroPlaces(Delt));

                        if (Delt > 0) // Here program decides what if delta have specified value
                        {
                            Console.WriteLine("Value of zero places:");
                            Console.WriteLine(calculations.ZeroPlacesCounterx1(Convert.ToDouble(a), Convert.ToDouble(b), Delt));
                            Console.WriteLine(calculations.ZeroPlacesCounterx2(Convert.ToDouble(a), Convert.ToDouble(b), Delt));


                        }
                        else if (Delt < 0)
                        {
                            Console.WriteLine("This function have no zero places");



                        }
                        else if (Delt == 0)
                        {
                            Console.WriteLine("This function have one zero place");
                            Console.WriteLine(calculations.OneZeroPlace(Convert.ToDouble(a), Convert.ToDouble(b)));



                        }
                        Console.ReadLine();

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

        }
    }


    public class Calculations
    {
        public double Delta(double a, double b, double c) //this function count delta value
        {

            double del = (b * b) - (4 * a * c);
            return del;

        }


        public string IsZeroPlaces(double d) //this function check if delta have any zero places
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
        public double ZeroPlacesCounterx1(double a, double b, double delta) //This function count first zero place
        {
            double x1 = (-b - Math.Sqrt(delta));
            return x1 / (2 * a);

        }
        public double ZeroPlacesCounterx2(double a, double b, double delta) //This function count second zero place 
        {
            double x2 = (-b + Math.Sqrt(delta));
            return x2 / (2 * a);

        }
        public double OneZeroPlace(double a, double b) //This function count zero place in case when delta == 0 
        {
            double x0 = -b / (2 * a);
            return x0;
        }
        public double SquareField(double a) //This function count square field 
        {
            return a * a;
        }
        public double RectangleField(double a, double b) //This function count rectangle field
        {
            return a * b;
        }
        public double RectangularTriangleFiled(double a, double h) //This function count  Rectangular triangle filed
        {
            return (a * h) / 2;

        }
    }
    







    

}