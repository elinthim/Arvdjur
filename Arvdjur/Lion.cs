using System;

namespace Arvdjur
{
    class Lion : Animal
    {      
        public string Prey { get; set; }

        //constructor
        public Lion() 
        {
            this.Name = "Lionel";
            this.Sound = "Roooaaarrr";
            this.Gender = "Lejonet är en hane";
            this.Typeofanimal = "Lejonet är ett kattdjur";
            this.Age = 12;
        }
        public void Hunt()
        {
            Prey = "Lejonet har fångat en gasell";
            Console.WriteLine(Prey);
        }  
    }
}

