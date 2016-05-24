using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Starbuzzcoffee
{
    public abstract class LayerDecorator : IFordTaurus
    {
        public IFordTaurus FordTaurus { get; set; }

        public abstract double Price();
        public abstract double Rating();




    }
}
