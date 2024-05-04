using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_pattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Kreiraj instancu Singletona
            SingletonPatterAutoKuca SingletonPatterAutoKuca = SingletonPatterAutoKuca.DohvatiInstancu();

            // Dodaj nekoliko vozila u inventar
            SingletonPatterAutoKuca.DodajVozilo(new Vozilo { Id = 1, Marka = "Toyota", Model = "Corolla", Godina = 2022, Cena = 20000 });
            SingletonPatterAutoKuca.DodajVozilo(new Vozilo { Id = 2, Marka = "Honda", Model = "Civic", Godina = 2021, Cena = 18000 });

            // Ažuriraj informacije o vozilu
            SingletonPatterAutoKuca.AzurirajVozilo(1, new Vozilo { Marka = "Toyota", Model = "Camry", Godina = 2023, Cena = 25000 });

            // Prodaj vozilo
            SingletonPatterAutoKuca.ProdajVozilo(2);

            SingletonPatterAutoKuca SingletonPatterAutoKuca1 = SingletonPatterAutoKuca.DohvatiInstancu();
            
            
            //Console.WriteLine(SingletonPatterAutoKuca1 == SingletonPatterAutoKuca);
            Console.ReadLine();
        }
    }

}
