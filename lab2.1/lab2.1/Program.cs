class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hey, homie! Give me a string: ");
        string s = Console.ReadLine();

        Console.WriteLine("And now give me a character to obliterate from that string: ");
        char c = Console.ReadLine()[0];

        Console.WriteLine(" ");
        Console.WriteLine("↓");
        Console.WriteLine(" ");

        DigitalString ds = new DigitalString(s);
        Console.Write("This is your string, bruh: ");
        ds.Print();
        Console.WriteLine("Its length is: " + ds.Length());

        Console.WriteLine(" ");
        Console.WriteLine("↓");
        Console.WriteLine(" ");

        if (s.IndexOf(c) >= 0)
        {
            string removed = ds.Remove(c);
            Console.WriteLine($"After obliterating '{c}', this is what remains: {removed}");
            Console.WriteLine("Its length is: " + ds.Length());
            ds.GetData();
        }
        else
        {
            Console.WriteLine($"Sorry, the character '{c}' does not exist in the string.");
        }
    }
}