namespace Program;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите 1 число: ");
        double first = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите 2 число: ");
        double second = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"**Результат: {first + second}**");

    }
}
