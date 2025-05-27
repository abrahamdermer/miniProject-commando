using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniPro
{
    internal class Weapon
    {
        public string Name { get; private set; }
        public string Maker { get; private set; }
        public int BallsNum { get; private set; }


        public Weapon(string name,string maker , int ballsNum)
        {
            Name = name;
            Maker = maker;
            BallsNum = ballsNum;
        }

        public void Shoot()
        {
            Console.WriteLine("-<->-<- SHOOT ->-<->-");
            BallsNum--;
        }
}

}

