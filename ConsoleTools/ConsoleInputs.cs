namespace ConsoleTools
{
    public static class ConsoleInputs
    {
        public static string ReadString(string prompt = "Entrez votre texte: ")
        {
            Console.Write(prompt);
            return Console.ReadLine();
        }

        public static int ReadInt(string prompt = "Entrez votre entier: ", bool reessayer = true)
        {
            int entier = 0;
            bool success = false;
            do
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                success = int.TryParse(input, out entier);

                if (!success)
                {
                    Console.WriteLine("Entrée invalide.");
                }
            } while(reessayer && !success);

            if (!success)
            {
                throw new Exception("Valeur invalide.");
            }

            return entier;
       }
    }
}
