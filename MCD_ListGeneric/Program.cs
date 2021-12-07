using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace MCD_ListGeneric
{
    class Program
    {
        static void Main(string[] args)
        {
            //Arraylist Generic versiyonu

            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("bir");

            //<T> : T tipi demek .net framework içerisinde olan veya bizim oluşturduğumuz
            //herhangi bir tip demek.

            List<int> listeGeneric = new List<int>();
            listeGeneric.Add(1);
            listeGeneric.Add(2);

            for (int i = 0; i < listeGeneric.Count; i++)
            {
                Console.WriteLine(listeGeneric[i]);
            }

            List<string> isimler = new List<string>();
            isimler.Add("Gamze");
            isimler.Add("Mutlu");
            isimler.Add("Elif");

            foreach (var item in isimler)
            {
                Console.WriteLine(item);
            }

            List<Musteri> musteriListe = new List<Musteri>();
            musteriListe.Add(new Musteri() { id = 1, isim = "Gamze", soyisim = "Kural" });

            foreach (Musteri item in musteriListe)
            {
                Console.WriteLine(item.isim+item.soyisim+item.id);
            }

            Console.ReadKey();
        }
    }
}
