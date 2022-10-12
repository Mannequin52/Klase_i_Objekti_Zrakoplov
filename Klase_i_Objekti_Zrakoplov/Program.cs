using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klase_i_Objekti_Zrakoplov
{
    class Program
    {
        static void Main(string[] args)
        {

            /*Definirajte klasu Zrakoplov sa sljedećim članicama:
            privatne varijable:
            Naziv, SnagaMotora, DosegLeta
            konstruktor:
            Zrakoplov(string, double, int)
            Konstruktor treba definirati pripadajuće varijable članice s vrijednostima proslijeđenih
            argumenata.
            Definirajte objekt x380 tipa Zrakoplov sa sljedećim podacima:
            naziv Airbus, snaga motora 2000 kW, doseg leta 6000 km.
            Definirajte objekt C162 tipa Zrakoplov sa sljedećim podacima:
            naziv Cessna Skycatcher, snaga motora 75 kW, doseg leta 870 km.
            Definirajte objekt PC-21 tipa Zrakoplov sa sljedećim podacima:
            naziv Pilatus, snaga motora 1200 kW, doseg leta 1333 km

*/
            //instanciranje objekta 1

            Zrakoplov zrakoplov = new Zrakoplov();
            zrakoplov.SetNaziv("Airbus");
            zrakoplov.SetDosegLeta(6000);
            zrakoplov.SetSnagaMotoraU_kW(2000);

            Console.WriteLine("Zrakoplov x380:");
            Console.WriteLine(zrakoplov.Ispis());

            //instanciranje objekta 2
            Zrakoplov zrakoplov2 = new Zrakoplov("Cessna Skycatcher",870,75);

            Console.WriteLine("Zrakoplov C162:");
            Console.WriteLine(zrakoplov2.Ispis());

            //instanciranje objekta 3
            Zrakoplov zrakoplov3 = new Zrakoplov("Pilatus",1333,1200);

            Console.WriteLine("Zrakoplov C162:");
            Console.WriteLine(zrakoplov2.Ispis());

            Console.ReadKey();
        }


    }

    class Zrakoplov
    {

        //svojstva
        string naziv;
        int dosegLeta;
        double snagaMotoraU_kW;

        //metode

        //set metode
        public void SetNaziv(string naziv)
        {
            this.naziv = naziv;
        }
        public void SetDosegLetaUKma(int dosegLetaUKm)
        {
            this.dosegLeta = dosegLetaUKm;
        }
        public void SetSnagaMotoraU_kW(double snagaMotoraU_kW)
        {
            this.snagaMotoraU_kW = snagaMotoraU_kW;
        }

        //get metode - čitanje vrijednosti svojstava

        public string GetNaziv()
        {
            return this.naziv;
        }
        public int GetDosegLeta()
        {
            return this.dosegLeta;
        }
        public double GetSnagaMotoraU_kW()
        {
            return this.snagaMotoraU_kW;
        }

        //metode za ispis
        public string Ispis()
        {
            string ispis = ("Naziv: " + this.GetNaziv()
                    + "\r\nDosegLeta:" + this.GetDosegLeta() + "Km"
                    + "\r\nSnagaMotora:" + this.GetSnagaMotoraU_kW() + "kW"
                    );
            return ispis;
        }
        //konstruktori

        public Zrakoplov()
        {

        }

        public Zrakoplov(string naziv, int dosegLeta, double snagaMotoraU_kW)
        {
            this.naziv = naziv;
            this.dosegLeta = dosegLeta;
            this.snagaMotoraU_kW = snagaMotoraU_kW;

        }


    }
}