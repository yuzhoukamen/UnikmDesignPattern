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
    public class MealBuilder
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public Meal prepareVegMeal()
        {
            Meal meal = new Meal();

            meal.addItem(new VegBurger());
            meal.addItem(new Coke());

            return meal;
        }

        public Meal prepareNonVegMeal()
        {
            Meal meal = new Meal();

            meal.addItem(new ChickenBurger());
            meal.addItem(new Pepsi());

            return meal;
        }
    }
}
