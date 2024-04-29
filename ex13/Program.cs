{ Console.Write("Введите двузначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
int first = number / 10; int second = number % 10;
Console.WriteLine("Первая цифра: " + first);
Console.WriteLine("Вторая цифра: " + second);
}