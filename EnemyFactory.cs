using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniPro
{
    internal class EnemyFactory : FactoryBase<Enemy>
    {

        public override void AddObject(Enemy theNew)
        {
            Objects.Add(theNew);
        }

        public override void Add5RandomObjects()
        {
            string[] names = new string[] { "aaa" ,"bbb","ccc","ddd","eee"};
            foreach (string name in names)
                AddObject(new Enemy(name+Objects.Count));
        }


    }
}
