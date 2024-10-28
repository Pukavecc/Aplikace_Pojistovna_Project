using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplikacePojistovna
{
    /// <summary>
    /// Reprezentuje osobní údaje pojištěnce.
    /// </summary>
    class Pojistenec
    {
        /// <summary>
        /// Jméno pojištěnce.
        /// </summary>
        public string Jmeno { get; private set; }
        /// <summary>
        /// Přijmení pojištěnce.
        /// </summary>
        public string Prijmeni { get; private set; }
        /// <summary>
        /// Telefonní číslo pojištěnce.
        /// </summary>
        public string TelefonniCislo { get; private set; }
        /// <summary>
        /// Věk
        /// </summary>
        public int Vek {  get; private set; }
        /// <summary>
        /// Inicializuje nového pojištěnce s danými osobními údaji.
        /// </summary>
        /// <param name="jmeno">Jméno pojištěnce.</param>
        /// <param name="prijmeni">Příjmení pojištěnce.</param>
        /// <param name="telefonniCislo">Telefonní číslo pojištěnce.</param>
        public Pojistenec(string jmeno, string prijmeni, int vek, string telefonniCislo)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Vek = vek;
            TelefonniCislo = telefonniCislo;
        }
        /// <summary>
        /// Vrací řetězec osobních údajů pojištěnce.
        /// </summary>
        /// <returns>vrací jméno, přijmení a telefonní číslo.</returns>
        public override string ToString()
        {
            return Jmeno.PadRight(15) + Prijmeni.PadRight(15) + Vek.ToString().PadRight(5) + TelefonniCislo.PadLeft(15) + "\n" ;
        }
    }
}
