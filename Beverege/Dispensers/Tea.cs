using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beverege.Dispensers
{
    public class Tea : DrinkDispenser
    {
        public override int Price { get; } = 30;
    }
}
