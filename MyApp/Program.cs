// See https://aka.ms/new-console-template for more information

if (args.Length == 1 && int.TryParse(args[0], out int count))
{
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine($"i = {i + 1}");
    }
}
else
{
    Console.WriteLine("Please provide an integer argument for the number of times to print a value!");
}    