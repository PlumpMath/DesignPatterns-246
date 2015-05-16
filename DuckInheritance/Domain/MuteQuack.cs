using System;

namespace DuckInheritance.Domain {
    public class MuteQuack : IQuackBehavior {
        public void Quack() {
            Console.WriteLine("...");
        }
    }
}