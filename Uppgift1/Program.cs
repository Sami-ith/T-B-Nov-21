using System;
using System.IO;
using System.Collections.Generic;
namespace Uppgift1
{
    class Program
    {
        //This class is used in function 16 to make an instance of player.
        class Charcter
        {
            string name;
            int health;
            int strength;
            int luck;

            public void setCharacter(string n)
            {
                this.name = n;
                Random random = new Random();
                // A player has these three properties that will be filled by random numbers.
                health = random.Next(1, 100);
                strength = random.Next(1, 10);
                luck = random.Next(1, 100);
            }
            public String getCharcter()
            {
                return this.name+"/"+this.health+"/"+this.luck+"/"+this.strength;
            }

        }
        static void Main(string[] args)
        {
            // The main menu contains all functions shortcut, to end the program the user should press 0 key.
            string userKey="1";
            while (userKey !="0")
            {
                Console.WriteLine("******Wellcom*******");
                Console.WriteLine("\t"+"0-Exit");
                Console.WriteLine("\t" + "1-Hello World!");
                Console.WriteLine("\t" + "2-Input User Information");
                Console.WriteLine("\t" + "3-Change text color");
                Console.WriteLine("\t" + "4-Print date");
                Console.WriteLine("\t" + "5-Compare two numbers and print the greater one");
                Console.WriteLine("\t" + "6-Guessing number game");
                Console.WriteLine("\t" + "7-Save file.");
                Console.WriteLine("\t" + "8-Read from file.");
                Console.WriteLine("\t" + "9-Return Decimal numbers root ");
                Console.WriteLine("\t" + "10-Multiplication Table");
                Console.WriteLine("\t" + "11-Create and sort an array");
                Console.WriteLine("\t" + "12-Identify Palindrome word");
                Console.WriteLine("\t" + "13-Print numbers in range");
                Console.WriteLine("\t" + "14-Odd & Even");
                Console.WriteLine("\t" + "15-Sum of numbers");
                Console.WriteLine("\t" + "16-Set characters name");
                Console.WriteLine("\t" + "Enter your choice: ");
                userKey = Console.ReadLine();
                switch (userKey)
                {
                    case "1":
                        helloWorld();
                        break;
                    case "2":
                        userInfo();
                        break;
                    case "3":
                        changeColor();
                        break;
                    case "4":
                        printDate();
                        break;
                    case "5":
                        compareTwo();
                        break;
                    case "6":
                        randomNumber();
                        break;
                    case "7":
                        saveFile();
                        break;
                    case "8":
                        readFile();
                        break;
                    case "9":
                        returnRoot();
                        break;
                    case "10":
                        multiplicationTable();
                        break;
                    case "11":
                        createSortArray();
                        break;
                    case "12":
                        identifyPalindrome();
                        break;
                    case "13":
                        printNumbersInRenge();
                        break;
                    case "14":
                        oddAndEven();
                        break;
                    case "15":
                        sum();
                        break;
                    case "16":
                        startGame();
                        break;

                }
               


            }//While
            // Function 1
            void helloWorld()
            {
                Console.WriteLine("Hello World!");
            }
            // Function 2
            void userInfo()
            {
                String firstName, lastName, age;
                Console.WriteLine("Please enter your first name:");
                firstName = Console.ReadLine();
                Console.WriteLine("Please enter your last name:");
                lastName = Console.ReadLine();
                Console.WriteLine("How old are you?");
                age = Console.ReadLine();
                Console.WriteLine($"First name:{firstName},Last name: {lastName},Age: {age}");
            }
            // Function 3
            void changeColor()
            {
                String color = Console.ForegroundColor.ToString();
                if (color == "Gray")
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
            }
            // Function 4
            void printDate()
            {
                Console.WriteLine(DateTime.Now);
            }
            // Function 5
            void compareTwo()
            {
                Console.WriteLine("Input first number:");
                try
                {
                    int a = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Input second number:");
                    int b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(a > b ? a : b);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
               

            }
            // Function 6
            void randomNumber()
            {
                int counter=0;
                Random random = new Random();
                int number = random.Next(1, 100);
                Console.WriteLine("Enter a number between 1 to 100");
                try
                {
                    int userInput = Convert.ToInt32(Console.ReadLine());
                    while (userInput != number)
                    {
                        counter++;
                        Console.WriteLine(userInput < number ? "Greater" : "Less");
                        userInput = Convert.ToInt32(Console.ReadLine());
                    }

                    Console.WriteLine("Congratulation!! you tried " + counter + " times");

                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                
            }
            // Function 7
            void saveFile()
            {
                string path = @"c:\temp\MyTest.txt";
                Console.WriteLine("Write something to save in a file");
                String userInput = Console.ReadLine();
                try
                {
                    if (!File.Exists(path))
                    {
                        // Create a file to write to.
                        string createText = userInput + Environment.NewLine;
                        File.WriteAllText(path, createText);
                    }

                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                

            
            }
            // Function 8
            void readFile()
            {
                string path = @"c:\temp\MyTest.txt";
                try
                {
                    string readText = File.ReadAllText(path);
                    Console.WriteLine(readText);
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                
            }
            // Function 9
            void returnRoot()
            {
                Console.WriteLine("Enter a number :");
                try
                {
                    Double number = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine(Math.Sqrt(Math.Round(number)));
                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                


            }
            // Function 10
            void multiplicationTable()
            {
                Console.WriteLine("Input a number:");
                try
                {
                    int number = Convert.ToInt32(Console.ReadLine());
                    for (int i = 1; i < 11; i++)
                    {
                        Console.Write(number * i + "\t");
                    }
                    Console.WriteLine();

                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                
            }
            // Function 11
            void createSortArray()
            {
                int Min = 0;
                int Max = 20;
                int temp;
                Boolean sorted = false;
             
                int[] test2 = new int[5];

                Random randNum = new Random();
                for (int i = 0; i < test2.Length; i++)
                {
                    test2[i] = randNum.Next(Min, Max);
                }
                Console.WriteLine("Random array before sorting:");
                Console.WriteLine(string.Join("\t", test2));

                while (!sorted)
                {
                    sorted = true;
                    for (int i = 0; i < test2.Length-1; i++)
                    {
                        if (test2[i] > test2[i + 1])
                        {
                            temp = test2[i];
                            test2[i] = test2[i + 1];
                            test2[i + 1] = temp;
                            sorted = false;
                        }//if
                    }//for

                }//while

                Console.WriteLine("Random array after sorting:");
                Console.WriteLine(string.Join("\t", test2));

            }
            // Function 12
            void identifyPalindrome()
            {
                Boolean isPalindrome=false;
                Console.WriteLine("Input a word:");
                string userInput = Console.ReadLine();
                int len = userInput.Length;
                for(int i = 0; i < len / 2; i++)
                {
                    if(userInput[i] != userInput[len - i - 1])
                    {
                        isPalindrome = false;
                    }
                    else
                    {
                        isPalindrome = true;
                    }
                    
                }
                Console.WriteLine(isPalindrome ? "Your word is Palindrome." : "Your word is not Palindrome!");

            }
            // Function 13
            void printNumbersInRenge()
            {
                int min, max,temp;
                Console.WriteLine("input a number as a minimum");
                try
                {
                    min = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("input a number as a maximum");
                    max = Convert.ToInt32(Console.ReadLine());
                    if (min > max)
                    {
                        temp = min; min = max; max = temp;
                    }
                    for (int i = min + 1; i < max; i++)
                    {
                        Console.Write((i) + "\t");
                    }

                }
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                
            }
            // Function 14
            void oddAndEven()
            {
                List<string> oddList = new List<string>();
                List<string> evenList = new List<string>();
             
                Console.WriteLine("Input your numbers:");
                    string userInput = Console.ReadLine();
                    var tokens = userInput.Split(",");
                    int intToken;
                for (int i = 0; i < tokens.Length; i++)
                {

                    if (int.TryParse(tokens[i], out _))
                    {
                        intToken = Convert.ToInt32(tokens[i]);

                        if (intToken % 2 == 0)
                        {
                            evenList.Add(tokens[i]);
                        }
                        else
                        {
                            oddList.Add(tokens[i]);
                        }
                    }
                }
                
              
                    Console.Write("List of odd numbers :");
                    Console.WriteLine(String.Join(", ", oddList));
                    Console.Write("List of even numbers :");
                    Console.WriteLine(String.Join(", ", evenList));
                

            }
            // Function 15
            void sum()
            {
                var sum = 0;
                Console.WriteLine("Input your numbers:");
                string userInput = Console.ReadLine();
                var tokens = userInput.Split(",");
                int intToken;
                for (int i = 0; i < tokens.Length; i++)
                {

                    if (int.TryParse(tokens[i], out _))
                    {
                        intToken = Convert.ToInt32(tokens[i]);
                        sum = sum + intToken;
                    }
                }

                Console.WriteLine("Sum:" + sum);
            }
            // Function 16
            void startGame()
            {
                Charcter player1 = new Charcter();
                Charcter player2 = new Charcter();
                Console.WriteLine("Player1 name: ");
                player1.setCharacter(Console.ReadLine());
                Console.WriteLine("Player2 name: ");
                player2.setCharacter(Console.ReadLine());
                Console.WriteLine(player1.getCharcter());
                Console.WriteLine(player2.getCharcter());
            }
        }
         
    }
}
