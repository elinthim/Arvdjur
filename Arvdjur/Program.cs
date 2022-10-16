using System;

namespace Arvdjur
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Animal(); //en variabel som kan innehålla andra variabler inom sig

            //här skapar vi objekt av båda klasserna och anropar metoderna.
            Lion lion = new Lion(); //variabel

            lion.Hunt();
            lion.Makenoise();
            lion.Move();
            lion.Sleep();

            //lion.Makenoise();
            //Console.WriteLine(lion.Name);
            //lion.Name = "Lionel2";
            //Console.WriteLine(lion.Name);

            //Console.ReadKey();            

            Console.WriteLine("");
            Zebra zebra = new Zebra();

            zebra.Sleep();
            zebra.Makenoise();
            zebra.Move();
            zebra.Clean();
          
            Console.WriteLine("");
            Giraff giraff = new Giraff();

            giraff.Sleep();
            giraff.Makenoise();
            giraff.Move();
            giraff.Eaten();

            Console.WriteLine("");
            AsiatiskLion lion2 = new AsiatiskLion();
            lion2.Playwithball();

            lion2.Hunt();
            lion2.Move();
            lion2.Sleep();
            lion2.Makenoise();

            Console.WriteLine("");
            AfrikanskLion lion3 = new AfrikanskLion();
            lion3.Claimbuptree();

            lion3.Hunt();
            lion3.Sleep();
            lion3.Move();
            lion3.Makenoise();
        }
    }
}


