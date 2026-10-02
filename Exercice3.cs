class Program
{
    static void Main()
    {
        int totalWeight = 0;
        int objHigher = 0;
        int objLower = 0;
        int MaxWeight = 30;
        Console.WriteLine("How many obj you want to store ?");
        int nbObj = int.Parse(Console.ReadLine());

        for (int i = 0; i < nbObj; i++)
        {
            Console.WriteLine($"Weight of object {i + 1} ?");
            int weight = int.Parse(Console.ReadLine());
            totalWeight = totalWeight + weight;

            if (weight > 5)
            {
                objHigher = objHigher + 1;
            }
            else
            {
                objLower = objLower + 1;
            }

            Console.WriteLine($"Total weight is {totalWeight} | Heavy obj are {objHigher} | lighter obj are : {objLower} ");

        }

        if (totalWeight > MaxWeight)
        {
            Console.WriteLine("[OVERLAODED] Too heavy");
        }
        else
        {
            Console.WriteLine("[OK] Inventory ready");
        }

    }
}
