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
    public class ChickenBurger : Burger
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string Name()
        {
            return "Chicken Burger";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override float Price()
        {
            return 50.5f;
        }
    }
}
