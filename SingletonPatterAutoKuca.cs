using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton_pattern
{
    public sealed class SingletonPatterAutoKuca
    {
        
            private static SingletonPatterAutoKuca _instanca;
            

            // Lista vozila u inventaru
            private List<Vozilo> inventar = new List<Vozilo>();

            // Privatni konstruktor sprečava instanciranje izvan klase
            private SingletonPatterAutoKuca() { }

            // Metoda za dobijanje instance Singletona
            public static SingletonPatterAutoKuca DohvatiInstancu()
            {
            // Ako postoji instanca vraca tu istancu, ako ne kreira jednu. Ovo se samo jednom izvrsava u programu.
                
                
              if (_instanca == null)
              {
                 _instanca = new SingletonPatterAutoKuca();
              }

               
                return _instanca;
            }

            // Dodavanje vozila u inventar
            public void DodajVozilo(Vozilo vozilo)
            {
                inventar.Add(vozilo);
                Console.WriteLine($"Vozilo {vozilo.Marka} {vozilo.Model} dodato u inventar.");
            }

            // Ažuriranje informacija o vozilu
            public void AzurirajVozilo(int idVozila, Vozilo azuriraneInformacije)
            {
                foreach (var vozilo in inventar)
                {
                    if (vozilo.Id == idVozila)
                    {
                        // azuriraj informacije o vozilu
                        vozilo.Marka = azuriraneInformacije.Marka;
                        vozilo.Model = azuriraneInformacije.Model;
                        vozilo.Godina = azuriraneInformacije.Godina;
                        vozilo.Cena = azuriraneInformacije.Cena;
                        Console.WriteLine($"Informacije o automobilu sa id-em {idVozila} su azurirane.");
                        return;
                    }
                }
                Console.WriteLine($"Vozilo {idVozila} nije pronađeno u inventaru.");
            }

            // Prodaja vozila
            public void ProdajVozilo(int idVozila)
            {
                foreach (var vozilo in inventar)
                {
                    if (vozilo.Id == idVozila)
                    {
                        // Ukloni vozilo iz inventara
                        inventar.Remove(vozilo);
                        Console.WriteLine($"Vozilo {idVozila} prodato.");
                        return;
                    }
                }
                Console.WriteLine($"Vozilo {idVozila} nije pronađeno u inventaru.");
            }
      
    }
}
