using System;
using ObjectLibrary;
using System.Collections.Generic;

namespace UserInterface
{
    /// <summary>
    ///     Name:       Aaron Young
    ///     Date:       03/25/2021
    ///     Project:    Concessions POS
    /// </summary>
    class Program
    {
        /// <summary>
        /// Defines the gloabl variables used in this program
        /// </summary>
        #region Variables
        static string PSSWRD = "7777";

        static List<Item> items = new List<Item>()
        {
            new Item("Small Popcorn", 3, 0),
            new Item("Medium Popcorn", 4, 0),
            new Item("Large Popcorn", 5, 0),
            new Item("Soda", 2, 0),
            new Item("Candy", 1.5f, 0)
        };

        static Cart cart = new Cart(items);
        static Cart sales = new Cart(new List<Item>()
        {
            new Item("Small Popcorn", 3, 0),
            new Item("Medium Popcorn", 4, 0),
            new Item("Large Popcorn", 5, 0),
            new Item("Soda", 2, 0),
            new Item("Candy", 1.5f, 0)
        });
        #endregion

        /// <summary>
        /// Main method calls menu
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Menu();
        }

        /// <summary>
        /// Provides user interface
        /// </summary>
        static void Menu()
        {
            Console.Clear();
            //loops to display menu
            while (true)
            {
                //displays menu
                Console.WriteLine("\t\tMain Menu\t\t");
                Console.WriteLine("1. Concessions");
                Console.WriteLine("2. Checkout");
                Console.WriteLine("3. Manager Console");
                Console.WriteLine("4. Exit");
                Console.WriteLine("Please select an option.");
                string input = Console.ReadLine();

                //parses input, calls associated method
                try
                {
                    float temp = (float)Int32.Parse(input);
                    //Prevents invalid scores
                    if (temp <= 4 && temp > 0 && input != "")
                    {
                        switch (temp)
                        {
                            case 1:
                                Concessions();
                                break;
                            case 2:
                                Checkout();
                                break;
                            case 3:
                                Manager();
                                break;
                            case 4:
                                return;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Inputted item invalid. Check inputted value.");
                        OutputError();
                    }

                }
                catch
                {
                    OutputError();
                }
            }

        }

        /// <summary>
        /// Concesssions menu, shows items for sale
        /// </summary>
        static void Concessions()
        {
            Console.Clear();
            //Loops to display menu
            while (true)
            {
                Console.WriteLine("\t\tConcessions\t\t");
                for (int i = 0; i < items.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {items[i].Name.PadRight(20, ' ')}\t{items[i].Cost:c}");
                }
                Console.WriteLine($"{items.Count + 1}. Main Menu");
                Console.WriteLine("Please select an option.");


                string input = Console.ReadLine();
                //Parses input
                try
                {
                    int temp = Int32.Parse(input);
                    //Prevents invalid scores, calls certain methods
                    if (temp <= items.Count && temp > 0 && input != "")
                    {
                        AddQty(temp);
                    }
                    else if (temp == items.Count + 1)
                    {
                        Menu();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Inputted item invalid. Check inputted value.");
                        OutputError();
                    }

                }
                catch
                {
                    OutputError();
                }
            }
        }

        /// <summary>
        /// Displays checkout method, calls associated methods
        /// </summary>
        static void Checkout()
        {
            Console.Clear();
            while (true)
            {
                //builds display menu
                Console.WriteLine("\t\tCheckout\t\t");
                for (int i = 0; i < cart.Items.Count; i++)
                {
                    Console.WriteLine($"{cart.Items[i].Name.PadRight(20, ' ')}\t{cart.Items[i].Qty}\t{cart.Items[i].CalcSubtotal():c}");
                }
                Console.WriteLine($"Total:\t{cart.CalcTotal():c}\n");
                Console.WriteLine($"1. Checkout");
                Console.WriteLine($"2. Clear Cart");
                Console.WriteLine($"3. Main Menu");
                Console.WriteLine("Please select an option.");


                string input = Console.ReadLine();
                //Parses input
                try
                {
                    int temp = Int32.Parse(input);
                    //Prevents invalid scores, selects associated methods
                    if (temp == 1 && cart.CalcTotal() > 0)
                    {
                        Pay();
                        break;

                    }
                    else if (temp == 2)
                    {
                        ClearCart();
                        Console.Clear();
                        break;

                    }
                    else if (temp == 3)
                    {
                        Menu();
                        break;

                    }
                    else
                    {
                        Console.WriteLine("Inputted item invalid. Check inputted value.");
                        OutputError();
                    }

                }
                catch
                {
                    OutputError();
                }
                Menu();
            }
        }

        /// <summary>
        /// Displays manager auth menu
        /// </summary>
        static void Manager() 
        {
            Console.Clear();

            while (true)
            {
                Console.WriteLine("Enter admin password:");
                string input = Console.ReadLine();

                //Opens manager console if correct
                if (input == PSSWRD)
                {
                    ManagerConsole();
                    break;
                }        
               //Retiurns to main menu
                else 
                {
                    Console.WriteLine("Incorrect Password. Press a key to continue.");
                    Console.ReadKey();
                    Menu();
                    break;
                }       
            }
        }

        /// <summary>
        /// updates manager console
        /// </summary>
        static void AdjustSales()
        {
            for(int i = 0; i < cart.Items.Count; i++)
            {
                sales.Items[i].Qty += cart.Items[i].Qty;
            }

            sales.CalcTotal();
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
        /// Adds selected item to cart qty
        /// </summary>
        /// <param name="index">index of item added to cart</param>
        static void AddQty(int index)
        {
            //Asks for qty
            while (true)
            {
                Console.WriteLine($"Quantity:");
                string input = Console.ReadLine();
                //Parses input
                try
                {
                    int temp = Int32.Parse(input);
                    //Prevents invalid scores, updates qty
                    if (temp > 0 && input != "")
                    {
                        cart.Items[index - 1].Qty += temp;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Inputted item invalid. Check inputted value.");
                        OutputError();
                    }

                }
                catch
                {
                    OutputError();
                }
            }
            Console.WriteLine("Item Added to cart. Press a key to continue");
            Console.ReadKey();
            Console.Clear();
        }

        /// <summary>
        /// Displays manager console
        /// </summary>
        static void ManagerConsole()
        {
            Console.Clear();
            //Displays total sales menu
            while (true)
            {
                Console.WriteLine("\t\tSales\t\t");
                for (int i = 0; i < sales.Items.Count; i++)
                {
                    Console.WriteLine($"{sales.Items[i].Name.PadRight(20, ' ')}\t{sales.Items[i].CalcSubtotal():c}");
                }
                Console.WriteLine($"Total Sales:\t{sales.CalcTotal():c}\n");
                Console.WriteLine($"1. Main Menu");

                string input = Console.ReadLine();

                //Parses input, opens main menu
                try
                {
                    int temp = Int32.Parse(input);
                    //Prevents invalid scores
                    if (temp == 1)
                    {
                        break;
                    }                    
                    else
                    {
                        Console.WriteLine("Inputted item invalid. Check inputted value.");
                        OutputError();
                    }

                }
                catch
                {
                    OutputError();
                }
            }
        }

        /// <summary>
        /// Clears cart with default values
        /// </summary>
        static void ClearCart()
        {
            cart = new Cart(new List<Item>()
            {
                new Item("Small Popcorn", 3, 0),
                new Item("Medium Popcorn", 4, 0),
                new Item("Large Popcorn", 5, 0),
                new Item("Soda", 2, 0),
                new Item("Candy", 1.5f, 0)
            });
        }

        /// <summary>
        /// Executes paid status methods, clear cart, etc.
        /// </summary>
        static void Paid()
        {
            Console.WriteLine("Thank you for your purchase. Have a nice day!");
            Console.ReadKey();
            AdjustSales();
            ClearCart();
            foreach (Item item in cart.Items)
            {
                item.Qty = 0;
            }
            Console.Clear();
        }

        /// <summary>
        /// Prompts user for payment
        /// </summary>
        static void Pay()
        {
            while (true)
            {
                Console.WriteLine("How much would you like to pay with?");
                string input = Console.ReadLine();
                //Parses user input
                try
                {
                    int temp = Int32.Parse(input);
                    //Prevents invalid scores, calcs change
                    if (temp > cart.CalcTotal())
                    {
                        float change = cart.Total - temp;
                        Console.WriteLine($"Your change is: {change:c}");
                        Paid();
                        break;
                    }
                    else if (temp == cart.Total)
                    {
                        Paid();
                        break;
                    }
                    else if (temp < cart.Total)
                    {
                        Console.WriteLine("Insufficient funds. Please adjust your payment amount. Press a key to continue.");
                        Console.ReadKey();
                        Checkout();
                    }

                }
                catch
                {
                    OutputError();
                }
            }
            
        }
    }
}
