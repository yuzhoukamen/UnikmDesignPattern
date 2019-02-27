using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    /// <summary>
    /// 
    /// </summary>
    public class Square : IShape
    {
        /// <summary>
        /// 
        /// </summary>
        public void Draw()
        {
            Console.WriteLine("Inside Square::draw() method.");
        }
    }
}
