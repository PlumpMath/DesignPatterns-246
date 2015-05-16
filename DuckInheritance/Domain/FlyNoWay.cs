using System;

namespace DuckInheritance.Domain {
    public class FlyNoWay : IFlyBehavior {
        public void Fly() {
            Console.WriteLine("Crash and burn!");
        }
    }
}