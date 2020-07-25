using System;
using System.Collections.Generic;
using System.Text;

namespace OrderingSystem
{
    class Ingredient
    {
        private int id;
        private string name;
        private double price;

        public int Id
        {
            get { return id; }  
        }
        public  string Name
        {
            get { return name; }   
        }
        public double Price
        {
            get { return price; }   
        }

        public Ingredient(int id, string name, double price)
        {
            this.id = id;
            this.name = name;
            this.price = price;
        }
    }
}