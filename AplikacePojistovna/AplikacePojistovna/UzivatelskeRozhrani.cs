using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacePojistovna
{
    internal class UzivatelskeRozhrani
    {

        //Zde bude uživatelský vstup .. Zadání jména, přijmení a telefoního čísla 


        /// <summary>
        /// Metoda pro získání jména
        /// </summary>
        /// <returns> vrací jméno osoby </returns>
        public string ZiskejJmeno()
        {
            string jmeno = "";
            while (jmeno.Length < 3)
            {
                Console.Write("Zadejte jméno:");
                jmeno = Console.ReadLine().Trim();
                if (jmeno.Length < 3)
                {
                    Console.WriteLine("jméno musí mít víc jak 2 znaky");
                }
            }
            jmeno = char.ToUpper(jmeno[0]) + jmeno.Substring(1).ToLower();
            return jmeno;

        }
        /// <summary>
        /// Metoda pro získání příjmení
        /// </summary>
        /// <returns> vrací příjmení osoby </returns>
        public string ZiskejPrijmeni()
        {
            string prijmeni = "";
            while (prijmeni.Length < 3)
            {
                Console.Write("Zadejte příjmení:");
                prijmeni = Console.ReadLine().Trim();
                if (prijmeni.Length < 3)
                {
                    Console.WriteLine("Příjmení musí mít víc jak 2 znaky");
                }
            }
            prijmeni = char.ToUpper(prijmeni[0]) + prijmeni.Substring(1).ToLower();
            return prijmeni;
        }
        /// <summary>
        /// Metoda na získání věku
        /// </summary>
        /// <returns>Vrací věk</returns>
        public int ZiskejVek()
        {
            int vek;
            Console.Write("Zadejte věk:");
            while (!int.TryParse(Console.ReadLine(), out vek))
                    Console.WriteLine("Neplatné číslo, zadejte prosím znovu:");
            return vek;
        }
        /// <summary>
        /// Metoda na získání telefonního čísla
        /// </summary>
        /// <returns>Vrací telefonní číslo</returns>
        public string ZiskejTelefonniCislo()
        {
            string cislo = "";
            int pozice0 = (int)'0';
            int pozice9 = (int)'9';
            while (cislo.Length != 9)
            {
                Console.Write("Zadejte telefonní číslo bez předvolby a bez mezer: ");
                cislo = Console.ReadLine().Trim();
                string noveCislo ="";
                if (cislo.Length == 9)
                {
                    //Kontrola uživatele jestli zadal jenom čísla
                    foreach (char c in cislo)
                    {
                        int znak = (int)c;
                        if (znak >= pozice0 && znak <= pozice9)
                        {
                            noveCislo += c;
                        }
                    }
                    //Pokud nezadal jenom čísla objeví se chybová hláška
                    if (noveCislo.Length != 9)
                    {
                        Console.WriteLine("nezadal jsi číslo!");
                    }
                }
                else
                {
                    Console.WriteLine("Telefonní číslo musí obsahovat pouze čísla a velikost musí být 9!!");
                }
                cislo = noveCislo;
                
            }
            //Formátování výstupu čísla XXX XXX XXX
            cislo = cislo.Insert(3, " ").Insert(7, " ");
            return cislo;
        }



    }
}
