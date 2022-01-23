using System;

namespace Prototype.framework
{
    interface Product : ICloneable
    {
        /// <summary>
        /// インスタンスの使用
        /// </summary>
        public abstract void use(string s);

        /// <summary>
        /// インスタンスの複製
        /// </summary>
        public abstract Product createClone();
    }
}
