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
                    Console.WriteLine("3.Unit Converter");
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
                            Console.Clear();
                            Console.WriteLine("This function have no zero places");



                        }
                        else if (Delt == 0)
                        {
                            Console.WriteLine("This function have one zero place");
                            Console.WriteLine(calculations.OneZeroPlace(Convert.ToDouble(a), Convert.ToDouble(b)));



                        }
                        Console.ReadLine();

                    } 

                    else if (choose2 == "3")
                    {
                        Console.Clear();
                        Console.WriteLine("Choose type of units");
                        Console.WriteLine("1.Lenght");
                        Console.WriteLine("2.Weight");
                        string choose4 = Console.ReadLine();
                        if (choose4 == "1")
                        {
                            Console.Clear();
                            Console.WriteLine("Choose the base units");
                            Console.WriteLine("1.Milimeters");
                            Console.WriteLine("2.Centimeters");
                            Console.WriteLine("3.Meters");
                            string choose5 = Console.ReadLine();
                            Console.Clear();
                            Console.WriteLine("Give me amount of units:");
                            double BaseUnitsAmount = Convert.ToDouble(Console.ReadLine());
                           
                        }
                        else if (choose4 == "2") 
                        {
                            //body
                        }
                        else
                        {
                            Console.WriteLine("Wrong input");
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
                    break;
                    
                }
                else
                {
                    Console.Clear();
                    Console.WriteLine("Wrong input, try again");
                }

            }

        }
    }


    





    

}