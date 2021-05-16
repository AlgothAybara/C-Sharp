using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ay0900356_PictureBox_Dice
{


    public partial class Form1 : Form
    {
        public static Image[] diceArray = new Image[] { Properties.Resources.dice0, Properties.Resources.dice1, Properties.Resources.dice2, Properties.Resources.dice3, Properties.Resources.dice4, Properties.Resources.dice5, Properties.Resources.dice6 };
        public static List<Rose_Die> dice = new List<Rose_Die>();
        private Rose_Die pictureBox1;
        public static int answer;
        public int current_run = 0;
        public int best_run = 0;
        public int correct = 0;
        public int total = 0;
        public string rules_text = "1.) The game is called Petals around the Rose.\n2.) The answer is always even.";

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Loads picture boxes with generic images, disables input fields, and clears some labels on load
        /// </summary>
        public void Form1_Load(object sender, EventArgs e)
        {
            feedback_label.Text = "";
            check_buton.Enabled = false;
            guess_updown.Enabled = false;

            for (int i = 1; i < 6; i++)
            {
                Rose_Die die = GenerateDice(i, 0);
                dice.Add(die);
            }
        }

        /// <summary>
        /// Builds each picture box and instantiates the Rose_Die objects
        /// </summary>
        /// <returns>Rose_Die object</returns>
        public Rose_Die GenerateDice(int counter, int value)
        {
            this.pictureBox1 = new Rose_Die();

            int xLoc = (counter * 185);
            this.pictureBox1.Image = diceArray[value];
            this.pictureBox1.Location = new System.Drawing.Point(xLoc, 125);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(7);
            this.pictureBox1.Name = $"pictureBox{counter}";
            this.pictureBox1.Size = new System.Drawing.Size(159, 160);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.FaceValue = pictureBox1.Roll();

            this.Controls.Add(this.pictureBox1);
            return pictureBox1;
        }

        /// <summary>
        /// Enables input values, clears feedback label, calls the RollDice function.
        /// </summary>
        private void roll_button_Click(object sender, EventArgs e)
        {
            check_buton.Enabled = true;
            guess_updown.Enabled = true;
            feedback_label.Text = "";
            total += 1;

            Rose_Die.RollDice();
            total_textbox.Text = total.ToString();
        }

        /// <summary>
        /// disables check button and the guess input field. Also compares input to correct answer and provides feedback.
        /// </summary>
        private void check_buton_Click(object sender, EventArgs e)
        {
            check_buton.Enabled = false;
            guess_updown.Enabled = false;

            decimal num = guess_updown.Value;
            guess_updown.Value = 0;

            if (answer == num)
            {
                feedback_label.Text = "Correct!";
                correct += 1;
                correct_textbox.Text = correct.ToString();
                current_run += 1;

                if (current_run > best_run)
                {
                    best_run = current_run;
                    run_textbox.Text = best_run.ToString();
                }
            } else
            {
                feedback_label.Text = $"Incorrect. \nYour guess: {num} \nCorrect answer: {answer}";
                current_run = 0;
            }
        }

        /// <summary>
        /// Opens message box when clicked providing rules for the game.
        /// </summary>
        private void Rules_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rules_text);
        }
    }
}