using System;
using System.Collections.Generic;
using System.Text;

namespace practice_2
{
    class Program
    {
        static void Main(string[] args)
        {
                string Name = "anand", Name1 = "haresh"; // we have declared mutliple values of same data type seprating with commas.
                Console.WriteLine(Name + " " + Name1);

                int a = 12, b = 15, c = 56;
                Console.WriteLine(a + b + c);



                /*
                 //we are asking here for username and then asking for an output to show that the username is ......
                Console.WriteLine(" Enter the username ");

                string userName = Console.ReadLine();
                Console.WriteLine(" Username is " + userName);*/

                //================================================

                /*Console.WriteLine("Enter you age ");
                int age = Convert.ToInt32(Console.Read());
                Console.WriteLine("The age is " + age);*/
                //================================================

                int x = 23;
                x++;            //Increases the value of a variable by 1  opposite for -- it will decrease by 1 
                Console.WriteLine(x);

                int y = 10;
                y += 5; // it will add 5 to existing y value
                Console.WriteLine(x);

                int t = 34;
                int u = 65;

                Console.WriteLine(t > u);
                Console.WriteLine(t < u);
                //================================================

                string greeting = " Hello Anand";
                string greetings = " Hello we are here";
                Console.WriteLine(greeting);
                Console.WriteLine(greetings);

                //================================================
                string txt = " Anand lets see how the string length work.";
                Console.WriteLine("The length of above lines is " + txt.Length); // the output will be 43

                Console.WriteLine(txt.ToUpper());


                //================================================
                string FirstName = "Anand";
                string LastName = "Hanjhro";
                string name = FirstName + LastName;
                Console.WriteLine(name);


                // string interpolation 
                string firstName = "Anand";
                string lastName = "Meghwar";
                string fullname = $"My full name is {firstName} { lastName}";
                Console.WriteLine(fullname);

                Console.WriteLine(FirstName[2]); // we gave index and it will show character on that index ---output will be a
                Console.WriteLine(LastName[5]); // r  will be output 


                // we want to print the time here
                Console.WriteLine(System.DateTime.Now.ToString("dd-MM-yyyy"));






                Console.ReadLine();
            }


        }
    }


