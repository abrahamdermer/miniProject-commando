using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniPro
{
    internal class Enemy
    {
        public string Name { get; private set; }
        public int Live { get; private set; } = 100;
        public bool IsLive { get; private set; } = true;

        public Enemy(string name)
        {
            Name = name;
        }

        public void Alert()
        {
            if(IsLive)
                Console.WriteLine("I am enemy");
        }

        public void DecrisLive(int num)
        {
            Live -= num;
            if (Live <= 0)
                IsLive = false;
        }

    }
}
