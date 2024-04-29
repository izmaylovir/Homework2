{Console.Write("Введите температуру в градусах Цельсия: ");
double celsius = Convert.ToDouble(Console.ReadLine());
double fahrenheit = (celsius * 9 / 5) + 32;
Console.WriteLine("Температура в градусах Фаренгейта: " + fahrenheit);}