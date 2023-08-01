using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace open_closed
{
    public class Production
    {
        public IEnumerable<ICraftable> Materials { get; set; }

        public Production(IEnumerable<ICraftable> manyMaterials)
        {
            Materials = manyMaterials;
        }

        public override string ToString()
        {
            string description = "Object is composed of\n:";
            foreach (ICraftable material in Materials)
            {
                description += "\t" + material.GetType();
            }
            return description;
        }
    }
}
