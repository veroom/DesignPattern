
namespace Bridge
{
    class CountDisplay : Display
    {
        // コンストラクタ
        public CountDisplay(DisplayImpl impl) : base(impl)
        {
        }

        /// <summary>
        /// 複数回表示処理
        /// </summary>
        public void multiDisplay(int times)
        {
            Open();
            for (int i = 0; i < times; i++)
            {
                Print();
            }
            Close();
        }
    }
}
