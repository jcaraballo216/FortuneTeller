﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FortuneTeller
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fortune Teller

            //Ask the user for the user’s first name
            //Ask the user for the user’s last name
            //Ask the user for the user’s age
            //Ask the user for the user’s birth month(as an 'int')
            //Ask the user for the user’s favorite ROYGBIV color
            //If the user does not know what ROYGBIV is, ask them to enter “Help” to get a list of the ROYGBIV colors
            //Ask the user for the number of siblings they have

            //Asking user for information and calculating output.

            Console.WriteLine("Welcome to Fortune Teller!");
            Console.WriteLine("You will be asked a series of questions to determine your future.");
            Console.WriteLine("LETS GET STARTED!");
            Console.WriteLine("Please enter your first name.");
            string firstName = Console.ReadLine();
            Console.WriteLine("Please enter your last name.");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter your age.");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Please enter your birth month as a two digit month.");
            int birthMonth = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your favorite ROYGBIV. Type \"Help\" if you do not know ROYGBIV.");
            //Help content output
            string roygbiv = Console.ReadLine();
            string lowerRoygbiv = roygbiv.ToLower();
            if (lowerRoygbiv == "help")
            {
                Console.WriteLine("ROYGBIV means Red,Orange,Yellow,Green,Blue,Indigo,Violet");
                roygbiv = Console.ReadLine();
            }
            lowerRoygbiv = roygbiv.ToLower();
            Console.WriteLine("How many siblings do you have?");
            int siblings = int.Parse(Console.ReadLine());
            //calculations for prt 3 output
            //age
            int ageEven = age % 2;
            int retirementAge;
            if (ageEven == 0)
            {
                retirementAge = 30;
            }
            else
            {
                retirementAge = 15;
            }
            string placeToLive;
            //siblings and places to live
            if (siblings == 0)
            {
                placeToLive = "Puerto Rico";
            }
            else if (siblings == 1)
            {
                placeToLive = "San Diego";
            }
            else if (siblings == 2)
            {
                placeToLive = "Texas";
            }
            else if (siblings == 3)
            {
                placeToLive = "Florida";
            }
            else if (siblings > 3)
            {
                placeToLive = "Detroit";
            }
            else
            {
                placeToLive = "Cardboard box in Save-A-Lot";
            }
            //cars for colors
            string sweetCars
            switch (lowerRoygbiv)
            {
                case "red":
                    sweetCars = "Lambo";
                    break;


                case "orange":
                    sweetCars = "Hummer";
                    break;
                case "yellow":
                    sweetCars = "Porche";
                    break;
                case "green":
                    sweetCars = "BMW";
                    break;
                case "blue":
                    sweetCars = "Prius";
                    break;
                case "indigo":
                    sweetCars = "Motorcycle";
                    break;
                case "violet":
                    sweetCars = "Limo";
                    break;
                    // determining money for birthmonth
                    string dollars;
                    if (birthMonth >= 1 && birthMonth <= 4)
                    {
                        dollars = "$100,000";
                
                    }
                    else if (birthMonth == 5 && birthMonth <=8)
                    {
                        dollars = "$300,000";
                    }
                    else if (birthMonth == 9 && birthMonth <= 12
                        {
                        dollars = "$500,000";
                    }
                    else
                    {
                        dollars = "$0.00";
                    }
                    Console.WriteLine("Thank you for your info!");
                    Console.WriteLine("Here is your Future!");
                    Console.WriteLine(firstName " " + lastName)
                       

                 

            
                


            
                
            
            


            
              
            
            
            

            } 



                
        }
    }

