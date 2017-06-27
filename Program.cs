using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingInventory
{
    class Program
    {
        static void Main(string[] args)
        {
            int answer;
            int answer2;
            bool state = true;

            while (state == true)
            {
                Console.WriteLine("\n1. Check Inventory"
                    + "\n2. Insert item to inventory"
                    + "\n3. Delete from inventory"
                    + "\n4. Update inventory"
                    + "\n5. Exit"
                    + " ");
                Console.Write("\nPlease select a number of the options option: ");
                answer = int.Parse(Console.ReadLine());

                if (answer == 1)
                {

                    Select selectall = new Select();
                    selectall.SelectAll();

                    Console.Write("\nWould you like to make any other changes? Please select a number. "
                        + "\n1. Yes "
                        + "\n2. No "
                        + "\n");
                    answer2 = int.Parse(Console.ReadLine());

                    if (answer2 == 2)
                    {
                        state = false;
                    }
                }

                else if (answer == 2)
                {
                    Insert insertToTable = new Insert();
                    insertToTable.SelectItemTable();
                    Console.Write("\nPlease select an item ID from the items above: ");
                    int itemID = int.Parse(Console.ReadLine());

                    Console.Write("\nPlease insert the price of the item: ");
                    decimal price = decimal.Parse(Console.ReadLine());

                    insertToTable.SelectColorTable();
                    Console.Write("\nPlease select a color ID from the colors above: ");
                    int colorID = int.Parse(Console.ReadLine());

                    insertToTable.InsertItem(itemID, colorID, price);
                    insertToTable.SelectAll();

                    Console.Write("\nWould you like to make any other changes? Please select a number. "
                       + "\n1. Yes "
                       + "\n2. No "
                       + "\n");
                    answer2 = int.Parse(Console.ReadLine());

                    if (answer2 == 2)
                    {
                        state = false;
                    }
                }

                else if (answer == 3)
                {
                    Delete deleteItem = new Delete();
                    deleteItem.ShowItems();
                    Console.Write("\nPlease select the ID of the item to delete: ");
                    int id = int.Parse(Console.ReadLine());

                    deleteItem.DeleteItem(id);
                    deleteItem.SelectAll();

                    Console.Write("\nWould you like to make any other changes? Please select a number. "
                       + "\n1. Yes "
                       + "\n2. No "
                       + "\n");
                    answer2 = int.Parse(Console.ReadLine());

                    if (answer2 == 2)
                    {
                        state = false;
                    }
                }

                else if (answer == 4)
                {
                    Update updateItem = new Update();
                    updateItem.ShowItems();

                    Console.Write("Please select insert the ID of item to change: ");
                    int id = int.Parse(Console.ReadLine());

                    updateItem.SelectItemTable();
                    Console.Write("Insert the ID of the item: ");
                    int itemId = int.Parse(Console.ReadLine());

                    Console.Write("Insert the price of the item: ");
                    decimal price = decimal.Parse(Console.ReadLine());

                    updateItem.SelectColorTable();
                    Console.Write("Insert the ID of the color for the item: ");
                    int colorID = int.Parse(Console.ReadLine());

                    updateItem.UpdateItem(id, itemId, price, colorID);
                    updateItem.SelectAll();

                    Console.Write("\nWould you like to make any other changes? Please select a number. "
                      + "\n1. Yes "
                      + "\n2. No "
                      + "\n");
                    answer2 = int.Parse(Console.ReadLine());

                    if (answer2 == 2)
                    {
                        state = false;
                    }
                }

                else if (answer == 5)
                {
                    state = false;
                }

                else
                {
                    Console.WriteLine("Please select one of the options below");
                }
            }

            Console.WriteLine("Have a beautiful day");
            Console.ReadKey();
        }
    }
}
