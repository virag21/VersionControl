using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Week08_GXMRLU.Abstractions;

namespace Week08_GXMRLU.Entities
{
    class BallFactory:IToyFactory
    {
        public Abstractions.Toy CreateNew()
        {
            return new Toy();
        }
    }
}
