using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    interface Iterator
    {
        /// <summary>
        /// 「次の要素」が存在するか
        /// </summary>
        public abstract Boolean hasNext();

        /// <summary>
        /// 「次の要素」を取得する
        /// </summary>
        public abstract object next();
    }
}
