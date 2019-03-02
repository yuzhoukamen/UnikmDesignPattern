using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    /// <summary>
    /// 创建一个表示食物条目的接口。
    /// </summary>
    public interface IItem
    {
        /// <summary>
        /// 名称
        /// </summary>
        /// <returns></returns>
        string Name();

        /// <summary>
        /// 包装
        /// </summary>
        /// <returns></returns>
        IPacking Packing();

        /// <summary>
        /// 价格
        /// </summary>
        /// <returns></returns>
        float Price();
    }
}
