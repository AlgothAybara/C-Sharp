using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ay0900356_PictureBox_Dice
{
    public class Rose_Die : PictureBox
    {

        static Random rand = new Random();

        //private data elements
        private int faceValue;
        //public data element
        public int FaceValue { 
            get { return faceValue; }
            set { faceValue = value; }
        }

        /// <summary>
        /// Generates random number from 1-6
        /// </summary>
        /// <returns>Returns the random number</returns>
        public int Roll()
        {
            return rand.Next(1, 7);
        }

        /// <summary>
        /// Loops through the dice list and changes their images. This also sets the public variable with the answer.
        /// </summary>
        public static void RollDice()
        {

            int sum = 0;
            int counter = 0;
            for (int i = 0; i < Form1.dice.Count; i++)
            {
                int num = Form1.dice[i].Roll();
                Form1.dice[i].Image = Form1.diceArray[num];

                if (num % 2 == 1)
                {
                    sum += num;
                    counter += 1;
                }
            }

            Form1.answer = sum - counter;
        }
    }
}
