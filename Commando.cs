using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniPro
{
    internal class Commando
    {
        private string Name { get; }
        public string CodeName { get; set; }
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
        public virtual void Attack()
        {
            Console.WriteLine($"The {CodeName} Attacking");
        }

        public string SeyName(string commanderRank)
        {
            if(commanderRank == "GENERAL")
                return(Name);
            else if(commanderRank == "COLONEL")
                return(CodeName);
            else
                return("xxxxxxxxxxxxxxxxxxx");
        }

    }
}
