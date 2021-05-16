using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
///     Name:   Aaron Young
///     Date:   10/15/2020
///     File:   Rose_Die.cs
///     Purpose:Class inheriting properties from Picture Box.
/// </summary>
namespace Rose
{
    public class Rose_Die : PictureBox
    {
        //Instantiates instance of System Class
        static Random rand = new Random();

        #region Variables
        //private data elements
        private int faceValue;
        #endregion

        #region Getter/Setter
        //public data element
        public int FaceValue
        {
            get { return faceValue; }
            set { faceValue = value; }
        }
        #endregion

        #region Methods
        /// <summary>
        /// Method returns randomly selected value from 1-6. 
        /// Emulates roll of dice.
        /// </summary>
        /// <returns>Random int value</returns>
        public int Roll()
        {
            return rand.Next(1, 7);
        }
        #endregion
    }
}
