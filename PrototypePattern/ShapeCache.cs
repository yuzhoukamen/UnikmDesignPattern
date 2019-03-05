using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    /// <summary>
    /// 
    /// </summary>
    public class ShapeCache
    {
        /// <summary>
        /// 
        /// </summary>
        private static Dictionary<string, Shape> shapeMap = new Dictionary<string, Shape>();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="shapeId"></param>
        /// <returns></returns>
        public static Shape getShape(string shapeId)
        {
            Shape cachedShape = shapeMap[shapeId];

            return (Shape)cachedShape.clone();
        }

        /// <summary>
        /// 对每种形状都运行数据库查询，并创建该形状
        /// shapeMap.put(shapeKey, shape);
        /// 例如，我们要添加三种形状
        /// </summary>
        public static void loadCache()
        {
            Circle circle = new Circle();

            circle.setId("1");
            shapeMap.Add(circle.getId(), circle);

            Square square = new Square();

            square.setId("2");
            shapeMap.Add(square.getId(), square);

            Rectangle rectangle = new Rectangle();

            rectangle.setId("3");
            shapeMap.Add(rectangle.getId(), rectangle);
        }
    }
}
