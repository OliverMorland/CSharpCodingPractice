using System;

namespace CodingPractice
{
    public interface Duck
    {
        public void Quack();
        public void Fly();
    }

    public class MaillardDuck : Duck
    {
        void Duck.Fly()
        {
            Console.WriteLine("Flying..");
        }

        void Duck.Quack()
        {
            Console.WriteLine("Quacking...");
        }
    }

    public class RubberDuck : Duck
    {
        public void Fly()
        {
            Console.WriteLine("Cannot Fly.");
        }

        public void Quack()
        {
            Console.WriteLine("Squeaking..");
        }
    }

    public interface Turkey
    {
        public void Gobble();
        public void Fly();
    }

    public class WildTurkey : Turkey
    {
        public void Fly()
        {
            Console.WriteLine("Fly a short distance");
        }

        public void Gobble()
        {
            Console.WriteLine("Gobble...Gobble...");
        }
    }

    public class DuckToTurkeyAdapter : Turkey
    {
        Duck duck;
        public DuckToTurkeyAdapter(Duck _duck)
        {
            duck = _duck;
        }

        public void Fly()
        {
            duck.Fly();
        }
        

        public void Gobble()
        {
            duck.Quack();
        }
    }
}
