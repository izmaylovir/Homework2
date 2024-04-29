{
    Console.Write("Введите букву: ");
    char letter = Console.ReadKey().KeyChar;
    int code = (int)letter;
    Console.WriteLine();
    Console.WriteLine("Код введенной буквы: " + code);
}