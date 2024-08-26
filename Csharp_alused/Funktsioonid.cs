using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// &&-and, !-not, ||=or
namespace Csharp_alused
{
    internal class Funktsioonid
    {
        public static void Tere(string nimi)
        {
            Console.WriteLine("Tere kallis {0}", nimi);
        }

        public static int Liitmine(int arv1, int arv2)
        {
            return arv1 + arv2;
        }
        //Loo Arvuta() funktsioon, mis sõltub 3 parameetrist: tehe, arv1, arv2. Kasuta if konstruktsioon. Tulemus kuva ekraanile.
        public static int Arvuta(char tehe, int arv1, int arv2)
        {
            if (tehe == '+')
            {
                return arv1 + arv2;
            }
            else
            {
                return arv1 - arv2;
            }
            
        }
        //Kui eesnimi on Juku siis lähme Jukuga kinno. Lisa valiku, kus Juku vanuse alusel otsustate mis pilet talle vaja osta.
        public static string Juku(string nimi, int vanus, string pilet)
        {
            if (nimi == "Juku")
            {
                if (vanus < 6)
                {
                    pilet = "tasuta";
                }
                else if (vanus <= 6 && vanus <= 14)
                {
                    pilet = "lastepilet";
                }
                else if (vanus <= 15 && vanus <= 65)
                {
                    pilet = "täispilet";
                }
                else if (vanus > 65)
                {
                    pilet = "sooduspilet";
                }
                else if (vanus > 100 || vanus < 0)
                {
                    pilet = "viga andmetega";
                }
                return pilet;
            }
            else
            {
                pilet = "vale nimi";
                return pilet;

            }
        }
        // Küsi kahe inimese nimed ning teata, et nad on täna pinginaabrid




    }
}
