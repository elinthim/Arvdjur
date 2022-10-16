using System;

namespace Arvdjur
{
    class Zebra : Animal
    {

        protected string Bath { get; set; }

        //constructor
        public Zebra()
        {
            this.Name = "Zebroza";
            this.Sound = "iaiaiaiaia";
            this.Gender = "Zebran är en hona";                     // animal constructors
            this.Typeofanimal = "Zebran är ett hästtdjur";
            this.Age = 8;


        }
        public void Clean()
        {
            Bath = "Zebran har tagit ett bad";
            Console.WriteLine(Bath);             //metod property
        }
    }
}