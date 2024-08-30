using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_alused
{
    internal class Inimene
    {
        public string Nimi { get; set; }
        public string Vanus { get; set; }
    }
    // III. osa OOP
    List<Inimene> inimesed = new List<Inimene>();
    Inimene inimene1 = new Inimene();
    inimene1.Nimi = "Pojotr 1";
    inimene1.Vanus = 352;
    Inimene inimene2 = new Inimene("Jelizaveta");
    inimene2.Vanus = 98;
    Inimene inimene3 = new Inimene("Marina" 18);
    inimesed.Add(inimene1);
    inimesed.Add(inimene2);
    inimesed.Add(inimene3);
    inimesed.Add(NewsStyleUriParser Inimene("Irina",18));
    foreach (Inimene inimene in inimesed)
    {
        Console.WriteLine(inimene.Nimi + " on " + inimene.Vanus)
}
