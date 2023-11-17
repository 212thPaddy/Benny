namespace Addition {
    internal class Program {
        static void Main(string[] args) {
            double zahl1;
            double zahl2;
            double erg;
            while (true) {
                try {
                    Console.Write("Zahl1: ");
                    zahl1 = Convert.ToDouble(Console.ReadLine().Trim());
                    break;
                }
                catch (Exception) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Die Eingabe muss eine Zahl sein!");
                    Console.ResetColor();
                }
            }
            while (true) {
                try {
                    Console.Write("Zahl2: ");
                    zahl2 = Convert.ToDouble(Console.ReadLine().Trim());
                    break;
                }
                catch (Exception) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Die Eingabe muss eine Zahl sein!");
                    Console.ResetColor();
                }
            }

            erg = zahl1 + zahl2;
            Console.WriteLine("Ergebnis: " + erg);

        }
    }
}
