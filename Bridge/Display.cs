using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge
{
    class Display
    {
        private DisplayImpl impl;

        // コンストラクタ
        public Display(DisplayImpl impl)
        {
            this.impl = impl;
        }

        /// <summary>
        /// 表示前処理
        /// </summary>
        public void Open()
        {
            impl.RawOpen();
        }

        /// <summary>
        /// 表示処理
        /// </summary>
        public void Print()
        {
            impl.RawPrint();
        }

        /// <summary>
        /// 表示後処理
        /// </summary>
        public void Close()
        {
            impl.RawClose();
        }

        /// <summary>
        /// 処理実行
        /// </summary>
        public void display()
        {
            Open();
            Close();
            Print();
        }
    }
}
