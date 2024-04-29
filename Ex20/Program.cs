{
    Console.Write("Введите букву: ");
    char letter = Console.ReadKey().KeyChar;   
        char nextLetter = (char)(letter + 1);
        Console.WriteLine("Следующая буква в алфавите: " + nextLetter);  
}