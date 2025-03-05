// See https://aka.ms/new-console-template for more information
String name = askUserAboutTheirName();
Console.WriteLine("Hello, " + name);
Console.WriteLine("...");
Console.WriteLine("Goodbye, " + name);

static String askUserAboutTheirName()
{
    Console.WriteLine("What`s your name?");
    return Console.ReadLine();
}