using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_lab
{
    abstract class PizzaFilling
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public abstract void GetPrice();
        public PizzaFilling(string name, double price)
        {
            Name = name;
            Price = price;
        }
    }

    class ItaliaPizza : PizzaFilling
    {
        public ItaliaPizza(string name, double price) : base(name, price)
        {

        }

        public override void GetPrice()
        {
            Console.WriteLine($"Name: {Name} Price: {Price}");
        }
    }

    class BasePizza : PizzaFilling
    {
        public BasePizza(string name, double price) : base(name, price)
        {

        }

        public override void GetPrice()
        {
            Console.WriteLine($"Name: {Name} Price: {Price}");
        }
    }

    abstract class BaseDecorator : PizzaFilling
    {
        public PizzaFilling pizza { get; set; }
        public BaseDecorator(string name, double price) : base(name, price)
        {

        }
    }

    class CheezeDecorator : BaseDecorator
    {
        public CheezeDecorator(PizzaFilling pizza) : base(pizza.Name += " Cheeze", pizza.Price += 20)
        {

        }

        public override void GetPrice()
        {
            Console.WriteLine($"Name: {Name} Price: {Price}");
        }
    }

    class PotatoDecorator : BaseDecorator
    {
        public PotatoDecorator(PizzaFilling pizza) : base(pizza.Name += " Potato", pizza.Price += 10.5)
        {

        }

        public override void GetPrice()
        {
            Console.WriteLine($"Name: {Name} Price: {Price}");
        }
    }
}
