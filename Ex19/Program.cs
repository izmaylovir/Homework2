Console.Write("Введите ширину параллелепипеда: ");
double width = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите длину параллелепипеда: ");
double length = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите высоту параллелепипеда: ");
double height = Convert.ToDouble(Console.ReadLine());
double volume = width * length * height;
Console.WriteLine("Объем параллелепипеда: " + volume);