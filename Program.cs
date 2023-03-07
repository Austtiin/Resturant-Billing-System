/*
Austin Stephens
10/27/2022

Write a program to help a local restaurant automate its lunch billing system. The program should do the following:

Show the customer the different lunch items offered by the restaurant.
Allow the customer to select more than one item from the menu.
Calculate and print the bill. Assume that the restaurant offers the following lunch items (the price of each item is shown to the right of the item):

Ham and Cheese Sandwich: $5.00

Tuna Sandwich: $6.00

Soup of the Day: $2.50

Baked Potato: $3.00

Salad: $4.75

Chips: $2.00

French Fries: $1.75

Bowl of Fruit: $2.50

-----------------------------------
Define a struct, menuItemType, with two components: menuItem of type string and menuPrice of type double.

Use an array, menuList, of the struct menuItemType, that you just defined.

Your program must contain at least the following functions:
Function getData: This function loads the data into the array menuList.
Function showMenu: This function shows the different items offered by the restaurant and tells the user how to select the items.
Function printCheck: This function calculates and prints the check. (Note that the billing amount should include a 5% tax.) A sample output is:

*/

using System;

struct menuItemTypes
{
    public string menuItem { get; set; }
    public double menuPrice { get; set; }

    public void menuItemType()
    {
        menuItem = "";
        menuPrice = 0;
    }
}

class workspace
{
    static void Main()
    {
        double TOTAL = 0;
        string[] Selections = new String[500];
        int p = 1;
        string inp = "";
        bool exit = false;

        menuItemTypes[] Item = new menuItemTypes[10];

        string[] names =
        {
            "Ham and Cheese Sandwich", "Tuna Sandwich", "Soup of the Day", "Baked Potato", "Salad", "Chips",
            "French Fries", "Bowl of Fruit"
        };

        double[] prices =
        {
            5.00, 6.00, 2.50, 3.00, 4.75, 2.00, 1.75, 2.50
        };

        //setting the items up
        getData();

            for (int i = 1; i < names.Length; i++)
            {
                Console.WriteLine("Item #: " + i + "\t" + Item[i].menuItem + "\t\t" + Item[i].menuPrice);
            }

            Console.WriteLine( "\n\nChoose Items one at a time to add to recipt, \nPress enter to print recipt");

        while (exit == false)
        {
            inp = Console.ReadLine();
                Selections[p] = inp;
                p++;

                if (inp == "")
                {
                    exit = true;
                    break;
                }
        }

        printCheck();

        void printCheck()
        {
            Console.WriteLine("Welcome To Bobs Resturant: " + " \nINVOICE" + "\n+-------------+");
                for (int i = 1; i < Selections.Length; i++)
                {
                    if (Selections[i] == "")
                    {
                        break;
                    }

                    Console.WriteLine(Item[i].menuItem + "\t" + Item[i].menuPrice);
                    TOTAL = TOTAL + Item[i].menuPrice;
                }

                Console.WriteLine("\n\nTax: " + (TOTAL * 0.05));
                Console.WriteLine("Total: \t" + (TOTAL + TOTAL * 0.05));
            }

        void getData()
        {
            for (int i = 0; i < names.Length; i++)
            {
                Item[i] = new menuItemTypes()
                {
                    menuPrice = prices[i],
                    menuItem = names[i],
                };
            }
        }
    }
}