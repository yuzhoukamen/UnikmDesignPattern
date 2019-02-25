using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unikm.DP.FactoryPattern
{
    /// <summary>
    /// 
    /// </summary>
    public class Circle : IShape
    {
        /// <summary>
        /// 
        /// </summary>
        public void Draw()
        {
            Console.WriteLine("Inside Circle::draw() method.");
        }
    }
}
