using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniPro
{
    internal class CommandoFactory:FactoryBase<Commando>

    {
        enum comandoypes  { Air ,Sea }
        public override void AddObject(Commando theNew)
        {
            Objects.Add(theNew);

        }

        

        public override void Add5RandomObjects()
        {
            Random random = new Random();
            string[] names = new string[] { "aaa", "bbb", "ccc", "ddd", "eee" };

            foreach (string name in names)
            {
                Objects.Add(new AirCommando(name, $"{Objects.Count}"));
            }
        }
    }
}
