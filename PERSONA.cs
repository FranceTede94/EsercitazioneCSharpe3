using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QUARTOESERCIZIO
{
    internal class PERSONA
    {
        private string Nome;

        private string Cognome;

        private string Indirizzo;

        private string CodiceFiscale;

        private long NumeroTelefono;

        private string Email;

        public PERSONA(string nome, string cognome, string indirizzo, string codiceFiscale, long numeroTelefono, string email)
        {
            Nome = nome;
            Cognome = cognome;
            Indirizzo = indirizzo;
            CodiceFiscale = codiceFiscale;
            NumeroTelefono = numeroTelefono;
            Email = email;
        }


        public string Nome1 { get => Nome; set => Nome = value; }
        public string Cognome1 { get => Cognome; set => Cognome = value; }
        public string Indirizzo1 { get => Indirizzo; set => Indirizzo = value; }
        public string CodiceFiscale1 { get => CodiceFiscale; set => CodiceFiscale = value; }
        public long NumeroTelefono1 { get => NumeroTelefono; set => NumeroTelefono = value; }
        public string Email1 { get => Email; set => Email = value; }


        public void ControlloNomeProprietari()
        {
            if (Nome == "Mario" && Cognome == "Rossi")
            {
                Console.WriteLine(Nome + " " + Cognome);
            }
            else
            {
                Console.WriteLine("Messagio: Nome Errato");
            }

        }

        public string ControlloCodiceFiscaleProprietari()
        {
            // Verifica che il Codice Fiscale sia lungo esattamente 16 caratteri
            if (CodiceFiscale.Length == 16)
            {
                return "Codice Fiscale inserito: ESATTO";
            }
            else
            {
                return "Codice Fiscale ERRATO - Hai inserito più di 16 caratteri";
            }
        }
    }
}
