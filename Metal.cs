using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace open_closed
{
    public class Metal : ICraftable
    {
        public string Type;
        public string GetType()
        {
            return "Metal";
        }
    }
}
