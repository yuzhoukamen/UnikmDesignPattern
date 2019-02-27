using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryPattern
{
    /// <summary>
    /// 创建一个工厂，生成基于给定信息的实体类的对象。
    /// </summary>
    public class ShapeFactory
    {
        /// <summary>
        /// 使用 getShape 方法获取形状类型的对象
        /// </summary>
        /// <param name="shapeType"></param>
        /// <returns></returns>
        public IShape GetShape(string shapeType)
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
    }
}
