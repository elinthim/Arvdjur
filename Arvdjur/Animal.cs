using System;

namespace Arvdjur
{
    class Animal
    {
   
        public string Name { get; set; }
        public string Gender { get; set; }             // 5 egenskaoer  
        public string Sound { get; set; }
        public string Typeofanimal { get; set; }
        public int Age { get; set; }
        public virtual void Makenoise()
        { Console.WriteLine(Sound); }
        public virtual void Sleep()
        {
            Console.WriteLine(Name + " Sover");         // 3 metoder 
        }
        public virtual void Move()
        {
            Console.WriteLine(Name + " Rör sig");
        }
    }
}