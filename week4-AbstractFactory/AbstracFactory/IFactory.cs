using System;
using System.Windows.Forms;

namespace week4_AbstractFactory
{
    public interface ICarFactory
    {
        IHybrid CreateHybrid();
        ISUV CreateSUV();
    }
}