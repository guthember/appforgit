class Printing
{
    public static void PrintMessage(string message)
    {
        Console.WriteLine($"This is a message from the Printing class: {message}");
    }

    public static void PrintMessageTwice(string message)
    {
        Console.WriteLine(message);
        Console.WriteLine(message);
    }
}