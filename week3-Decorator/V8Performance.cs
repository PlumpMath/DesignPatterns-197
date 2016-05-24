using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuzzcoffee
{
    class V8Performance : LayerDecorator
    {

        private string _info = "Snow tires upgrade";
        public V8Performance(IFordTaurus c)
        {
            base.FordTaurus = c;
        }
        public override double Price()
        {
            return (3500 + base.FordTaurus.Price());
        }
        public override double Rating()
        {
            return (1.5 + base.FordTaurus.Rating());
        }
        public string GetLayerInfo()
        {
            return _info;
        }
    }
}
