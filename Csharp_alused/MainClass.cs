using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_alused
{
    public class MainClass
    {
        public static void Main(string[] args)
        {
            //I.osa Andmetüübid, Alamfunktsioonid
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Hello, World!");
            string nimetus = "Python";
            Console.WriteLine("Hello, {0}",nimetus);
            Funktsioonid.Tere(nimetus);
            Console.Write("Śisesta esimine arv: ");

            int a = int.Parse(Console.ReadLine());
            Console.Write("Sisesta teine arv: ");
            int b = int.Parse(Console.ReadLine());
            int vastus=Funktsioonid.Liitmine(a,b);
            Console.WriteLine(vastus);
            double arv = 5.123456;
            vastus=Funktsioonid.Liitmine(a,(int)arv);
            char taht = 'A';
            if (vastus == 0)
            {
                Console.WriteLine(taht);


            }


            else
            {
                Console.WriteLine(vastus);
            }
        }


    }
}
