using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle_calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Triangle calculator");
            while (true)
            {
                int choice;
                int[] sides = new int[3];
                String demo;
                try { 
                do { 
                    Console.WriteLine("1. Enter triangle dimensions");
                    Console.WriteLine("2. Exit");
                    Console.WriteLine("Enter your choice: ");
                    choice = int.Parse(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:    
                                for (int i = 0; i < 3; i++)
                                {
                                    do
                                    {
                                        Console.WriteLine($"Enter length of side-{i + 1}: ");
                                        sides[i] = int.Parse(Console.ReadLine());
                                    } while (sides[i] <= 0);
                                }
                                Console.WriteLine("Triangle can be formed");
                                demo = TriangleSolver.Analyze(sides[0], sides[1], sides[2]);
                                Console.WriteLine(demo);
                                break;

                        case 2:Environment.Exit(0);
                            break;

                        default: Console.WriteLine("Please enter a valid choice");
                            break;
                    }
                } while (choice != 1 || choice != 2);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid input\nTry again");
                }
            }
        }
    }
}
