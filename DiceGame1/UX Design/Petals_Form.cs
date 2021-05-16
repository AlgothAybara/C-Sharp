using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Rose;
using Logic;


/// <summary>
///     Name:   Aaron Young
///     Date:   10/15/2020
///     File:   Petals_Form.cs
///     Purpose:Code manipulating the UX Petals_Form dialog box
/// </summary>
namespace ay0900356_PictureBox_Dice
{

    public partial class Petals_Form : Form
    {
       
        #region Variables
        private Image[] diceArray = new Image[] { Properties.Resources.dice0, Properties.Resources.dice1, Properties.Resources.dice2, Properties.Resources.dice3, Properties.Resources.dice4, Properties.Resources.dice5, Properties.Resources.dice6 };
        private GameLogic logic;
        private string rules_text = "1.) The game is called Petals around the Rose.\n2.) The answer is always even.";
        #endregion 

        #region Constructors
        /// <summary>
        /// Constructor with no properties. Initializes form and instantiates instance of GameLogic class.
        /// </summary>
        public Petals_Form()
        {
            InitializeComponent();
            logic = new GameLogic(diceArray);
        }
        #endregion

        /// <summary>
        /// Runs when form loads
        /// Blanks label, sets enabled status of buttons, Creates images  from list
        /// </summary>
        public void Petals_Form_Load(object sender, EventArgs e)
        {
            //Manipulating form object properties
            feedback_label.Text = "";
            check_buton.Enabled = false;
            guess_updown.Enabled = false;

            //Creates Images with values generated from GameLogic
            foreach (Rose_Die die in logic.Dice)
            {
                Controls.Add(die);
            }
        }

        /// <summary>
        /// Runs when "Roll" button is clicked
        /// Blanks label, sets enabled status of buttons
        /// </summary>
        private void roll_button_Click(object sender, EventArgs e)
        {
            //Calls Method from Logic Project
            //Called method updates images and numerical values
            logic.RollDice();

            //Manipulating form object properties
            check_buton.Enabled = true;
            guess_updown.Enabled = true;
            feedback_label.Text = "";
            guess_updown.Value = 0;
            total_textbox.Text = logic.Total.ToString();            
        }

        /// <summary>
        /// Runs when "Check Answer" button is clicked
        /// Gets user input, Sets UpDown value, sets enable status for buttons
        /// </summary>
        private void check_buton_Click(object sender, EventArgs e)
        {
            //Gets value from NumericUpDown
            decimal input = guess_updown.Value;

            //Manipulating form object properties
            check_buton.Enabled = false;
            guess_updown.Enabled = false;

            //Calls Method from Logic Project
            //Called method checks input vs answer and returns bool
            bool result = logic.CheckAnswer(input);

            //Updates count textboxes and displays "Correct" message if above method returns true
            if (result)
            {
                feedback_label.Text = "Correct!";
                correct_textbox.Text = logic.Correct.ToString();
                run_textbox.Text = logic.Best_run.ToString();
            }
            //Displays incorrect message if above method returns incorrect
            else
            {
                feedback_label.Text = $"Incorrect. \nYour guess: {input} \nCorrect answer: {logic.Answer}";
            }

            streak_textbox.Text = logic.Current_run.ToString();
        }

        /// <summary>
        ///Method runs when Rules button is clicked
        ///Displays mesagebox with rules text
        /// </summary>
        private void Rules_Click(object sender, EventArgs e)
        {
            MessageBox.Show(rules_text);
        }
    }
}
