using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    /// <summary>
    /// 
    /// </summary>
    public interface ICloneable
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        string getType();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        string getId();

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        void setId(string id);

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        object clone();
    }
}
