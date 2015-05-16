using System;

namespace DuckInheritance.Domain {
    public class QuackLoud : IQuackBehavior {
        public void Quack() {
            Console.WriteLine("Quaaaack Quack Quack Quack");
        }
    }
}