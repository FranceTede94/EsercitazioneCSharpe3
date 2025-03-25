using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUARTOESERCIZIO
{
    internal class AUTOMOBILE
    {
        private string NomeMacchina;
        private string ModelloMacchina;
        private string TargaMacchina;
        private PERSONA Proprietario;

        public AUTOMOBILE(string nomeMacchina, string modelloMacchina, string targaMacchina, PERSONA proprietario)
        {
            NomeMacchina = nomeMacchina;
            ModelloMacchina = modelloMacchina;
            TargaMacchina = targaMacchina;
            Proprietario = proprietario;
        }

        public string NomeMacchina1 { get => NomeMacchina; set => NomeMacchina = value; }
        public string ModelloMacchina1 { get => ModelloMacchina; set => ModelloMacchina = value; }
        public string TargaMacchina1 { get => TargaMacchina; set => TargaMacchina = value; }
        internal PERSONA Proprietario1 { get => Proprietario; set => Proprietario = value; }

        public string VerificaTarga()
        {

            if (TargaMacchina1 == "BV145LK")
            {
                return "La targa della macchina è corretta";
            }
            else
            {
                return "La targa della macchina non è corretta";
            }
        }

        public void VerificaModello()
        {

            if (ModelloMacchina1 == "600GBT")
            {
                Console.WriteLine("Il modello della macchina è corretto");
            }
            else
            {
                Console.WriteLine("Il modello della macchina non è corretto");
            }
        }
    }
}
