using System;
using System.Collections.Generic;

namespace UserInterface
{
    /// <summary>
    ///     Name:       Aaron Young
    ///     Date:       03/25/2021
    ///     Project:    Grade Calculator
    /// </summary>
    class Program
    {
        /// <summary>
        /// Defines the gloabl variables used in this program
        /// </summary>
        #region Variables
        static string student_Name, student_Class;
        static List<float> student_Scores = new List<float>();
        static int student_high = -1, student_low = -1;
        static char student_Letter;
        static float student_Avg;
        static int count = 0;
        static bool cont_bool;
        #endregion

        #region Main
        /// <summary>
        /// Main method in program, calls other methods
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            EnterStudent();
            EnterScores();
            CalcScores();
            OutputGrade();
        }
        #endregion

        #region Methods
        /// <summary>
        /// method prompts user for student name and class
        /// </summary>
        static void EnterStudent()
        {
            Console.WriteLine("Please enter the student's name:");
            student_Name = Console.ReadLine();
            Console.WriteLine("Please enter the student's class:");
            student_Class = Console.ReadLine();
            Console.Clear();
        }

        /// <summary>
        /// Program prompts for input, validates data, and stores it in corresponding variables
        /// </summary>
        static void EnterScores()
        {
            //Loops until user breaks out via prompt
            do
            {
                string cont;
                //loops until proper data type is inputed and parsed as float
                do
                {
                    string input;
                    input = TestPrompt();
                    //validates inputted data and assigns high/low indexes
                    try
                    {
                        float temp = (float)Int32.Parse(input);
                        //Prevents invalid scores
                        if (temp < 125 && temp > 0 && input != "")
                        {
                            student_Scores.Add(temp);
                            if (student_high == -1 && student_low == -1)
                            {
                                student_high = 0;
                                student_low = 0;
                            }
                            else if (temp > student_Scores[student_high])
                            {
                                student_high = count;
                            }
                            else if (temp < student_Scores[student_low])
                            {
                                student_low = count;
                            }
                            count++;
                            break;
                            //cont_bool = true;
                        }
                        else
                        {
                            Console.WriteLine("Inputted score invalid. Check inputted value.");
                            OutputError();
                            //cont_bool = false;
                        }

                    }
                    catch
                    {
                        OutputError();
                    }

                } while (true);

                //loops until valid input is received, controls looping of parent loop
                while (true)
                {
                    OutputStudent();
                    Console.WriteLine("Would you like to enter another score? (Y/N) ");
                    cont = Console.ReadLine();
                    Console.Clear();
                    if (cont.ToUpper() == "Y")
                    {
                        cont_bool = true;                       
                        break;
                    }
                    else if (cont.ToUpper() == "N")
                    {
                        cont_bool = false;
                        break;
                    }
                    else
                    {
                        OutputError();
                    }
                }
            } while (cont_bool);
        }

        /// <summary>
        /// Prompts user for score of test
        /// </summary>
        /// <returns></returns>
        static string TestPrompt()
        {
            string temp;

            OutputStudent();

            Console.WriteLine($"Test {count + 1}: ");
            temp = Console.ReadLine();
            Console.Clear();
            return temp;
        }

        /// <summary>
        /// Outputs generic error and waits for user input before continueing
        /// </summary>
        static void OutputError()
        {
            Console.WriteLine("Invalid input. Press a key to continue.");
            Console.ReadKey();
            Console.Clear();
        }

        /// <summary>
        /// Outputs student name when called
        /// </summary>
        static void OutputStudent()
        {
            Console.WriteLine($"Student:\t{student_Name}");
            Console.WriteLine($"Class:  \t{student_Class}\n");
        }

        /// <summary>
        /// outputs average grade, letter grade, highest score, and lowest score
        /// </summary>
        static void OutputGrade()
        {
            Console.Clear();
            Console.WriteLine($"Average Grade:\t{Math.Round(student_Avg)}");
            Console.WriteLine($"Letter Grade :\t{student_Letter}\n");

            Console.WriteLine("Highest Score:");
            Console.WriteLine($"\tTest:  {student_high}");
            Console.WriteLine($"\tScore: {student_Scores[student_high]}");

            Console.WriteLine("Lowest Score:");
            Console.WriteLine($"\tTest:  {student_low}");
            Console.WriteLine($"\tScore: {student_Scores[student_low]}");
        }

        /// <summary>
        /// Loops thorugh scores, finds average, and assigns letter grade
        /// </summary>
        static void CalcScores()
        {
            //calculates average grade
            float total = 0;

            foreach (float score in student_Scores)
            {
                total += score;
            }

            student_Avg = total / count;

            //Assigns letter grade based off of score
            if (student_Avg >= 90)
            {
                student_Letter = 'A';
            } else if (student_Avg >= 80)
            {
                student_Letter = 'B';
            }
            else if (student_Avg >= 70)
            {
                student_Letter = 'C';
            }
            else  if (student_Avg >= 60)
            {
                student_Letter = 'D';
            }
            else if (student_Avg < 60) 
            {
                student_Letter = 'F';
            }
        }
        #endregion
    }
}
