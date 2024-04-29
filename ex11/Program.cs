{
    Console.Write("Введите первое целое число: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе целое число: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите третье целое число: ");
    int num3 = Convert.ToInt32(Console.ReadLine());
    int sum = num1 + num2 + num3;
    Console.WriteLine("Сумма трех чисел: " + sum);
}