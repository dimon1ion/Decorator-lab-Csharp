using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaFilling italia = new ItaliaPizza("Italiya", 2.56);
            italia = new CheezeDecorator(italia);
            italia = new PotatoDecorator(italia);
            italia.GetPrice();
        }
    }
}
