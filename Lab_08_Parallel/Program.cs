using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Lab_08
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Students =
                {
                "George Washington",
                "Dennis Rodman",
                "Alf",
                "Bill Nye",
                "Gumby",
                "MacGyver",
                "Tina Turner",
                "T-Pain",
                "Scottie Pippen",
                "Fenimore Honeydew",
                "Jabba the Hut",
                "Indiana Jones",
                "Judy Garland",
                "Garfield",
                "Joe Louis",
                "Marvin Gaye",
                "Frank Sinatra",
                "Usain Bolt",
                "Benedict Cumberbatch",
                "Fred Estaire"
                };

            string[] Food =
                {
                "Tacos",
                "Pulled Pork",
                "Cats",
                "Cotton Candy",
                "Tic-Tacs",
                "Duct Tape",
                "PB&J",
                "Quinoa",
                "Steak",
                "Apples",
                "Hamburgers",
                "Shwarma",
                "Coneys",
                "Lasagna",
                "Lucky Charms",
                "Marshmallows",
                "Omelettes",
                "Ice Cream",
                "Donuts",
                "Eclair"
                };

            string[] Songs =
                {
                "Mary Had a Little Lamb",
                "Rocketman",
                "Memory",
                "Blinded Me With Science",
                "The Elephant Show Theme Song",
                "Piano Man",
                "Ice Ice Baby",
                "Mmmbop",
                "Song #2",
                "The Macarena",
                "Hey Jude",
                "Itsy Bitsy Spider",
                "The Rainbow Connection",
                "Mack the Knife",
                "California Love",
                "Stand by Me",
                "Freebird",
                "Chopsticks",
                "Happy Birthday",
                "Be Our Guest"
                };

            bool again = true;
            while (again)

            {
                Console.WriteLine();
                Console.Write("Enter the student's ID number (1-20) you want to learn more about: ");
                string input = Console.ReadLine();
                int index = Validate(input);
                index--;

                Console.WriteLine();
                Console.WriteLine($"That student is {Students[index]}");
                Console.WriteLine();

                Console.WriteLine($"Would you like to know {Students[index]}'s favorite 'food' or 'song to dance to'?");
                Console.WriteLine();

                Console.Write("Type 'food' or 'song': ");
                string foodSong = Console.ReadLine().ToLower();
                string input2 = (ValidateWord(foodSong));

                if (input2 == "food")
                {
                    Console.WriteLine();
                    Console.WriteLine($"{Students[index]}'s favorite food is: {Food[index]}");                    
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine($"{Students[index]}'s favorite song is: \"{Songs[index]}\"");
                }
                again = DoAgain();
            }           

            Console.WriteLine();
            Console.WriteLine("Thank you, this program will now end.");
            Console.ReadLine();
        }

        static int Validate(string input)
        {
            int number;
            while (true)
            {
                if (!int.TryParse(input, out number))
                {
                    Console.WriteLine();
                    Console.Write("Invalid input. Enter a number between 1-20: ");
                    input = Console.ReadLine();
                }
                else if (number < 1 || number > 20)
                {
                    Console.WriteLine();
                    Console.Write("Invalid input. Enter a number between 1-20: ");
                    input = Console.ReadLine();
                }
                else
                {
                    break;
                }
            }

            return number;
        }
            static string ValidateWord(string input)

            {
                while (!(input == "food" || input == "song"))
                {
                    Console.WriteLine("Invalid input. Type 'food' or 'song'.");
                    input = Console.ReadLine();
                }
                return input;
            }

            static bool DoAgain()
            {
                while (true)
                {
                    Console.WriteLine();
                    Console.Write("Would you like to learn about another student? (y/n): ");

                    string input = Console.ReadLine().ToUpper();
                    if (input == "Y")
                    {
                        return true;
                    }
                    else if (input == "N")
                    {
                        return false;
                    }
                    {
                        Console.WriteLine("Not a valid entry.");
                    }
                }
            }
        }
    }
