namespace Adresserfassung {
    internal class Program {
        static void Main(string[] args) {
            String name;
            String vorname;
            String plz = "";
            String ort;
            DateTime gebdat;
            int schuhgrosse;

            Console.Write("Name: ");
            name = Console.ReadLine().Trim();
            Console.Write("Vorname: ");
            vorname = Console.ReadLine().Trim();
            bool check = true;
            while (check) {
                Console.Write("PLZ: ");
                plz = Console.ReadLine().Trim();
                //5 Zeichen
                // Zeichen 0-9
                check = CheckPLZ(plz);
            }
            Console.Write("Ort: ");
            ort = Console.ReadLine().Trim();
            while (true) {
                try {
                    Console.Write("Geburtsdatum: ");
                    gebdat = Convert.ToDateTime(Console.ReadLine().Trim());

                    if (gebdat >= DateTime.Today) {
                        throw new Exception();
                    }
                    break;
                }
                catch (Exception) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Das Datum muss in der Vergangenheit liegen!");
                    Console.ResetColor();
                }
            }
            while (true) {
                try {
                    Console.Write("Schuhgröße: ");
                    schuhgrosse = Convert.ToInt32(Console.ReadLine().Trim());

                    if (schuhgrosse <= 0) {
                        throw new Exception();
                    }
                    break;
                }
                catch (Exception) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Die Schugröße muss eine Zahl größer 0 sein!");
                    Console.ResetColor();
                }
            }

            Console.WriteLine("-----------------");
            Console.WriteLine($"{name}, {vorname}, {plz}, {ort}");
            Console.WriteLine($"{gebdat.ToShortDateString()}, {schuhgrosse}");
        }

        private static bool CheckPLZ(string plz) {
            bool check = false;
            if (plz.Length == 5) {

                foreach (Char c in plz) {
                    if (!Char.IsDigit(c)) {
                        check = true;
                        break;
                    }
                }
                if (check == true) {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Die PLZ darf nur aus Zahlen bestehen!");
                    Console.ResetColor();
                    return check;
                }
            }
            else {
                check = true;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Die PLZ muss 5 Zeichen lang sein!");
                Console.ResetColor();
                return check;

            }
            return check;
        }
    }
}

