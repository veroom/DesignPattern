using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapter2
{
    class PrintBanner : Print
    {
        private Banner banner;

        // コンストラクタ
        public PrintBanner(string message)
        {
            this.banner = new Banner(message);
        }

        /// <summary>
        /// **で括られた文字列を表示
        /// </summary>
        public override void printStrong()
        {
            banner.showWithAster();
        }

        /// <summary>
        /// ()で括られた文字列を表示
        /// </summary>
        public override void printWeek()
        {
            banner.showWithParen();
        }
    }
}
