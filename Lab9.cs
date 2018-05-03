using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList nameList = new ArrayList();
            nameList.Add("George");
            nameList.Add("Kelly");
            nameList.Add("Kam");
            nameList.Add("Viv");
            nameList.Add("Jalen");
            nameList.Add("Sylvia");
            nameList.Add("Todd");
            nameList.Add("Zach");
            nameList.Add("Jacque");
            nameList.Add("Syerra");
            nameList.Add("Synthia");
            nameList.Add("Sharon");
            nameList.Add("Autumn");
            nameList.Add("Stephanie");
            nameList.Add("Joe");
            nameList.Add("Veronica");
            nameList.Add("Janice");
            nameList.Add("Nina");
            nameList.Add("Nita");
            nameList.Add("Mary");

            ArrayList colorList = new ArrayList();
            colorList.Add("green");
            colorList.Add("yellow");
            colorList.Add("blue");
            colorList.Add("purple");
            colorList.Add("white");
            colorList.Add("green");
            colorList.Add("yellow");
            colorList.Add("blue");
            colorList.Add("purple");
            colorList.Add("white");
            colorList.Add("green");
            colorList.Add("yellow");
            colorList.Add("blue");
            colorList.Add("purple");
            colorList.Add("white");
            colorList.Add("green");
            colorList.Add("yellow");
            colorList.Add("blue");
            colorList.Add("purple");
            colorList.Add("white");
                        
            ArrayList foodList = new ArrayList();
            foodList.Add("fries");
            foodList.Add("pizza");
            foodList.Add("hamburger");
            foodList.Add("grilled cheese");
            foodList.Add("pasta");
            foodList.Add("fries");
            foodList.Add("pizza");
            foodList.Add("hamburger");
            foodList.Add("grilled cheese");
            foodList.Add("pasta");
            foodList.Add("fries");
            foodList.Add("pizza");
            foodList.Add("hamburger");
            foodList.Add("grilled cheese");
            foodList.Add("pasta");
            foodList.Add("fries");
            foodList.Add("pizza");
            foodList.Add("hamburger");
            foodList.Add("grilled cheese");
            foodList.Add("pasta");

            ArrayList homeList = new ArrayList();
            homeList.Add("Detroit");
            homeList.Add("Topeka");
            homeList.Add("Little Rock");
            homeList.Add("Knoxville");
            homeList.Add("Houston");
            homeList.Add("Detroit");
            homeList.Add("Topeka");
            homeList.Add("Little Rock");
            homeList.Add("Knoxville");
            homeList.Add("Houston");
            homeList.Add("Detroit");
            homeList.Add("Topeka");
            homeList.Add("Little Rock");
            homeList.Add("Knoxville");
            homeList.Add("Houston");
            homeList.Add("Detroit");
            homeList.Add("Topeka");
            homeList.Add("Little Rock");
            homeList.Add("Knoxville");
            homeList.Add("Houston");

            //declare variables
            string cont = "y";
            string input;
            int num;

            while (cont == "y")// while loop so user can choose to continue or exit at the end
            {
                Welcome();
                input = Console.ReadLine();
                bool isNum = int.TryParse(input, out num); //bool to try parse input to an int
                while (!isNum || num > nameList.Count || num < 0)//while loop to prevent entries that are not numbers or out of range
                {
                    Console.WriteLine($"Error: {input} does not exist. Please try again.");
                    input = Console.ReadLine();
                    isNum = int.TryParse(input, out num);
                }
                for (int i = 0; i < nameList.Count; i++)
                {
                    if (num == i + 1) //so that user selection and index line up correctly
                    {
                        Console.WriteLine($"Student {num} is {nameList[i]}");
                        Console.Write($"What would you like to know about {nameList[i]}? (Enter 'hometown', 'favorite color' or 'favorite food'): ");
                        string wantToKnow = Console.ReadLine().ToLower();
                        while (wantToKnow != "hometown" && wantToKnow != "favorite food" && wantToKnow != "favorite color")
                        {
                            Console.WriteLine("That data does not exist. Please try again (Enter 'hometown', 'favorite color' or 'favorite food'): ");
                            wantToKnow = Console.ReadLine().ToLower();
                        }
                        switch (wantToKnow) //switch statement to decide what to do for each option
                        {
                            case "hometown":
                                Console.WriteLine($"{nameList[i]}'s hometown is: {homeList[i]}");
                                break;
                            case "favorite food":
                                Console.WriteLine($"{nameList[i]}'s favorite food is: { foodList[i]}");
                                break;
                            case "favorite color":
                                Console.WriteLine($"{nameList[i]}'s favorite color is: { colorList[i]}");
                                break;
                            default:
                                Console.WriteLine("That data does not exist. Please try again. (Enter 'hometown' or 'favorite food'): ");

                                break;
                        }

                    }
                    

                }
                               
                Console.WriteLine("Would you like to continue?");
                cont = Console.ReadLine().ToLower();
            }
            Console.WriteLine("\nThanks! Press any key to exit!");
            Console.ReadKey();

        }

        static void Welcome()
        {
            Console.Write("Welcome to our C# class. Which student would you like to learn more about? (enter a number 1-20): ");
        }

    }
}

/*
 * Dictionary <object, object>
 * i.e Dictionary <string, student>
  */