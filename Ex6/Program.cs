{
    Console.WriteLine("Введите количество километров:");
    int kilometrs = Convert.ToInt32(Console.ReadLine());

    int meters = kilometrs * 1000;
    Console.WriteLine($"Количество метров: {meters}");
}
