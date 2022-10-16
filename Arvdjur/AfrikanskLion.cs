using System;
using System.Collections.Generic;
using System.Text;

namespace Arvdjur
{
    class AfrikanskLion : Lion
    {
        public AfrikanskLion()
        {
            this.Name = "Afffro Affe";
            this.Sound = "ROOOAAARRR RROOAARR going to eat you";
            this.Gender = "Lejonet är en hen";
            this.Typeofanimal = "Lejonet är ett kattdjur";
            this.Age = 1;
        }
        public string Climb { get; set; }
        public void Claimbuptree()
        {
            Climb = "Nu klättrar " + Name + " trädet";
            Console.WriteLine(Climb);
        }
    }
}
