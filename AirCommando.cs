using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniPro
{
    internal class AirCommando:Commando
    {
        public AirCommando(string name, string codeName):base(name, codeName){ }

        public void ToFly()
        {
            Console.WriteLine("soldher flying");
        }

        public override void  Attack()
        {
            Console.WriteLine("Air commando attacking");
        }
        
    }
}
