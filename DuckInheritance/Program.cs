using DuckInheritance.Domain;

namespace DuckInheritance
{
    class Program
    {
        static void Main(string[] args) {
            var duck = new MallardDuck();
            duck.FlyBehavior.Fly();
            duck.QuackBehavior.Quack();
        }
    }
}
