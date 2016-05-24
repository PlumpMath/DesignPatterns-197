using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuzzcoffee
{
    class PushBumper : LayerDecorator
    {
        private string _info = "Push Bumper/ Bullbar upgrade";
        public PushBumper(IFordTaurus c)
        {
            base.FordTaurus = c;
        }
        public override double Price()
        {
            return (1600 + base.FordTaurus.Price());
        }
        public override double Rating()
        {
            return (0.5 + base.FordTaurus.Rating());
        }
        public string GetLayerInfo()
        {
            return _info;
        }



    }
}
