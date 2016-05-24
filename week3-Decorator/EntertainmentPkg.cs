using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuzzcoffee
{
    class EntertainmentPkg: LayerDecorator
    {

        private string _info = "Ultimate entertainment package";
        public EntertainmentPkg(IFordTaurus c)
        {
            base.FordTaurus = c;
        }
        public override double Price()
        {
            return (2500 + base.FordTaurus.Price());
        }
        public override double Rating()
        {
            return (1 + base.FordTaurus.Rating());
        }
        public string GetLayerInfo()
        {
            return _info;
        }
    }
}
