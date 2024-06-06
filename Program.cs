public class Program { 


public abstract class Shape
{
        

    public abstract int Area();
    public abstract int Perimeter();
    
    public override string ToString()
    {
        return $"Area : {Area()} - Perimeter : {Perimeter()} ";
    }
}

public class Rectangle : Shape


{
    public int length { get; set; }
    public int width { get; set; }
    public int AreaOfRectangle { get; set; }
    public int PerimeterOfRectangle { get; set; }
    public Rectangle(int length, int width)
    {
        this.length = length;
        this.width = width;
    }

    
    public override int Area()
    {
        AreaOfRectangle = length * width; 
            return AreaOfRectangle;
    }
    public override int Perimeter()
    {
        PerimeterOfRectangle = (length + width)*2;
            return PerimeterOfRectangle;
    }
    // deyek ki Rectangle ucun spesifik birsey yazmaliyiq, onda override edirik
    public override string ToString()
    {
        return $"Area : {Area()} - Perimeter : {Perimeter()} of Rectangle";
    }
}

//diger classlar ucun ToString eynidi onda parent classdan geleni isledirik
public class Circle : Shape
{
    public int Radius { get; set; }
    public int PerimeterOfCircle { get; set; }
    public int AreaOfCircle { get; set; }
    public Circle(int radius)
    {
        Radius = radius;
    }
    public override int Area()
    {
        AreaOfCircle = 3*Radius*Radius;
            return AreaOfCircle;
    }
    public override int Perimeter()
    {
        PerimeterOfCircle = 2 * 3 * Radius;
            return PerimeterOfCircle;
    }
    public override string ToString()
    {
        return base.ToString();
    }



}

public class Square : Shape
{
    public int LengthOfTheSide { get; set; }
    public int PerimeterOfSquare { get; set; }
    public int AreaOfTheSquare { get; set; }
    public Square(int lengthOfTheSide)
    {
        LengthOfTheSide = lengthOfTheSide;
        
    }
    public override int Area()
    {
        AreaOfTheSquare = LengthOfTheSide * LengthOfTheSide;
            return AreaOfTheSquare;
    }
    public override int Perimeter()
    {
         PerimeterOfSquare=LengthOfTheSide*4;
            return PerimeterOfSquare;
    }
    public override string ToString()
    {
        return base.ToString();
    }

}
    static void Main(string[] args)
    {
        Square square=new Square(2);
        Console.WriteLine(square);
        Rectangle rectangle = new Rectangle(2, 4);
        Console.WriteLine(rectangle);
    }
}

