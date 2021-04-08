using System;

namespace DecisionMaking
    {
    class Program
        {
        static void Main(string[] args)
            {
            string firstName;
            string lastName;
            string text = "y";
            int number;

            firstName = indent(nameInput("Please input first name: "));
            lastName = indent(nameInput("Please input last name: "));
            Console.WriteLine($"Hello {firstName} {lastName}.\nPlease select an integer number\nbetween 1 and 100 to do some math magic.");
            while (true)
                {
                if (text.ToLower() == "n" || text.ToLower() == "no")
                    {
                    Console.WriteLine("Thank you, Good Bye.");
                    Environment.Exit(0);
                    }
                else if (text.ToLower() == "y" || text.ToLower() == "yes")
                    {
                    number = numberChecker();
                    if (number % 2 == 1)
                        {
                        Console.WriteLine($"{number} Odd");
                        }
                    else
                        {
                        if (number >= 2 && number <= 25)
                            {
                            Console.WriteLine("Even and less than 25");
                            }
                        else if (number >= 26 && number <= 60)
                            {
                            Console.WriteLine("Even");
                            }
                        else
                            {
                            Console.WriteLine($"{number} Even");
                            }
                        //if (number % 2 == 1 && number > 60)
                        //    {
                        //    Console.WriteLine($"{number} odd");
                        //    }
                        }
                    Console.Write("\nContinue? (Y/N): ");
                    text = Console.ReadLine();
                    }
                else
                    {
                    Console.Write($"{text} is not a valid response. Do you want to continue? (Y/N): ");
                    text = Console.ReadLine();
                    }
                }
            } //end Main

        static string indent (string text)
            {
            text = text.Trim();
            if (text.Contains(" "))
                {
                text = text.Substring(0, text.IndexOf(" "));
                }
            text = text.Trim();
            return text.Substring(0, 1).ToUpper() + text.Substring(1).ToLower();
            } //end indent

        static string nameInput(string phrase)
            {
            string text;
            bool checker;
            while (true)
                {
                checker = true;
                Console.Write(phrase);
                text = Console.ReadLine().Trim();
                if (!String.IsNullOrEmpty(text))
                    {
                    foreach (char letter in text.ToCharArray())
                        {
                        if (!Char.IsLetter(letter))
                            {
                            checker = false;
                            }
                        }
                    }
                else
                    {
                    Console.WriteLine("Name cannot be empty.");
                    checker = false;
                    }
                if (checker)
                    {
                    return text;
                    }
                else
                    {
                    Console.WriteLine("Please use Alphabets only.");
                    }
                }
            } //end nameInput

        static int numberChecker ()
            {
            string text;
            int number = 0;
            bool checker = false;
            while (true)
                {
                Console.Write("Entry: ");
                text = Console.ReadLine().Trim();
                    try
                        {
                        number = int.Parse(text);
                        if (number < 0 || number > 100)
                            {
                            Console.WriteLine("Please input in range of 1 to 100 only.");
                            }
                        else
                            {
                            checker = true;
                            }
                        }
                    catch (Exception e)
                        {
                        Console.WriteLine("Please use numbers only.");
                        }
                if (checker)
                    {
                    return number;
                    }
                }
            } //end numberChecker

        }
    }
