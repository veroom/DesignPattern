using System;


namespace Singleton
{
    class Singleton
    {
        /// <summary>
        /// シングルトンパターン
        /// </summary>
        public static Singleton singleton
        {
            get { return m_singleton; }
        }
        private static Singleton m_singleton = new Singleton();

        // コンストラクタ
        private Singleton()
        {
            Console.WriteLine("インスタンスを生成しました。");
        }
    }
}
