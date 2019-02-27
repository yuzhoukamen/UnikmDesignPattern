using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    /// <summary>
    /// 为 Color 和 Shape 对象创建抽象类来获取工厂。
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
