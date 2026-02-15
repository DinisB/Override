using System.Collections;
using System.Collections.Generic;
using System.Threading;

namespace Override
{
    public class Sweatshop
    {
        public IList<Puppet> Puppets { get; set; }

        public int Money;

        public Sweatshop()
        {
            Puppets = new List<Puppet>();
            Money = 0;
        }
    }
}