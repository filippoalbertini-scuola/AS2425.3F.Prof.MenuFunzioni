namespace AS2425._3F.Prof.MenuFunzioni
{
    internal class Program
    {
        /// <summary>
        /// 1) Dati due numeri indicare quale dei due è il maggiore
        /// 2) Dato un numero indicarne la radice quadrata
        /// 9) Uscita
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Prof;3F;09/12;Esempio di menù con funzioni");

            int scelta = 0;

            do
            {
                scelta = Menu();

                switch (scelta)
                {
                    case 1: // Dati due numeri indicare quale dei due è il maggiore
                        MaggioreFraDueNumeri();
                        break;
                    case 2: // Dato un numero indicarne la radice quadrata

                        Console.WriteLine("Inserisci il valore sui cui calcolare la radice quadrata");
                        int numero1 = Convert.ToInt32(Console.ReadLine());

                        double radice = RadiceQuadrata(numero1);

                        Console.WriteLine($"Il risultato del calcolo della radice quadrata è {radice}");

                        break;
                    case 9:
                        Console.WriteLine("Hai scelto di uscire.");
                        break;
                }

            } while (scelta != 9);

            Console.WriteLine("Programma terminato.");
        }

        /// <summary>
        /// Indica all'utente le possibili scelte
        /// </summary>
        static int Menu()
        {
            int scelta = 0;

            Console.WriteLine("Scelte operative :");
            Console.WriteLine("1) Dati due numeri indicare quale dei due è il maggiore");
            Console.WriteLine("2) Dato un numero indicarne la radice quadrata");
            Console.WriteLine("9) Uscita");

            // TODO:  controlla i valori indicati dall'utente
            scelta = Convert.ToInt32(Console.ReadLine());

            return scelta;
        }

        /// <summary>
        /// Dati due numeri indica quale dei due è maggiore
        /// </summary>
        /// <returns></returns>
        static void MaggioreFraDueNumeri()
        {
            Console.WriteLine("Inserisci il primo numero");
            int numero1 = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Inserisci il secondo numero");
            int numero2 = Convert.ToInt32(Console.ReadLine());

            if (numero1 > numero2)
                Console.WriteLine("numero1 è maggiore di numero2");
            else
                Console.WriteLine("numero2 è maggiore/uguale di numero1");
        }

        /// <summary>
        /// Calcola la radice quadrata del numero indicato (intero)
        /// </summary>
        static double RadiceQuadrata(int numero)
        {
            return Math.Sqrt(numero);
        }

    }
}
