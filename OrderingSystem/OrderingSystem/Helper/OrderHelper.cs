using OrderingSystem.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OrderingSystem.Helper
{
    class OrderHelper
    {

        private List<Cook> cooksList;
        private List<Dish> dishes;


        public OrderHelper(string ingregientsFile, string dishesFile, int cooksCount, double priceOffset)
        {
            FileReaderHelper fileReader = new FileReaderHelper();
            List<Ingredient> ingredients = fileReader.ReadIngredients(ingregientsFile);
            dishes = fileReader.ReadDishes(dishesFile, ingredients);

            //calculate price
            foreach (var dish in dishes)
            {
                dish.updateDishPrice(priceOffset);
            }

            cooksList = new List<Cook>();
            for (int i = 1; i <= cooksCount; i++)
            {
                Cook cook = new Cook("Cook" + i.ToString());

                cooksList.Add(cook);
            }
        }

        public List<Dish> getDishes()
        {
            return dishes;
        }

        public  Cook findAvailableCook()
        {

            int min = cooksList[0].Dishes.Count();
            Cook cook = cooksList[0];
            for (int i = 0; i < cooksList.Count - 1; i++)
            {
                if (cooksList[i].Dishes.Count() > cooksList[i + 1].Dishes.Count())
                {
                    min = cooksList[i + 1].Dishes.Count();
                    cook = cooksList[i + 1];
                   
                }
            }
           
            if (!cook.isAvailable())
            {
                throw new NoCooksAvailableException(" All cooks are busy! ");
            }
            return cook;
        }

        public void orderDish(Dish dish)
        {
            try
            {
                Cook availableCook = findAvailableCook();
                Console.WriteLine(availableCook.Name + " is preparing " + dish.Name + ".");
                availableCook.addDish(dish);
                Console.WriteLine("Estimated cooking time: " + availableCook.calculateEstimatedFinishTime().ToString() + " minutes.\n");
            }
            catch (NoCooksAvailableException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
