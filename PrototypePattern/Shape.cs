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
    public abstract class Shape : ICloneable
    {
        /// <summary>
        /// 
        /// </summary>
        private string id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        protected string type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public abstract void draw();

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public object clone()
        {
            return this;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string getId()
        {
            return id;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public string getType()
        {
            return type;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        public void setId(string id)
        {
            this.id = id;
        }
    }
}
