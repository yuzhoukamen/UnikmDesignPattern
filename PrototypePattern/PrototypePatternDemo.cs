using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    class PrototypePatternDemo
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        public static void Main(String[] args)
        {
            ShapeCache.loadCache();

            Shape clonedShape = (Shape)ShapeCache.getShape("1");

            Console.WriteLine("Shape : " + clonedShape.getType());

            Shape clonedShape2 = (Shape)ShapeCache.getShape("2");

            Console.WriteLine("Shape : " + clonedShape2.getType());

            Shape clonedShape3 = (Shape)ShapeCache.getShape("3");

            Console.WriteLine("Shape : " + clonedShape3.getType());

            Console.ReadLine();
        }
    }
}
