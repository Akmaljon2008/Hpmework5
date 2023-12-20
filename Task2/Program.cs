


var r1 = new Rectangle();
Console.Write("width = ");
r1.Width = Convert.ToInt32(Console.ReadLine());
Console.Write("height = ");
r1.Height = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Area = {r1.GetArea()}");

class Rectangle
{
    public int  Width;
    public int Height;

    public int GetArea(){
        return Width * Height;
    }
}