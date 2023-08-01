using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace open_closed
{
    public sealed class Factory
    {
        public Production Craft(IEnumerable<ICraftable> manyBlocks)
        {
            Production newProduction = new Production(manyBlocks);
            return newProduction;
        }
    }
}
