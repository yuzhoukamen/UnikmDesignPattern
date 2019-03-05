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
    public class Rectangle : Shape
    {
        /// <summary>
        /// 
        /// </summary>
        public Rectangle()
        {
            type = "Rectangle";
        }

        /// <summary>
        /// 
        /// </summary>
        public override void draw()
        {
            Console.WriteLine("Inside Rectangle::draw() method.");
        }
    }
}
