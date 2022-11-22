namespace csharp_bookstore {
    internal class Program {
        static void Main(string[] args) {
            string titolo, autore, isbn;
            int numeroPagine, peso, numeroRecensioni;
            float altezza, larghezza, profondita, valutazioneMedia;
            bool esisteKindle, esisteRigido;

            titolo = "Clean Code: A Handbook of Agile Software Craftsmanship";
            autore = "Robert C. Martin";
            isbn = "978-0132350884";
            numeroPagine = 431;
            peso = 800;
            altezza = 23.37f;
            larghezza = 17.78f;
            profondita = 2.79f;
            valutazioneMedia = 4.7f;
            numeroRecensioni = 4572;
            esisteKindle = true;
            esisteRigido = true;

            string testoDaMostrare = $@"
--------------- IL LIBRO DI OGGI: {titolo} di {autore} ----------------
Informazioni generiche:
ISBN: {isbn}
Numero delle pagine: {numeroPagine} pagine
Peso del libro: {(Single)peso/1000} kg
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
    }
}