using System;
namespace ThePetStore.Pets
{
    public class Turtle
    {
        //Properties - Things are externally consumable
        
        //readonly property -> only be set once and in the constructor/instantiation process
        public string Name { get; }

        //public property with a private setter
        public int Age { get; private set; }

        //readonly property, but can only be calculated/derived
        public string Description => $"{Age} year old {Size}, {Color} turtle";

        //auto-property
        public string Size { get; set; }
        public string Color { get; set; }

        //field backed property
        string _shellPattern = "squares";

        public string ShellPattern
        {
            get { return _shellPattern; }
            set { _shellPattern = value; }
        }


        //Fields - internal private things
        bool _isHungry = true;


        public Turtle(string name) : this(name,0)
        { }

        //Constructor
        public Turtle(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine($"This turtle name is {Name} and it's age is {Age}");

        }

        //method overloading
        public void Eat() {
            Eat("Pellets");
        }

        //Method
        public void Eat(string foodType) {
            if (_isHungry)
            {
                Console.WriteLine($"The turtle stretches their neck out and munches on the {foodType}");
                //_isHungry = false;
            } else
            {
                Console.WriteLine("Shakes it head and says no thank you!");
            }

        }

        public void ShowTime(string occasion) {

            if (occasion != null) {
                Console.WriteLine($"It is a {occasion}!");
            }
            else 
            {
                Console.WriteLine($"No occassion...");
            }

            if (occasion == "birthday")
            {
                Console.WriteLine($"{Name} is now {++Age} years old");
            }

            

            DressUp("Tie");
        }

        private void DressUp(string clothing) {

            Console.WriteLine($"The turtle is wearing a {clothing}");

        }
    }
}
