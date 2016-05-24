using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuzzcoffee
{
    class NonDecoratedFord : IFordTaurus
    {
        public double Price()//Starting Price
        {
            return 24500;
        }
        public double Rating()//Starting Rating
        {
            return 5.5;
        }


    }
}
