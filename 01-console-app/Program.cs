namespace console_app;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("x + y = _");
        Console.WriteLine();

        decimal x = ReadLineNumber("x = ");
        decimal y = ReadLineNumber("y = ");

        Console.WriteLine($"sum = {x + y}");
        Console.WriteLine();
    }

    static decimal ReadLineNumber(string prompt)
    {
        // this is only a little tool, so we only do a little error checking!
        while (true)
        {
            Console.Write(prompt);
            
            string? entry = Console.ReadLine();
            if (decimal.TryParse(entry, out decimal value))
            {
                return value;
            }
        }
    }
}
