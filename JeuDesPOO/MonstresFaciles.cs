using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JeuDesPOO
{
    public class MonstresFaciles
    {
        public int MyProperty { get; private set; }

        public static int MonstreFacileAttaque()
        {
            De MonstreDe = new De();
            return MonstreDe.LancerLeDe();
        }
    }
}
