using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniPro
{
    internal abstract class FactoryBase<T>
    {
        public List<T> Objects { get; private set; }

        public FactoryBase()
        {
            Objects = new List<T>();
        }

        public abstract void AddObject(T theNew);

        public abstract void Add5RandomObjects();

    }
}
