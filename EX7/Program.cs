{ Console.WriteLine("Введите кол-во минут");
    int minutes = Convert.ToInt32(Console.ReadLine());
    int hour = minutes / 60;
    Console.WriteLine($"Кол-во часов:{hour}");
}