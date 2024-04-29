{
    Console.WriteLine("Введите наименование продукта:");
    string productName = Console.ReadLine();
    Console.WriteLine("Введите количество:");
    int quantity = int.Parse(Console.ReadLine());
    Console.WriteLine("Введите цену:");
    double price = double.Parse(Console.ReadLine());
    Console.WriteLine($"Название: {productName}, кол-во: {quantity}, цена: {price}");
}