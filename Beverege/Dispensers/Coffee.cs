using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Beverege.Dispensers
{
    public class Coffee : DrinkDispenser
    {
        public override int Price { get; } = 45;
    }
}
