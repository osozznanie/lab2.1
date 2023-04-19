using System;

class String
{
    protected string value;

    public String(string val)
    {
        value = val;
    }

    public int Length()
    {
        return value.Length;
    }

    public void Print()
    {
        Console.WriteLine(value);
    }
}