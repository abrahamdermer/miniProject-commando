using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniPro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Commando commando = new Commando("aaa", "123");
            commando.Walk();
            commando.Attack();
            commando.Hide();

            Weapon weapon = new Weapon("bbb", "bbb", 100);
            weapon.Shoot();
        }
    }
}
