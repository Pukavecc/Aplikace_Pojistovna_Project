using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacePojistovna
{
    internal class EvidencePojistencu
    {
        /// <summary>
        /// Kolekce pojištěnců
        /// </summary>
        private List<Pojistenec> pojistenci;
        /// <summary>
        /// Konstruktor evidence pojištěnců
        /// </summary>
        public EvidencePojistencu()
        {
            pojistenci = new List<Pojistenec>();
        }
        /// <summary>
        /// Metoda která umožnuje vypisovat pojištěnce i přesto že je list privátní.
        /// </summary>
        public IEnumerable<Pojistenec> Pojistenci
        {
            get { return pojistenci.ToArray(); }
        }
        /// <summary>
        /// Metoda pro přidání pojištěnce.
        /// </summary>
        /// <param name="pojistenec"></param>
        public void PridejPojistence(Pojistenec pojistenec)
        {
            pojistenci.Add(pojistenec);
        }
        /// <summary>
        /// Výpis pojištěncu z listu
        /// </summary>
        /// <returns> vrací textový řetězec pojištěncu </returns>
        public override string ToString()
        {
            return string.Join("", pojistenci);
        }









    }
}
