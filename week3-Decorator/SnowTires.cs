using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuzzcoffee
{
    class SnowTires : LayerDecorator
    {

        private string _info = "Snow tires upgrade";
        public SnowTires(IFordTaurus c)
        {
            base.FordTaurus = c;
        }
        public override double Price()
        {
            return (900 + base.FordTaurus.Price());
        }
        public override double Rating()
        {
            return (0.75 + base.FordTaurus.Rating());
        }
        public string GetLayerInfo()
        {
            return _info;
        }
    }
}
