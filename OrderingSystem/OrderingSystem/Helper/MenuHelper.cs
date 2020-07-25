using System;
using System.Collections.Generic;
using System.Text;

namespace OrderingSystem.Helper
{
    class MenuHelper
    {
        public void prinAvailableDishes(List<Dish> dishes)
        {
            for (int i = 0; i < dishes.Count; i++)
            {
                Console.WriteLine(" [" + (i + 1).ToString() + "] " + dishes[i].Name);
            }
        }

        public Dish getSelectedDish(List<Dish> dishes)
        {
            int selectedOption;

            Console.WriteLine("Please select the number for the dish you want to order: ");
            selectedOption = Convert.ToInt32(Console.ReadLine()) - 1;

            if (selectedOption < 0 || selectedOption >= dishes.Count)
            {
                Console.WriteLine("Dish with number " + selectedOption.ToString() + " does not exist in menu!");
                return null;
            }

            return dishes[selectedOption];
        }

        public void printFullMenu(List<Dish> dishes)
        {
            for (int i = 0; i < dishes.Count; i++)
            {
                Console.WriteLine(" [" + (i + 1).ToString() + "] " + dishes[i].Name);
                Console.WriteLine("      Description: " + dishes[i].Description);
                Console.Write("      Ingredients: ");
                foreach (Ingredient ing in dishes[i].Ingredients)
                {
                    Console.Write(ing.Name + "; ");
                }
                Console.WriteLine("\n      Price: " + dishes[i].Price.ToString());
                Console.WriteLine("      Estimated time: " + dishes[i].EstimatedCookingTime.ToString());
                Console.WriteLine();
            }
        }

        public void printNavigationMenu()
        {
            Console.WriteLine("1. Menu.");
            Console.WriteLine("2. Order dish.  ");
            Console.WriteLine("0. Exit");
            Console.WriteLine("Select an option. ");
        }
    }
}
