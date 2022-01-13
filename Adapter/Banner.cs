using System;

namespace Adapter1
{
    class Banner
    {
        private string message;

        // コンストラクタ
        public Banner(string message)
        {
            this.message = message;
        }

        /// <summary>
        /// メッセージを()で括る
        /// </summary>
        public void showWithParen()
        {
            Console.WriteLine("(" + message + ")");
        }

        /// <summary>
        /// メッセージを**で括る
        /// </summary>
        public void showWithAster()
        {
            Console.WriteLine("*" + message + "*");
        }
    }
}
