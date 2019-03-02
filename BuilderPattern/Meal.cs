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
    public class Meal
    {
        /// <summary>
        /// 
        /// </summary>
        private List<IItem> items = new List<IItem>();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="item"></param>
        public void addItem(IItem item)
        {
            this.items.Add(item);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public float getCost()
        {
            float cost = 0.0f;

            foreach (IItem item in this.items)
            {
                cost += item.Price();
            }

            return cost;
        }

        /// <summary>
        /// 
        /// </summary>
        public void showItems()
        {
            foreach (IItem item in this.items)
            {
                Console.WriteLine("Item : " + item.Name());
                Console.WriteLine(", Packing : " + item.Packing().Pack());
                Console.WriteLine(", Price : " + item.Price());
            }
        }
    }
}
