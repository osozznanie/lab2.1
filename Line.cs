public class Line : Point
{
    protected int x2;
    protected int y2;
    protected int x1;
    protected int y1;

    public Line(int x1, int y1, int x2, int y2) : base(x1, y1)
    {
        this.x1 = x1;
        this.y1 = y1;
        this.x2 = x2;
        this.y2 = y2;
    }

    public int X2
    {
        get { return x2; }
        set { x2 = value; }
    }

    public int Y2
    {
        get { return y2; }
        set { y2 = value; }
    }

    public double Length() => Math.Sqrt(Math.Pow(x2 - x, 2) + Math.Pow(y2 - y, 2));

}
