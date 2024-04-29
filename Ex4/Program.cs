{
    Console.WriteLine("Введите вашу фамилию");
    string lastname = Console.ReadLine();
    Console.WriteLine("Введите ваше имя");
    string firstname = Console.ReadLine();
    Console.WriteLine("Введите ваше отчество");
    string patronymic = Console.ReadLine();
    Console.WriteLine($"Привет:{lastname} {patronymic} {lastname}");
}