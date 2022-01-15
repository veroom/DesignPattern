using System;

namespace FactoryMethod.framework
{
    abstract class Factory
    {
        /// <summary>
        /// Productインスタンスの生成
        /// </summary>
        public Product Create(String owner)
        {
            Product product = createProduct(owner);
            registerProduct(product);
            return product;
        }

        /// <summary>
        /// 製品を作る
        /// </summary>
        protected abstract void registerProduct(Product product);

        /// <summary>
        /// 製品情報の登録
        /// </summary>
        protected abstract Product createProduct(string owner);
    }
}
