namespace DuckInheritance.Domain {
    public class MallardDuck : Duck {
        public MallardDuck() {
            FlyBehavior = new FlyWithWings();
            QuackBehavior = new QuackLoud();
        }
    }
}