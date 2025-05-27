using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniPro
{
    internal class Commando
    {
        public string Name { get;private set; }
        public string CodeName { get;private set; }
        public string[] Tools { get; } = new string[] { "Hammer", "Chisel", "Rope", "Bag", "Water bottle" };
        public string Status { get; private set; } = "standing";


        public Commando(string name,string codeName)
        {
            Name = name;
            CodeName = codeName;
        }

        public void Walk()
        {
            Console.WriteLine("sulder walking");
            Status = "Walk";
        }
        public void Hide()
        {
            Console.WriteLine("sulder hideing");
            Status = "Hide";
        }
        public void Attack()
        {
            Console.WriteLine($"The {CodeName} Attacking");
        }

    }
}
