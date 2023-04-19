using Microsoft.VisualBasic;

class DigitalString : String
{
    public DigitalString(string value) : base(value) { }

    public string Remove(char c)
    {
        string result = "";
        for (int i = 0; i < value.Length; i++)
        {
            if (value[i] != c)
            {
                result += value[i];
            }
        }
        value = result;
        return value;
    }

    public void GetData()
    {
        Console.WriteLine($"Value: {value}, Length: {Length()}");
    }
}
