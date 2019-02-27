using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    public class ColorFactory : AbstractFactory
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public override IColor GetColor(string color)
        {
            if (color == null)
            {
                return null;
            }
            if (color.ToUpper().Equals("RED"))
            {
                return new Red();
            }
            else if (color.ToUpper().Equals("GREEN"))
            {
                return new Green();
            }
            else if (color.ToUpper().Equals("BLUE"))
            {
                return new Blue();
            }
            return null;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="shape"></param>
        /// <returns></returns>
        public override IShape GetShape(string shape)
        {
            return null;
        }
    }
}
