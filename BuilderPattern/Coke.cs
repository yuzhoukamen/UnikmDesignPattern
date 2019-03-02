using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    /// <summary>
    /// 创建扩展了 ColdDrink 的实体类。
    /// </summary>
    public class Coke : ColdDrink
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override string Name()
        {
            return "Coke";
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public override float Price()
        {
            return 30.0f;
        }
    }
}
