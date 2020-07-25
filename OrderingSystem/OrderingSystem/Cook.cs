using System;
using System.Collections.Generic;
using System.Text;

namespace OrderingSystem
{
    class Cook
    {

        private const int NUMBER_OF_DISHES_PER_COOK = 2;

        private string name;
        private List<Dish> dishes;

        public string Name
        {
            get { return name; }
        }
        public List<Dish> Dishes
        {
            get { return dishes; }
        }
        public Cook(string name)
        {
            this.name = name;
            this.dishes = new List<Dish>();
        }
        public bool isAvailable() 
        {
            if (dishes.Count == NUMBER_OF_DISHES_PER_COOK)
                return false;
            return true;
        }
        public void addDish(Dish dish)
        {
            if (dishes.Count < NUMBER_OF_DISHES_PER_COOK)
            {
                dishes.Add(dish);
            }
        }

        public int calculateEstimatedFinishTime()
        {
            int totalTime = 0;

            if (dishes == null)
                return 0;

            foreach (Dish dish in dishes)
            {
                totalTime += dish.EstimatedCookingTime;
            }
            return totalTime;
        }

    }
}
