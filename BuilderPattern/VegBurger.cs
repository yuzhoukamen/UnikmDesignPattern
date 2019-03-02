using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    /// <summary>
    /// 素食汉堡
    /// 创建扩展了 Burger 的实体类。
    /// </summary>
    public class VegBurger : Burger
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string Name()
        {
            return "Veg Burger";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override float Price()
        {
            return 25.0f;
        }
    }
}
