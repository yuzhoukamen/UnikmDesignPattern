using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    /// <summary>
    /// 
    /// </summary>
    public class BuilderPatternDemo
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        public static void Main(String[] args)
        {
            MealBuilder mealBuilder = new MealBuilder();

            Meal vegMeal = mealBuilder.prepareVegMeal();

            Console.WriteLine("Veg Meal");

            vegMeal.showItems();

            Console.WriteLine("Total Cost: " + vegMeal.getCost());

            Meal nonVegMeal = mealBuilder.prepareNonVegMeal();

            Console.WriteLine("\n\nNon-Veg Meal");

            nonVegMeal.showItems();

            Console.WriteLine("Total Cost: " + nonVegMeal.getCost());

            Console.ReadLine();
        }
    }
}
