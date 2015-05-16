using System;

namespace DuckInheritance.Domain {
    public class FlyWithWings : IFlyBehavior {
        public void Fly() {
            Console.WriteLine("Look mom, I'm flying with my wings!!");
        }
    }
}