using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prototype.framework
{
    class Manager
    {
        private Dictionary<string, Object> showCase = new Dictionary<string, Object>();
        public void register(string name, Product proto)
        {
            showCase.Add(name, proto);
        }

        public Product create(string protoname)
        {
            Product p = (Product)showCase[protoname];
            return p.createClone();
        }
    }
}
