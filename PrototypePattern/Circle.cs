using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    /// <summary>
    /// 
    /// </summary>
    public class Circle : Shape
    {
        /// <summary>
        /// 
        /// </summary>
        public Circle()
        {
            type = "Circle";
        }

        /// <summary>
        /// 
        /// </summary>
        public override void draw()
        {
            Console.WriteLine("Inside Circle::draw() method.");
        }
    }
}
