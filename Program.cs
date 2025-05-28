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

            //Logger.writeLog("test " + System.DateTime.Now);
            //Logger.printDayLogsToConsole();

            Commando commando = new Commando("aaa", "123");
            commando.Walk();
            commando.Attack();
            commando.Hide();

            Weapon weapon = new Weapon("bbb", "bbb", 100);
            weapon.Shoot();

            //commando.Name
            Console.WriteLine(commando.SeyName("GENERAL"));
            Console.WriteLine(commando.SeyName("COLONEL"));
            Console.WriteLine(commando.SeyName("_"));
            Console.WriteLine(commando.CodeName);
            commando.CodeName = "456";
            Console.WriteLine(commando.CodeName);

            Commando[] commandos = { commando, new SeaCommando("ccc", "123"), new AirCommando("ddd", "789") };
            foreach (Commando com in commandos)
            {
                com.Attack();
            }
        }
    }
}
