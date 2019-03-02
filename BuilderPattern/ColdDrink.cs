using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    public abstract class ColdDrink : IItem
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public virtual string Name()
        {
            return "ColdDrink";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IPacking Packing()
        {
            return new Bottle();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public abstract float Price();
    }
}
