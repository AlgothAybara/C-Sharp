using System;
using System.Collections.Generic;
using System.Text;

namespace ObjectLibrary
{
    /// <summary>
    ///     Name:       Aaron Young
    ///     Date:       03/25/2021
    ///     Project:    Concessions POS
    /// </summary>
    public class Item
    {
        #region Variables
        private string name;
        private float cost, qty, subtotal;
        #endregion

        #region Getters/Setters
        public string Name { get => name; }
        public float Cost { get => cost; }
        public float Qty { get => qty; set => qty = value; }
        public float Subtotal { get => subtotal; }
        #endregion

        #region Constructors
        public Item() { }

        public Item (string n, float c, float q)
        {
            name = n;
            cost = c;
            qty = q;
        }
        #endregion

        #region Methods
        public float CalcSubtotal()
        {
            subtotal = qty * cost;
            return subtotal;
        }
        #endregion
    }

}
