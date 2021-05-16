using System;
using System.Collections.Generic;
using System.Drawing;
using Rose;

/// <summary>
///     Name:   Aaron Young
///     Date:   10/15/2020
///     File:   GameLogic.cs
///     Purpose:CameLogic class calculates numerical values and manipulates images.
/// </summary>
namespace Logic
{
    public class GameLogic
    {
        #region Variables
        private Image[] diceArray;
        private List<Rose_Die> dice;
        private int answer, correct, current_run, best_run, total;
        private Rose_Die rose_pictureBox;
        #endregion

        #region Getters/Setters
        public int Answer { get => answer; set => answer = value; }
        public int Correct { get => correct; set => correct = value; }
        public int Current_run { get => current_run; set => current_run = value; }
        public int Best_run { get => best_run; set => best_run = value; }
        public int Total { get => total; set => total = value; }
        public List<Rose_Die> Dice { get => dice; set => dice = value; }


        #endregion

        #region Constructors
        /// <summary>
        /// Constructor with 0 properties;
        /// </summary>
        public GameLogic() { }

        /// <summary>
        /// Constructor with 1 property
        /// </summary>
        /// <param name="array"></param>
        public GameLogic(Image[] array)
        {
            dice = new List<Rose_Die>();
            diceArray = array;
            correct = 0;
            current_run = 0;
            best_run = 0;
            total = 0;

            GenerateDice(0);
    }
        #endregion

        #region Methods
        /// <summary>
        /// Method obtains dice values and calculates answer to current roll
        /// </summary>
        public void RollDice()
        {
            //Manipulate gloabl variable
            total += 1;

            //Set Local Variables
            int sum = 0;
            int counter = 0;

            //Loops through Dice array
            for (int i = 0; i < dice.Count; i++)
            {
                //Obtains dice value and updates image
                int num = dice[i].Roll();
                dice[i].Image = diceArray[num];

                //Adds up all odd dice and counts qty
                if (num % 2 == 1)
                {
                    sum += num;
                    counter += 1;
                }
            }

            //Calculates answer
            answer = sum - counter;
        }

        /// <summary>
        /// Creates 6 dice objects and adds them to a list
        /// </summary>
        /// <param name="value">Index of image to be used with generated dice</param>
        public void GenerateDice(int value)
        {
            //Loops through qty of dice rolled
            for (int i = 1; i < 6; i++)
            {
                //Instantiates die
                rose_pictureBox = new Rose_Die();

                //Sets multiple properties of die
                int xLoc = 30 + ((i - 1) * 185);
                rose_pictureBox.Image = diceArray[value];
                rose_pictureBox.Location = new System.Drawing.Point(xLoc, 125);
                rose_pictureBox.Margin = new System.Windows.Forms.Padding(7);
                rose_pictureBox.Name = $"pictureBox{i}";
                rose_pictureBox.Size = new System.Drawing.Size(159, 160);
                rose_pictureBox.TabIndex = 0;
                rose_pictureBox.TabStop = false;
                rose_pictureBox.FaceValue = rose_pictureBox.Roll();

                //Adds die to list
                dice.Add(rose_pictureBox);
            }
        }

        /// <summary>
        /// Obtains user input, checks against answer, and updates game mechanic values
        /// </summary>
        /// <param name="input">Input from user checked against answer</param>
        /// <returns>boolean coreltating with either a correct or incorrect input</returns>
        public bool CheckAnswer(decimal input)
        {
            //Returns true if input correct
            if (answer == input)
            {
                //Updates total correct and current streak
                correct += 1;
                current_run += 1;

                //Updates best value
                if (current_run > best_run)
                {
                    best_run = current_run;
                }

                //returns true to calling method
                return true;
            }
            //Returns false if input incorrect
            else
            {
                //resets correct streak
                current_run = 0;
                //Returns false to calling mehtod
                return false;
            }
        }
        #endregion
    }
}
