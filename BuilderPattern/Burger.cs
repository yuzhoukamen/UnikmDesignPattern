using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    /// <summary>
    /// 创建实现 Item 接口的抽象类，该类提供了默认的功能。
    /// </summary>
    public abstract class Burger : IItem
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string Name()
        {
            return "Burger";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IPacking Packing()
        {
            return new Wrapper();
        }

        public abstract float Price();
    }
}
