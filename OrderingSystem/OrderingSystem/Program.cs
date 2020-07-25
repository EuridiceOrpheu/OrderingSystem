using OrderingSystem.Exceptions;
using OrderingSystem.Helper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;

namespace OrderingSystem
{
    class Program
    {
        static readonly string TEXT_FILE_INGREDIENTS = @"C:\Users\Botnari Iulia\source\repos\OrderingSystem\OrderingSystem\Data\ingredients.txt";
        static readonly string TEXT_FILE_DISHES = @"C:\Users\Botnari Iulia\source\repos\OrderingSystem\OrderingSystem\Data\dishes.txt";

        private const int COOKS_COUNT = 3;
        private const double PRICE_OFFSET = 1.2d;



        static void Main(string[] args)
        {
            MenuHelper menuHelper = new MenuHelper();
            OrderHelper orderHelper = new OrderHelper(TEXT_FILE_INGREDIENTS, TEXT_FILE_DISHES, COOKS_COUNT, PRICE_OFFSET);
            int option;

            do
            {
                menuHelper.printNavigationMenu();
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        menuHelper.printFullMenu(orderHelper.getDishes());
                        break;
                    case 2:
                        Dish selectedDish;

                        menuHelper.prinAvailableDishes(orderHelper.getDishes());
                        selectedDish = menuHelper.getSelectedDish(orderHelper.getDishes());
                        orderHelper.orderDish(selectedDish);
                        break;
                    case 0:
                        Console.WriteLine("Exit!");
                        break;

                    default:
                        Console.WriteLine("Please enter a value between 0 and 2!");
                        break;
                }

            } while (option != 0);


        }

      
    }
}
