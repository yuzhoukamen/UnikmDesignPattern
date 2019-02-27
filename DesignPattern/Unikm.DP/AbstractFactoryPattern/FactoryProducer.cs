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
    public class FactoryProducer
    {
        /// <summary>
        /// 创建一个工厂创造器/生成器类，通过传递形状或颜色信息来获取工厂。
        /// </summary>
        /// <param name="choice"></param>
        /// <returns></returns>
        public static AbstractFactory GetFactory(String choice)
        {
            if (choice.ToUpper().Equals("SHAPE"))
            {
                return new ShapeFactory();
            }
            else if (choice.ToUpper().Equals("COLOR"))
            {
                return new ColorFactory();
            }
            return null;
        }
    }
}
