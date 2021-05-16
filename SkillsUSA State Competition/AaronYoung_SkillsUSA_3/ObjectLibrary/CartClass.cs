using System;
using System.Collections.Generic;

namespace ObjectLibrary
{
    /// <summary>
    ///     Name:       Aaron Young
    ///     Date:       03/25/2021
    ///     Project:    Concessions POS
    /// </summary>
    public class Cart
    {
        #region Variables
        private List<Item> items;
        private float total;


        #endregion

        #region Getters/Setters
        public float Total { get => total; set => total = value; }
        public List<Item> Items { get => items; set => items = value; }
        #endregion

        #region Constructors
        public Cart() { }

        public Cart(List<Item> i)
        {
            items = i;
        }
        #endregion

        #region Methods
        public float CalcTotal()
        {
            float temp = 0;
            foreach (Item item in items)
            {
                temp += item.Subtotal;
            }
            total = temp;
            return total;
        }
        #endregion
    }
}
