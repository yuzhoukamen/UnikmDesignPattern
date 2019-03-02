using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    /// <summary>
    /// 创建一个表示食物包装的接口。
    /// </summary>
    public interface IPacking
    {
        /// <summary>
        /// 包装
        /// </summary>
        /// <returns></returns>
        string Pack();
    }
}
