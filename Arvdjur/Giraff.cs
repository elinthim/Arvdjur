using System;

namespace Arvdjur
{
    class Giraff : Animal
    {
        protected string Eats { get; set; }

        //constructor
        public Giraff()
        {
            this.Name = "Giorffia";
            this.Sound = "nomnomnom";
            this.Gender = "hen";
            this.Typeofanimal = "Giraffen är ett hästtdjur";
            this.Age = 5;

        }
        public void Eaten()
        {
            Eats = "Giraffen har ätit några blad";
            Console.WriteLine(Eats);
        }
    }
}
