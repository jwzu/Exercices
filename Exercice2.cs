class Program
{
    static void Main()
    {

        //int Code = 0;
        Random random = new Random();
        int CodeSecret = random.Next(1, 20);
        bool codeFound = false;

        do
        {
            Console.WriteLine("Entrez le code secret: ");
            string codeTXT = Console.ReadLine();

            if (CodeSecret < int.Parse(codeTXT))
            {
                Console.WriteLine("[ALERTE] Code trop haut");
            }
            else if (CodeSecret > int.Parse(codeTXT))
            {
                Console.WriteLine("[ALERTE] Code trop bas");

            }
            else if (CodeSecret == int.Parse(codeTXT))
            {
                Console.WriteLine("[BRAVO] Code trouvé");
                codeFound = true;
            }
        } while (!codeFound);
    }
}
