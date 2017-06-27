﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClothingInventory
{
    class Delete
    {
        public void ShowItems()
        {

            using (DataBase01Entities context = new DataBase01Entities())
            {
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


        public void DeleteItem(int id)
        {
            using (DataBase01Entities context = new DataBase01Entities())
            {
                TblClothing clothing = context.TblClothings.FirstOrDefault(c => c.ID == id);
                context.TblClothings.Remove(clothing);
                context.SaveChanges();
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
