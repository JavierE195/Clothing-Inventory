using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingInventory
{
    class Insert
    {
        public void InsertItem(int Item, int Color, decimal Price)
        {
            using (DataBase01Entities context = new DataBase01Entities())
            {
                TblClothing newItem = new TblClothing();
                newItem.ItemID = Item;
                newItem.Price = Price;
                newItem.ColorID = Color;

                context.TblClothings.Add(newItem);
                context.SaveChanges();

            }
        }

        public void SelectItemTable()
        {
            using (DataBase01Entities context = new DataBase01Entities())
            {
                List<TblItem> objItem = context.TblItems.ToList<TblItem>();
                foreach (TblItem i in objItem)
                {
                    Console.WriteLine(i.ID + "  " + i.Item);
                }

            }
        }

        public void SelectColorTable()
        {
            using (DataBase01Entities context = new DataBase01Entities())
            {
                List<TblColor> objColor = context.TblColors.ToList<TblColor>();
                foreach (TblColor c in objColor)
                {
                    Console.WriteLine(c.ID + "  " + c.Color);
                }
            }
        }

        public void SelectAll()
        {
            using (DataBase01Entities context = new DataBase01Entities())


            {
                Console.WriteLine("All cloth stored: ");

                foreach (var cloth in context.TblClothings)
                {
                    TblClothing clothing = context.TblClothings.FirstOrDefault(c => c.ID == cloth.ID);

                    Console.WriteLine("ID: " + clothing.ID + ", " +
                                     "Item: " + clothing.TblItem.Item + ", " +
                                    "Color: " + clothing.TblColor.Color + ", " +
                                    "Price: $" + clothing.Price);

                }
            }
        }
    }
}
