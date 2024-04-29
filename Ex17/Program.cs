{ Console.Write("Введите количество рублей: ");
int rubles = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите курс покупки доллара: ");
    int buydollar = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите комиссию банка в рублях: ");
int bankcommission = Convert.ToInt32(Console.ReadLine());
 int dollars = (rubles - bankcommission) / buydollar;
    Console.WriteLine("Получено долларов: " + dollars);
}