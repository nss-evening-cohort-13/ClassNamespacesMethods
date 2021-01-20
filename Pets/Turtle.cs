using System;
namespace ThePetStore.Pets
{
    public class Turtle
    {
        //Properties - Things are externally consumable
        public string Name { get; set; }
        public string Size { get; set; }
        public int Age { get; set; }
        public string Color { get; set; }

        //Fields - internal private things
        private bool _isHungry = true;
        
        //Constructor
        public Turtle(string name, int age)
        {
            Name = name;
            Age = age;
            Console.WriteLine($"This turtle name is {Name} and it's age is {Age}");

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
            else {
                Console.WriteLine($"No occassion...");
            }

            DressUp("Tie");
        }

        //method overloading
        public void Eat() {
            Eat("Pellets");
        }

        private void DressUp(string clothing) {

            Console.WriteLine($"The turtle is wearing a {clothing}");

        }
    }
}
