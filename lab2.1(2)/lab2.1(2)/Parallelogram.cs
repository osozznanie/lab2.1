public class Parallelogram : Line
{
    private int x3;
    private int y3;
    private int x4;
    private int y4;

    public Parallelogram(int x1, int y1, int x2, int y2, int x3, int y3) : base(x1, y1, x2, y2)
    {
        // Check that the points are not collinear
        if ((y2 - y1) * (x3 - x1) == (y3 - y1) * (x2 - x1))
        {
            throw new ArgumentException("Points are collinear");
        }

        // Calculate the fourth point
        this.x3 = x3;
        this.y3 = y3;
        x4 = x3 + x2 - x1;
        y4 = y3 + y2 - y1;
    }

    public int X3
    {
        get { return x3; }
        set { x3 = value; }
    }

    public int Y3
    {
        get { return y3; }
        set { y3 = value; }
    }

    public int X4
    {
        get { return x4; }
        set { x4 = value; }
    }

    public int Y4
    {
        get { return y4; }
        set { y4 = value; }
    }

    public double Diagonal1() => Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));


    public double Diagonal2() => Math.Sqrt(Math.Pow(x4 - x3, 2) + Math.Pow(y4 - y3, 2));

    public double Area() => Math.Abs((x2 - x1) * (y3 - y1) - (x3 - x1) * (y2 - y1));
    
    public double Perimeter() => 2 * (Length() + base.Length());

    public bool IsValid()
    {
        return (x2 - x) * (y3 - y) == (x3 - x) * (y2 - y);
    }
}
