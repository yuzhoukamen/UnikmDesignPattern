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
    public class FactoryPatternDemo
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="args"></param>
        public static void Main(String[] args)
        {
            ShapeFactory shapeFactory = new ShapeFactory();//使用该工厂，通过传递类型信息来获取实体类的对象。

            IShape shape1 = shapeFactory.GetShape("CIRCLE");//获取 Circle 的对象，并调用它的 draw 方法

            shape1.Draw();//调用 Circle 的 draw 方法
            
            IShape shape2 = shapeFactory.GetShape("RECTANGLE");//获取 Rectangle 的对象，并调用它的 draw 方法
            
            shape2.Draw();//调用 Rectangle 的 draw 方法
            
            IShape shape3 = shapeFactory.GetShape("SQUARE");//获取 Square 的对象，并调用它的 draw 方法

            shape3.Draw();//调用 Square 的 draw 方法

            Console.ReadLine();
        }
    }
}
