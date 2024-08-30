using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_alused
{
    internal class ulesanned
    {
        public static void Main(int[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Random random = new Random();
            int N = random.Next(-100, 100);
            int M = random.Next(-100, 100);
            
            int arv = N;
            int[] arvud = new int[M - N];
            while (arv < M)
                arvud[M - N] = arv;
            arv++;


            public static int[] Arvude_massiv(int N, int M)
            {
                int arv;
                int[] arvud = new int[M - N];
                for (int i = N; i < M; i++)
                {
                    Console.WriteLine("{0} nimi :", i + 1);
                    arv = N;
                    arvud[i] = arv;
                    N++;
                }
                return arvud;
            }
            
        
        //mis arv mõtlesin välja arvuti

            int arvutiArv = Random.Next(1, 50);

            int kasutajaArv;
            int katsed;

            while (katsed <5 && !arvatOigesti)
            {
                Console.Write("Sisesta ona arvatav arv: ");
                kasutajaArv = int.Parse(Console.ReadLine());
                katsed++;

                if (kasutajaArv == arvutiArv)
                {
                    Console.WriteLine("Õige! Sa arvasid arvu ära.");
                    arvutasidOigesti = true;
                else if (kasutajaArv < arvutiArv)
                {
                    Console.WriteLine("Liiga väike!");
                }
                else
                {
                    Console.WriteLine("Liiga suur!");
                }
            }  
            if(avutaOigesti=false)

}       //kupi slona
        public static void OstaElevant()
        {
            string kasutajaSissend;
            while kasutajaSissend !=  "elevant"
            {
                Console.WriteLine("Osta elevant!");

                kasutajaSissend = Console.ReadLine();
            }
        }
        // 5 nimed
        public class Kusitused
        {
            int sum = 0;
            int[] vanem = new int[2] { -1, 0 };
            int[] noorem = new int[2] { -1, 0 };
            string[] nimed = new string[5];
            int[] vanused = new int[5];
            public Kusitused()
            
        }

        ArrayList arrayList = new ArrayList();
        arrayList.Add("Esimene");
        arrayList.Add("Teine");
        arrayList.Add("Kolmas");
        Console.WriteLine("Otsing: ");
        string vas = Console.ReadLine();




        List<string> abc = new List<string>();
        try 
	    {
            foreach (string rida in File.Readalllines(@"..\..\..\abc.txt"))
            {
                abc.Add(rida);
            }
	    }
	    catch (Exception)
	    {

		    Console.WriteLine("Fail ei saa leida1");
	    }
        foreach (Exeption)
        {
            
        }
