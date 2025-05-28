using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniPro
{
    internal class WeaponFactory:FactoryBase<Weapon>
    {
        public override void AddObject(Weapon theNew)
        {
            Objects.Add(theNew);
            
        }

        public override void Add5RandomObjects()
        {
            Random random = new Random();
            string[] names = new string[] { "aaa", "bbb", "ccc", "ddd", "eee" };
            string[] makers = new string[] { "fff", "ggg", "hhh" };
            foreach (string name in names)
            {
                Objects.Add(new Weapon(name, makers[random.Next(makers.Length)], Objects.Count));
            }
        }

        public void CreateM16()
        {
            Objects.Add(new Weapon("m16", "COLT", 29));
        }
        public void CreateAK47()
        {
            Objects.Add(new Weapon("AK47", "KALASHNIKOV", 30));
        }


    }
}
