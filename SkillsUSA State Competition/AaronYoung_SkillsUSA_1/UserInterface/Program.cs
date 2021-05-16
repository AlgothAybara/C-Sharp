using System;
using System.Collections.Generic;

namespace UserInterface
{
    /// <summary>
    ///     Name:       Aaron Young
    ///     Date:       03/25/2021
    ///     Project:    Calorie Counter
    /// </summary>
    class Program
    {
        /// <summary>
        /// Defines the gloabl variables used in this program
        /// </summary>
        #region Variables

        static string[] food_Name = 
        {
            "Big Mac",
            "Medium Fries",
            "Small Shake"
        };

        static float[] food_Cal = 
        {
            563,
            378,
            530
        };

        static float[] food_Count = 
        {
            0,
            0,
            0
        };

        static float[] food_Sub = new float[3];

        static float time_Run, time_Jog;

        static float food_Total = 0;

        #region Constants
        static float JOG = 398;
        static float RUN = 557;
        #endregion

        #endregion

        #region Main
        /// <summary>
        /// Method defines the flow of the program, calls functions
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            GetInput();
            WriteOutput();
        }
        #endregion

        #region Methods
        /// <summary>
        /// Method optains user inputs, validates datatype
        /// </summary>
        static void GetInput()
        {
            string temp;

            //Gets user input
            for (int i = 0; i < 3; i++)
            {
                while (true)
                {
                    Console.Clear();
                    temp = InputPrompt(i);
                    try
                    {
                        food_Count[i] = (float)Int32.Parse(temp);
                        break;
                    }
                    catch
                    {
                        Console.WriteLine("Invalid input. Press a key to continue.");
                        Console.ReadKey();
                        Console.Clear();
                    }
                }
            }
        }



        /// <summary>
        /// Method writes calculated output to the console
        /// </summary>
        static void WriteOutput()
        {
            //Clear Console
            Calc();
            Console.Clear();

            //Builds Table to display food items
            Console.WriteLine("Food Item      \tQty\tCalories");
            for (int i = 0; i < food_Name.Length; i++)
            {
                Console.WriteLine($"{food_Name[i].PadRight(15, ' ')}:\t{food_Count[i]}\t{food_Sub[i]}");
            }

            //Displays various values calculated
            Console.WriteLine($"\nTotal Calories:\t{food_Total}\n");
            Console.WriteLine("Hours to burn off calories by:");
            Console.WriteLine($"Jogging:\t{time_Jog:N2}");
            Console.WriteLine($"Running:\t{time_Run:N2}");

        }

        /// <summary>
        /// Prompts user for specific input
        /// </summary>
        /// <param name="i">float index variable of array</param>
        /// <returns>string of user input</returns>
        static string InputPrompt(int i)
        {
            //Writes Line, reads line, returns value
            Console.WriteLine($"How many {food_Name[i]} did you eat?");
            string temp = Console.ReadLine();
            return temp;
        }

        /// <summary>
        /// Method calculates inputted values
        /// </summary>
        static void Calc()
        {
            float subtotal;

            //Loops through values in arrays, multiplies them, adds them to another array
            for (int i = 0; i < food_Name.Length; i++)
            {
                subtotal = food_Count[i] * food_Cal[i];
                food_Sub[i] = subtotal;
                food_Total += subtotal;
            }

            //Calculates run and jog times
            time_Jog = food_Total / JOG;
            time_Run = food_Total / RUN;
        }
        #endregion
    }
}
