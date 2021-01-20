using System;
using ThePetStore.Pets;

namespace ThePetStore
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            //Turtle turtle1 = new Turtle("Mertle", 72);
            //turtle1.Eat();
            //turtle1.Eat("Lettuce");
            //turtle1.ShowTime("bar-mitzvah");


            Scorpion scorpion = new Scorpion("Steven");
            scorpion.Attack();
            //Console.WriteLine($"{turtle1.Name} is {turtle1.Age } years old. {turtle1.Size}");
        }
    }
}
