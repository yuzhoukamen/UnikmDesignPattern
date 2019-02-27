using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    /// <summary>
    /// 为 Color 和 Shape 对象创建抽象类来获取工厂。
    /// 在C#中使用关键字 abstract 来定义抽象类和抽象方法。
    /// 不能初始化的类被叫做抽象类，它们只提供部分实现，但是另一个类可以继承它并且能创建它们的实例。
    /// 一个包含一个或多个纯虚函数的类叫抽象类，抽象类不能被实例化，进一步一个抽象类只能通过接口和作为其它类的基类使用.
    /// 抽象类能够被用于类，方法，属性，索引器和事件，使用abstract 在一个类声明中表示该类倾向要作为其它类的基类
    /// 成员被标示成abstract，或被包含进一个抽象类，必须被其派生类实现。
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
