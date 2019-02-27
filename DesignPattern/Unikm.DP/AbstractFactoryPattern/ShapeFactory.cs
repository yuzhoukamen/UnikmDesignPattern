﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unikm.DP.AbstractFactoryPattern
{
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
