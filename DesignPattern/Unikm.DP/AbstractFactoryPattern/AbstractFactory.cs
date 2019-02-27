using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unikm.DP.AbstractFactoryPattern
{
    /// <summary>
    /// 
    /// </summary>
    public abstract class AbstractFactory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public abstract IColor GetColor(string color);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="shape"></param>
        /// <returns></returns>
        public abstract IShape GetShape(string shape);
    }
}
