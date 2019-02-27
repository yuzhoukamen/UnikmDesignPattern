using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    /// <summary>
    /// 创建扩展了 AbstractFactory 的工厂类，基于给定的信息生成实体类的对象。
    /// </summary>
    public class ShapeFactory : AbstractFactory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="shapeType"></param>
        /// <returns></returns>
        public override IShape GetShape(string shapeType)
        {
            if (shapeType == null)
            {
                return null;
            }
            if (shapeType.ToUpper().Equals("CIRCLE"))
            {
                return new Circle();
            }
            else if (shapeType.ToUpper().Equals("RECTANGLE"))
            {
                return new Rectangle();
            }
            else if (shapeType.ToUpper().Equals("SQUARE"))
            {
                return new Square();
            }
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public override IColor GetColor(string color)
        {
            return null;
        }
    }
}
