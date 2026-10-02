class Program
{
    static void Main()
    {
        int round = 1;
        int BossHealth = 150;
        int PlayerHealth = 100;
        Random rand = new();

        Console.WriteLine("Début du combat:");

        while (true)
        {
            BossHealth = BossHealth - rand.Next(10,25);

            if (BossHealth > 0)    {
                //Console.WriteLine($"Boss is : {BossHealth}");
                PlayerHealth = PlayerHealth - rand.Next(5,10);
                if (PlayerHealth <= 0)
                {
                    Console.WriteLine($"You lose at round : {round}");
                    break;
                }
                else
                {
                    Console.WriteLine($"Player is : {PlayerHealth} and Boss is {BossHealth}");
                }
            }
            else
            {
                Console.WriteLine($"You win at round : {round}");
                break;
            }
            round ++;
            
        }

    }
}
