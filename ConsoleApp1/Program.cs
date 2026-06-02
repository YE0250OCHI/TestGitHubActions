Console.WriteLine("Hello, World!");

ShowConsole(1);


void ShowConsole(int? input)
{
    int value = input.Value;

    Console.WriteLine($"{value}");
}