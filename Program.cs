namespace QUARTOESERCIZIO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creazione di 5 persone
            PERSONA persona1 = new PERSONA("Mario", "Rossi", "Via Roma 123", "RSSMRA80A01H501Z", 3426644560, "mario.rossi@example.com");
            PERSONA persona2 = new PERSONA("Giovanni", "Bianchi", "Via Milano 456", "BNCGNN85B01H501X", 2345678901, "giovanni.bianchi@example.com");
            PERSONA persona3 = new PERSONA("Laura", "Verdi", "Via Torino 789", "VDRLRA90A01H501Y", 3456789012, "laura.verdi@example.com");

            // Stampa dei dati delle persone
            Console.WriteLine($"I dati anagrafici delle Persona 1 sono: {persona1.Nome1} {persona1.Cognome1}, {persona1.Indirizzo1}, {persona1.CodiceFiscale1}, {persona1.NumeroTelefono1}, {persona1.Email1}");
            Console.WriteLine($"I dati anagrafici delle Persona 2 sono: {persona2.Nome1} {persona2.Cognome1}, {persona2.Indirizzo1}, {persona2.CodiceFiscale1}, {persona2.NumeroTelefono1}, {persona2.Email1}");
            Console.WriteLine($"I dati anagrafici delle Persona 3 sono: {persona3.Nome1} {persona3.Cognome1}, {persona3.Indirizzo1}, {persona3.CodiceFiscale1}, {persona3.NumeroTelefono1}, {persona3.Email1}");

            Console.WriteLine();

            persona1.ControlloNomeProprietari();
            Console.WriteLine(persona1.ControlloCodiceFiscaleProprietari());
            Console.WriteLine(persona2.ControlloCodiceFiscaleProprietari());
            Console.WriteLine(persona3.ControlloCodiceFiscaleProprietari());

            Console.WriteLine();

            // Creazione di 3 macchine
            AUTOMOBILE auto1 = new AUTOMOBILE("Volvo", "600GBT", "BV145LK", persona1);
            AUTOMOBILE auto2 = new AUTOMOBILE("BMW", "700GBT", "NM36ULK", persona2);
            AUTOMOBILE auto3 = new AUTOMOBILE("Ferrari", "600GBT", "BNP36HG", persona3);

            // Stampa dei dati delle macchine
            Console.WriteLine($"Le infomazioni dell'Auto 1 sono: {auto1.NomeMacchina1} {auto1.ModelloMacchina1} {auto1.TargaMacchina1} e il Proprietario è: {auto1.Proprietario1.Nome1} {auto1.Proprietario1.Cognome1} ");
            Console.WriteLine($"Le infomazioni dell'Auto 2 sono: {auto2.NomeMacchina1} {auto2.ModelloMacchina1} {auto2.TargaMacchina1} e il Proprietario è: {auto2.Proprietario1.Nome1} {auto2.Proprietario1.Cognome1}");
            Console.WriteLine($"Le infomazioni dell'Auto 3 sono: {auto3.NomeMacchina1} {auto3.ModelloMacchina1} {auto3.TargaMacchina1} e il Proprietario è: {auto3.Proprietario1.Nome1} {auto3.Proprietario1.Cognome1} ");

            Console.WriteLine();

            Console.WriteLine(auto1.VerificaTarga());

            auto1.VerificaModello();
        }
    }
}
