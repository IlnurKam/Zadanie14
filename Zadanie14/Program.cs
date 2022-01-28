using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework14
{
    abstract class Animal
    {
        public abstract void Say();
        public void ShowInfo()
        {
            Console.WriteLine(GetType().Name);
        }
    }
    class Cat : Animal
    {
        public override void Say()
        {
            Console.WriteLine("Мррр-рр-р");
        }

    }
    class Dog : Animal
    {
        public override void Say()
        {
            Console.WriteLine("А-у-у-у-у-у-у!");
        }
    }

    class Pets
    {
        public void Fire(Animal animal)
        {
            animal.Say();
        }

        public void CheckInfo(Animal animal)
        {
            animal.ShowInfo();
        }
        class Program
        {
            static void Main(string[] args)
            {
                Pets pets = new Pets();
                Animal[] inventory = { new Cat(), new Dog() };
                foreach (var item in inventory)
                {
                    pets.CheckInfo(item);
                    pets.Fire(item);
                    Console.WriteLine();
                }

            }
        }
    }
}