using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WcfReference.WcfServiceClient client = new WcfReference.WcfServiceClient();

            string choice = "";
            double number1, number2, result;


            while (!choice.Equals("6"))
            {
                Console.WriteLine("1. Prime number");
                Console.WriteLine("2. Sum of digits");
                Console.WriteLine("3. Reverse a string");
                Console.WriteLine("4. Print HTML tags");
                Console.WriteLine("5. Sort 5 numbers");
                Console.WriteLine("6. Exit");
                Console.WriteLine("Enter your choice: ");

                choice = Console.ReadLine();

                try
                {
                    switch (choice)
                    {
                        //Added extra space with console.writeline so that it is clearer to read in console.
                        case "1":
                            Console.WriteLine();
                            Console.WriteLine("Enter a number");
                            var intInput = int.Parse(Console.ReadLine());
                            Console.WriteLine(intInput + " is " + client.CheckIfPrimeNumber(intInput));
                            Console.WriteLine();
                            break;
                        case "2":
                            Console.WriteLine();
                            Console.WriteLine("Enter a number to sum the digits");
                            intInput = int.Parse(Console.ReadLine());
                            Console.WriteLine("The sum of all the digits is " + client.AddDigits(intInput));
                            Console.WriteLine();
                            break;
                        case "3":
                            Console.WriteLine();
                            Console.WriteLine("Enter a string to be reversed");
                            var stringInput = Console.ReadLine();
                            Console.WriteLine("The reversed string is: " + client.ReverseString(stringInput));
                            Console.WriteLine();
                            break;
                        case "4":
                            Console.WriteLine();
                            Console.WriteLine("Enter a tag");
                            var tag = Console.ReadLine();
                            Console.WriteLine("Enter element to be wrapped in tag");
                            stringInput = Console.ReadLine();
                            Console.WriteLine(client.PrintHtmlTag(tag, stringInput));
                            Console.WriteLine();
                            break;
                        case "5":
                            Console.WriteLine();
                            Console.WriteLine("Enter a set of numbers delimited by a comma");
                            stringInput = Console.ReadLine();
                            List<int> intList = stringInput.Split(',').Select(int.Parse).ToList();
                            Console.WriteLine("Type ASC to sort in ascending order, or DESC to sort in descending order");
                            var ascOrDesc = Console.ReadLine();

                            bool ascOrDescBool;
                            if (ascOrDesc.ToUpper() == "ASC")
                            {
                                ascOrDescBool = true;
                            }
                            else if (ascOrDesc.ToUpper() == "DESC")
                            {
                                ascOrDescBool = false;
                            }
                            else
                            {
                                Console.WriteLine("Invalid input");
                                Console.WriteLine();
                                break;
                            }

                            var sortedNumbers = client.SortNumbers(intList.ToArray(), ascOrDescBool);
                            Console.WriteLine(string.Join(",", sortedNumbers));
                            Console.WriteLine();
                            break;
                        default:
                            break;
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine();
                }
            }
        }
    }
}
