using System;
using ThePetStore.Pets;

namespace ThePetStore
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            var babyTurtle = new Turtle("Jim");
            Turtle turtle = new Turtle("Mertle", 72);
            Console.WriteLine(turtle.Description);
            turtle.Eat();
            turtle.Eat("Lettuce");
            turtle.ShowTime("bar-mitzvah");
            turtle.ShowTime("birthday");
            babyTurtle.ShowTime("birthday");

            Scorpion scorpion = new Scorpion("Steven");
            scorpion.Attack();
            //Console.WriteLine($"{turtle1.Name} is {turtle1.Age } years old. {turtle1.Size}");
            Console.ReadLine();
        }
    }
}
