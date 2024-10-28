using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacePojistovna
{
    internal class Pojistovna
    {
        /// <summary>
        /// Instance evidence pojištěnců
        /// </summary>
        EvidencePojistencu evidence;
        /// <summary>
        /// Instance uživatelského rozhraní
        /// </summary>
        UzivatelskeRozhrani uzivatelskeRozhrani;
        /// <summary>
        /// Konstruktor pojistovny
        /// </summary>
        public Pojistovna()
        {
            evidence = new EvidencePojistencu();
            uzivatelskeRozhrani = new UzivatelskeRozhrani();
        }
        /// <summary>
        /// Metoda hlavního menu (vzhled)
        /// </summary>
        public void VytiskniMenu()
        {
            Console.Clear();
            Console.WriteLine("Pojišťovna");
            Console.WriteLine("-------------------------------------------------------");
            Console.WriteLine("- 1: Přidání pojištěnce:");
            Console.WriteLine("- 2: Vyhledání pojištěnce:");
            Console.WriteLine("- 3: Vypsání všech pojištěnců");
            Console.WriteLine("- 4: Konec");
            Console.WriteLine("-------------------------------------------------------\n");
        }
        /// <summary>
        /// Metoda pro pokračování libovolnou klávesnicí 
        /// </summary>
        public void PokracovaniLibovolnouKlavesou()
        {
            Console.WriteLine("Pokračujte libovolnou klávesou...");
            Console.ReadKey();
        }
        /// <summary>
        /// bool atribut pokracovani nastaven na true
        /// </summary>
        private bool pokracovat = true;

        // zde se vše odehrává
        public void Spust()
        {
            while (pokracovat)
            {
                VytiskniMenu();
                char volba = Console.ReadKey(true).KeyChar;
                switch (volba)
                {
                    case '1':
                        evidence.PridejPojistence(new Pojistenec(uzivatelskeRozhrani.ZiskejJmeno(),
                                                                 uzivatelskeRozhrani.ZiskejPrijmeni(),
                                                                 uzivatelskeRozhrani.ZiskejVek(),
                                                                 uzivatelskeRozhrani.ZiskejTelefonniCislo()));
                        Console.WriteLine("");
                        Console.WriteLine(evidence.Pojistenci.Last());
                        PokracovaniLibovolnouKlavesou();
                        break;
                        
                    case '2':
                        string hledaneJmeno = uzivatelskeRozhrani.ZiskejJmeno();
                        string hledanePrijmeni = uzivatelskeRozhrani.ZiskejPrijmeni();

                        var osoba = evidence.Pojistenci
                            .Where(p => p.Jmeno.Equals(hledaneJmeno, StringComparison.OrdinalIgnoreCase) &&
                            p.Prijmeni.Equals(hledanePrijmeni, StringComparison.OrdinalIgnoreCase))
                            .FirstOrDefault();

                        if (osoba != null)
                        {
                            Console.WriteLine("Nalezena osoba: " + osoba);
                        }
                        else
                        {
                            Console.WriteLine("Osoba s jménem " + hledaneJmeno + " a příjmením " + hledanePrijmeni + " nebyla nalezena.");
                        }
                        PokracovaniLibovolnouKlavesou();
                        break;

                    case '3':
                        Console.WriteLine(evidence);
                        PokracovaniLibovolnouKlavesou();
                        break;

                    case '4':
                        pokracovat = false;
                        break;

                    default:
                        Console.WriteLine("Nevybral sis správnou možnost");
                        PokracovaniLibovolnouKlavesou();
                        break;

                        
                }
                
                

            }


        }

    }
}
