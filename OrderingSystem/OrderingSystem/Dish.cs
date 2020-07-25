using System;
using System.Collections.Generic;
using System.Text;

namespace OrderingSystem
{
    class Dish
    {

        private string name;
        private string description;

        private double price;

        private int estimatedCookingTime; //minutes

        private List<Ingredient> ingredients;
        public string Name
        {
            get { return name; }
        }
        public string Description
        {
            get { return description; }
        }
        public double Price
        {
            get { return price; }
            set { price = value; }

        }
        public int EstimatedCookingTime
        {
            get { return estimatedCookingTime; }

        }
        public List<Ingredient> Ingredients
        {
            get { return ingredients; }

        }
        public Dish(string name, string description, List<Ingredient> ingredients,  int estimatedCookingTime)
        {
            this.name = name;
            this.description = description;
            this.estimatedCookingTime = estimatedCookingTime;
            this.ingredients = ingredients;
        }

        public void updateDishPrice(double priceOffset)
        {
            double sum = 0d;

            foreach (Ingredient ingredient in ingredients)
            {
                sum += ingredient.Price;
            }

            Price = Math.Round(priceOffset * sum, 2);
        }

    }
}
