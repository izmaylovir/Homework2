{
    Console.Write("Введите первое целое число: ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите второе целое число: ");
    int num2 = Convert.ToInt32(Console.ReadLine());
    int sum = num1 + num2;
    int difference = num1 - num2;
    int product = num1 * num2;
    int quotient = (int)num1 / num2;
    Console.WriteLine("Сумма: " + sum);
    Console.WriteLine("Разность: " + difference);
    Console.WriteLine("Произведение: " + product);
    Console.WriteLine("Частное: " + quotient);
}