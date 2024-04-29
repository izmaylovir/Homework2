{
    
Console.WriteLine("Введите количество дней:");
int days = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество часов:");
int hours = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество минут:");
int minutes = Convert.ToInt32(Console.ReadLine());
int totalMinutes = days * 24 * 60 + hours * 60 + minutes;
Console.WriteLine($"Общее количество минут: {totalMinutes}");
    }