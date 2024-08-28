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
            Console.OutputEncoding = Encoding.UTF8;
            string[] nimed = new string[5] {"Anna","Inna","Oksana","Pavel","Karl"};
            //1
            for (int i = 0; i < nimed.Length; i++)
            {
                Console.WriteLine(nimed[i]);
            }
            //2
            foreach (string nimi in nimed)
            {
                Console.WriteLine(nimi);
            }
            //3
            int n = 0;
            while (n < nimed.Length)
            {
                Console.WriteLine(nimed[n]);
                n++;
            }
            for (int i = 0; i < 7; i++)
            {
                Random random = new Random();
                int paev_nr = random.Next(-4, 30);
                string paeva_nimetus = Funktsioonid.Paevad(paev_nr);
                Console.WriteLine("Päeva nr: {0}. See on {1}", paev_nr, paeva_nimetus);
            }
            //4
            do
            {
                Console.WriteLine(nimed[n-1]);
                n--;
            } while (n > 0);
            //I.osa Andmetüübid, Alamfunktsioonid
            try
            {                            
                Console.WriteLine("Mis on sinu pikkus?");
                double pikkus = Double.Parse(Console.ReadLine());
                string vastus1 = Funktsioonid.Pikkuse_analuus(pikkus);
                Console.WriteLine("Sinu pikkus on {0}, sa oled {1}", pikkus, vastus1);
            }
            catch (Exception e)
            {

                Console.Write(e.ToString());
            }
            

           



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
