using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hashtable_CS
{
    internal class IceCream
    {
        public IceCream(int ID)
        {
            _Id = ID;
        }
        private readonly int _Id;

        public int Id
        {
            get { return _Id; }

        }

        public int numIceCreamBall { get; set; }

    }
}
