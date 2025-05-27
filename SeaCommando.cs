using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniPro
{
    internal class SeaCommando : Commando
    {
        public SeaCommando(string name, string codeName) : base(name, codeName) { }


        public void ToSwimming()
        {
            Console.WriteLine("sholder swimming");
        }

        public override void Attack()
        {
            Console.WriteLine("Sea commando attacking");
        }
    }
}

