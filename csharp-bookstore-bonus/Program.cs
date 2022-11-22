namespace csharp_bookstore_bonus {
    internal class Program {
        static void Main(string[] args) {
            string? titolo, autore, isbn;
            int? numeroPagine, peso, numeroRecensioni;
            float? altezza, larghezza, profondita, valutazioneMedia;
            bool esisteKindle, esisteRigido;

            KeepLoopingInput("Inserisci il titolo: ", "Questo titolo non va bene!\nInserisci il titolo: ", out titolo);
            KeepLoopingInput("Inserisci l'autore: ", "Questo autore non va bene!\nInserisci l'autore: ", out autore);
            isbn = System.Console.ReadLine();
            numeroPagine = int.Parse(System.Console.ReadLine());
            peso = int.Parse(System.Console.ReadLine());
            altezza = float.Parse(System.Console.ReadLine());
            larghezza = float.Parse(System.Console.ReadLine());
            profondita = float.Parse(System.Console.ReadLine());
            valutazioneMedia = float.Parse(System.Console.ReadLine());
            numeroRecensioni = int.Parse(System.Console.ReadLine());
            esisteKindle = bool.Parse(System.Console.ReadLine());
            esisteRigido = bool.Parse(System.Console.ReadLine());

            string testoDaMostrare = $@"
--------------- IL LIBRO DI OGGI: {titolo} di {autore} ----------------
Informazioni generiche:
ISBN: {isbn}
Numero delle pagine: {numeroPagine} pagine
Peso del libro: {(Single)peso / 1000} kg
Dimensioni del libro: {altezza} cm x {larghezza} cm x {profondita} cm

Informazioni Amazon:
Numero di recensioni: {numeroRecensioni} recensioni
Valutazione media: {valutazioneMedia} stelline
Kindle disponibile: {(esisteKindle ? "Si" : "No")}
Copertina flessibile disponibile: {(esisteRigido ? "Si" : "No")}
------------------------------------------------------------------------------------
";

            System.Console.WriteLine(testoDaMostrare);

        }

        static string KeepLoopingInput(string message, string errorMessage) {
            System.Console.WriteLine(message);
            string? testo = System.Console.ReadLine();
            while (testo?.Length < 1 || testo == null) {
                System.Console.WriteLine(errorMessage);
                testo = System.Console.ReadLine();
            }

            return testo;
        }

        static void KeepLoopingInput(string message, string errorMessage, out string testo) {
            System.Console.WriteLine(message);
            testo = System.Console.ReadLine() ?? "";
            while (testo?.Length < 1 || testo == null) {
                System.Console.WriteLine(errorMessage);
                testo = System.Console.ReadLine() ?? "";
            }
        }
    }
}