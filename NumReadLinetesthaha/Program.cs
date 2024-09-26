
using System;
using System.ComponentModel.Design;
namespace NumReadLinetesthaha_original
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.DarkRed;
            string correctpassword = "288";
            Console.WriteLine("Write the password:     (Hint - 144x144x2)");
            string password = Console.ReadLine();
            if (password == correctpassword)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("Write a number please: (not zero)");
                int tal1 = int.Parse(Console.ReadLine());

                Console.WriteLine("Good! Now write a second number: (not zero)");
                int tal2 = int.Parse(Console.ReadLine());

                Console.WriteLine("Thank you! Now you will see the sums of the numbers. (+)");
                Console.WriteLine(tal1 + tal2);

                Console.WriteLine("And now the substractions! (-)");
                Console.WriteLine(tal1 - tal2);

                Console.WriteLine("Then the multiplication! (*)");
                Console.WriteLine(tal2 * tal1);

                Console.WriteLine("And finally the division! (/)");
                Console.WriteLine(tal1 / tal2);

                Console.WriteLine("Cool, now lets do your name! First type your first name:");
                string name = Console.ReadLine();
                Console.WriteLine("Aight, noted. Now write your surname:");
                string surname = Console.ReadLine();
                Console.WriteLine("Yay, so your name is " + name + " " + surname + " am I right?");
                string yepno = Console.ReadLine();
                if (yepno == "yes")
                {

                    Console.WriteLine("Okay, great! Now let me get your city name:");
                    string city = Console.ReadLine();
                    Console.WriteLine("Now, I just want to know where do you want to go? Name a location anywhere:");
                    string resa = Console.ReadLine();

                    Console.WriteLine("Then I want the current year: ");
                    int yearnow = int.Parse(Console.ReadLine());
                    Console.WriteLine("Great, now I want your year of birth: ");
                    int birthyear = int.Parse(Console.ReadLine());

                    Console.WriteLine("Okay, thanks for the info. Now, with your agreement, I will summarize everything. Type \"agree\" to agree!");

                    string agree = Console.ReadLine();
                    if (agree == "agree")
                    {
                        Console.WriteLine("Okay, so your name is " + name + " " + surname + " and you live in " + city + " and you want to go to " + resa + "! +You're " + (yearnow - birthyear) + " years old. Am I right?");
                        
                        string yes1 = Console.ReadLine();
                        if (yes1 == "yes")
                        {
                            Console.WriteLine("Yippie!!");
                            Console.WriteLine("Thanks for using this program! (:");
                            Console.WriteLine("Now double-press Enter to quit.");
                        }
                        else if (yes1 == "no")
                        {
                            Console.WriteLine("Aww, I'm bad at this ):");
                            Console.WriteLine("Thanks for using this program! (:");
                            Console.WriteLine("Now double-press Enter to quit.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid, type yes or no!");
                            Console.WriteLine("Thanks for using this program! (:");
                            Console.WriteLine("Now double-press Enter to quit.");
                        }


                    }
                    else
                    {
                        Console.WriteLine("Since you didn't agree the program ends here! Thanks!");
                        Console.WriteLine("Thanks for using this program! (:");
                        Console.WriteLine("Now double-press Enter to quit.");
                    }
                    Console.ReadKey();
                }
                else if (yepno == "no")
                {
                    Console.WriteLine("Aww, I'm bad at this ):");
                    Console.WriteLine("Thanks for using this program! (:");
                    Console.WriteLine("Now double-press Enter to quit.");
                }
                else
                {
                    Console.WriteLine("Invalid, type yes or no!");
                    Console.WriteLine("Thanks for using this program! (:");
                    Console.WriteLine("Now double-press Enter to quit.");
                }
            }
            else
            {
                Console.WriteLine("Sorry, that was the wrong password!");
                Console.WriteLine("You unfortunately couldn't get acces to this program. If this was a mistake, please try again!");
                Console.WriteLine("Double-press Enter to quit.");
            }
                Console.ReadKey();


            }
        }
    }


