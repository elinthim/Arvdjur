using System;
using System.Collections.Generic;
using System.Text;

namespace Arvdjur
{
    class AsiatiskLion : Lion
    {
        public AsiatiskLion()
        {
            this.Name = "Asialionore";
            this.Sound = "Roooaaassss liiisss";
            this.Gender = "Lejonet är en hona";
            this.Typeofanimal = "Lejonet är ett kattdjur";
            this.Age = 10;
        }
        public string Ball { get; set; }
        public void Playwithball()
        {
            Ball = "Nu jagar " + Name + " bollen";
            Console.WriteLine(Ball);
        }
    }
}
