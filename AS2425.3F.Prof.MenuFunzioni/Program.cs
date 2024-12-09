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
                        RadiceQuadrata();
                        break;
                }

            } while (scelta != 9);
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
        }
    }
}
