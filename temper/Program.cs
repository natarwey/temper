class Program
{
    static void Main()
    {
        Console.Write("Введите количество дней ");
        int days = int.Parse(Console.ReadLine());

        if (days < 3)
        {
            Console.WriteLine("Введите температуру больше чем за три дня ");
            return;
        }

        int[] temp = new int[days];

        for (int i = 0; i < days; i++)
        {
            Console.Write($"Введите температуру за {i + 1}-й день ");
            temp[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 1; i < days - 1; i++)
        {
            if (temp[i] > temp[i - 1] && temp[i] > temp[i + 1])
            {
                Console.WriteLine($"day {i + 1} : {temp[i]} (max)");
            }
            else if (temp[i] < temp[i - 1] && temp[i] < temp[i + 1])
            {
                Console.WriteLine($"day {i + 1} : {temp[i]} (min)");
            }
        }
    }
}