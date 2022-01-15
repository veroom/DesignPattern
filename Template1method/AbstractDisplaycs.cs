

namespace TemplateMethod
{
    abstract class AbstractDisplaycs
    {
        /// <summary>
        /// 表示開始
        /// </summary>
        public abstract void Open();

        /// <summary>
        /// 表示終了
        /// </summary>
        public abstract void Close();

        /// <summary>
        /// コンストラクタで与えられた文字列(文字)を表示する
        /// </summary>
        public abstract void Print();

        /// <summary>
        /// 文字列表示処理
        /// </summary>
        public void Display()
        {
            Open();

            for (int i = 0; i < 5; i++)
            {
                Print();
            }

            Close();
        }
    }
}
