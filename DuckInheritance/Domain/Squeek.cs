using System;

namespace DuckInheritance.Domain {
    public class Squeek : IQuackBehavior {
        public void Quack() {
            Console.WriteLine("(squeek)");
        }
    }
}