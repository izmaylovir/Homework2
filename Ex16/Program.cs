{ 
    Console.Write("Введите первое целое число: ");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе целое число: ");
    int number2 = Convert.ToInt32(Console.ReadLine());
    int a = number1;
    number1 = number2;
    number2 = a;
    Console.WriteLine("Первое число после обмена: " + number1);
    Console.WriteLine("Второе число после обмена: " + number2);
}