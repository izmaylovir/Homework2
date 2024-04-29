{ Console.Write("Введите необходимое количество долларов: ");
    double dollars = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите курс покупки доллара: ");
    double buydollars = Convert.ToDouble(Console.ReadLine());
    Console.Write("Введите комиссию банка в рублях: ");
    double bankcommission = Convert.ToDouble(Console.ReadLine());
    double rubles = dollars * buydollars + bankcommission;
    Console.WriteLine("Необходимо рублей: " + rubles);
}