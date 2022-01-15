using FactoryMethod.framework;
using System.Collections.Generic;

namespace FactoryMethod.idcard
{
    class IDCardFactory : Factory
    {
        // 使用者リスト
        public List<string> Owners {
            get
            {
                if (m_owners != null)
                {
                    return m_owners;
                }
                else
                {
                    m_owners = new List<string>();
                    return m_owners;
                }
            }
        }
        private List<string> m_owners;

        /// <summary>
        /// IDカードインスタンス生成
        /// </summary>
        protected override Product createProduct(string owner)
        {
            return new IDCard(owner);
        }

        /// <summary>
        /// 製品の登録
        /// </summary>
        protected override void registerProduct(Product product)
        {
            Owners.Add(((IDCard)product).owner);
        }
    }
}
