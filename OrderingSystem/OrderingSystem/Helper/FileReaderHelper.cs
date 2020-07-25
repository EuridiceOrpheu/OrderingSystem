using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace OrderingSystem.Helper
{
    class FileReaderHelper
    {

        public List<Dish> ReadDishes(string textFile, List<Ingredient> allIngredients)
        {
            string[] lines;
            string[] words;
            int[] idsIngredients;
            Ingredient ingredient;
            List<Ingredient> ingredients;

            Dish dish;
            List<Dish> dishes = new List<Dish>();
            if (File.Exists(textFile))
            {  
                lines = File.ReadAllLines(textFile);
                foreach (string line in lines)
                {
                    words = line.Split(';');
                    idsIngredients = Array.ConvertAll(words[2].ToString().Split(','), int.Parse);

                    ingredients = new List<Ingredient>();
                    foreach (int id in idsIngredients)
                    {
                        ingredient = allIngredients.Find(x => x.Id == id);
                        ingredients.Add(ingredient);
                    }


                    dish = new Dish(words[0].ToString(), words[1].ToString(), ingredients, Convert.ToInt32(words[3]));
                    dishes.Add(dish);
                }
            }
            return dishes;
        }
        public List<Ingredient> ReadIngredients(string textFile)
        {

            string[] lines;
            string[] words;

            Ingredient ingredient;
            List<Ingredient> ingredients = new List<Ingredient>();

            if (File.Exists(textFile))
            {
                lines = File.ReadAllLines(textFile);
                foreach (string line in lines)
                {
                    words = line.Split(';');
                    ingredient = new Ingredient(Convert.ToInt32(words[0]), words[1].ToString(), Convert.ToDouble(words[2]));
                    ingredients.Add(ingredient);

                };
            }
            return ingredients;
        }
    }
}
 
