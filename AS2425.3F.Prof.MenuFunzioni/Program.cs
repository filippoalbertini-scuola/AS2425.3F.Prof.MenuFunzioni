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
                        break;
                    case 2: // Dato un numero indicarne la radice quadrata
                        break;
                }

            } while (scelta != 9);
        }
    }
}
