using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniPro
{
    internal class GAME
    {
        WeaponFactory Weapons = new WeaponFactory();
        EnemyFactory Enemies = new EnemyFactory();
        CommandoFactory Commandos = new CommandoFactory();


        public GAME()
        {
            Weapons.Add5RandomObjects();
            Enemies.Add5RandomObjects();
            Commandos.Add5RandomObjects();
        }
        
        
    }
}
