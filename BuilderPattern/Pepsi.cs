using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    /// <summary>
    /// 百事可乐
    /// </summary>
    public class Pepsi : ColdDrink
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override float Price()
        {
            return 35.0f;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string Name()
        {
            return "Pepsi";
        }
    }
}
