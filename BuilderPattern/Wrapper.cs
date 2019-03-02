using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    /// <summary>
    /// 
    /// 包装器
    /// 创建实现 IPacking 接口的实体类。
    /// </summary>
    public class Wrapper : IPacking
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string Pack()
        {
            return "Wrapper";
        }
    }
}
