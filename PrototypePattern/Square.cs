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
    public class Square : Shape
    {
        /// <summary>
        /// 
        /// </summary>
        public Square()
        {
            type = "Square";
        }

        /// <summary>
        /// 
        /// </summary>
        public override void draw()
        {
            Console.WriteLine("Inside Square::draw() method.");
        }
    }
}
