using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniPro
{
    enum MetalTypes { Iron, Steel }

    internal class Knife
    {

        public MetalTypes MetalType = MetalTypes.Iron;
        public string Maker = "aaa";
        public string Color = "Blck";
        public int Weight = 350;
    }
}
