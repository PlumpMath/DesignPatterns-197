using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuzzcoffee
{
    class Navsystem : LayerDecorator
    {

        private string _info = "Worldwide navigation system upgrade";
        public Navsystem(IFordTaurus c)
        {
            base.FordTaurus = c;
        }
        public override double Price()
        {
            return (1450 + base.FordTaurus.Price());
        }
        public override double Rating()
        {
            return (0.25 + base.FordTaurus.Rating());
        }
        public string GetLayerInfo()
        {
            return _info;
        }
    }
}
