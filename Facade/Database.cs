using System.Collections.Generic;
using System.IO;
using Authlete.Util;

namespace Facade
{
    class Database
    {
        private Database() { }

        /// <summary>
        /// ユーザ名からメールアドレスを検索する
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        public static IDictionary<string, string> GetProperties(string dbname)
        {
            string filename = $"{dbname}.txt";
            IDictionary<string, string> prop;

            using (var reader = new StreamReader(filename))
            {
                prop = PropertiesLoader.Load(reader);
            }
            return prop;
        }
    }
}
