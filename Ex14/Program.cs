{ Console.Write("Введите ширину прямоугольника: ");
 double width = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите длину прямоугольника: ");
 double length = Convert.ToDouble(Console.ReadLine());
 double perimeter = 2 * (width + length);
 double area = width * length;
Console.WriteLine("Периметр прямоугольника: " + perimeter);
Console.WriteLine("Площадь прямоугольника: " + area);
}
