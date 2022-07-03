Console.WriteLine("Select a Shape:");
Console.WriteLine("1.Circle");
Console.WriteLine("2.Triangle");
Console.WriteLine("3.Square");
Console.WriteLine("4.Rectangle");
int x=Convert.ToInt32(Console.ReadLine());
switch (x) 
{
    case 1:
        {
            Circle circle = new Circle();
            Console.WriteLine("Enter Z radius:");
            //double r=Convert.ToDouble(Console.ReadLine());
            //Circle circle = new Circle(r);
            circle._rad = Console.ReadLine();    
            
            Console.WriteLine("Calculate:");
            Console.WriteLine("1.Area");
            Console.WriteLine("2.Perimeter");
            int i = Convert.ToInt32(Console.ReadLine());
                    switch (i) 
                    {
                        case 1:
                           {
                        Console.WriteLine("The Area of the Circle is:"+circle.area());
                            break;
                           }
                        case 2:
                           {
                        Console.WriteLine("The Circumference of the Circle is:" + circle.perimeter());
                        break;
                           }
                    }
            break;
        }
    case 2:
        {
            Triangle triangle = new Triangle();
            Console.WriteLine("Assuming Right angle triangle!");
            Console.WriteLine("Enter Side A,B,C respectively:");
            //double A = Convert.ToDouble(Console.ReadLine());
            //double B = Convert.ToDouble(Console.ReadLine());
            //double C = Convert.ToDouble(Console.ReadLine());
            //Triangle triangle = new Triangle(A,B,C);
            triangle._A = Console.ReadLine();
            triangle._B = Console.ReadLine();
            triangle._C = Console.ReadLine();

            Console.WriteLine("Calculate:");
            Console.WriteLine("1.Area");
            Console.WriteLine("2.Perimeter");
            int i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1:
                    {
                        Console.WriteLine("The Area of the Triangle is:" + triangle.area());
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("The Perimeter of the Triangle is:" + triangle.perimeter());
                        break;
                    }
            }
            break;
        }
    case 3:
        {
            Square square = new Square();
            Console.WriteLine("Enter Z length:");
            //double l=Convert.ToDouble(Console.ReadLine());
            //Square square = new Square(l);
            square._w = Console.ReadLine();

            Console.WriteLine("Calculate:");
            Console.WriteLine("1.Area");
            Console.WriteLine("2.Perimeter");
            int i = Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1:
                    {
                        Console.WriteLine("The Area of the Square is:" + square.area());
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("The Perimeter of the Square is:" + square.perimeter());
                        break;
                    }
            }
            break;
        }
    case 4: 
        {
            Rectangle rectangle = new Rectangle();
            Console.WriteLine("Enter length and width respectively:");
            //double l= Convert.ToDouble(Console.ReadLine());
            //double w=Convert.ToDouble(Console.ReadLine());
            //Rectangle rectangle = new Rectangle(l,w);
            rectangle._l = Console.ReadLine();
            rectangle._w = Console.ReadLine();

            Console.WriteLine("Calculate:");
            Console.WriteLine("1.Area");
            Console.WriteLine("2.Perimeter");
            int i=Convert.ToInt32(Console.ReadLine());
            switch (i)
            {
                case 1:
                    {
                        Console.WriteLine("The Area of the Rectangle is:" + rectangle.area());
                        break;
                    }
                case 2:
                    {
                        Console.WriteLine("The Perimeter of the Rectangle is:" + rectangle.perimeter());
                        break;
                    }
            }
            break;
        }
}





abstract class Shape {
    abstract public Double area();
    abstract public Double perimeter();

}
class Circle : Shape
{
    //public string rad { set; get; } = "";
    private string rad = " ";
    public string _rad
    {
        get { return rad; }        
        set { rad = value; }    
    }
    //Double r = Convert.ToDouble(rad);
    /*public Circle(double r) 
    { 
        this.r = r;
    }*/
    
    public override Double area()
    {
         return 3.14 * (Convert.ToDouble(rad)* Convert.ToDouble(rad));
    }

    public override Double perimeter()
    {
        return 2 * (3.14 * Convert.ToDouble(rad));
    }
}
class Triangle : Shape
{
    private string A = " ";
    public string _A
    {
        get { return A; }
        set { A = value; }
    }
    private string B = " ";
    public string _B
    {
        get { return B; }
        set { B = value; }
    }
    private string C = " ";
    public string _C
    {
        get { return C; }
        set { C = value; }
    }
    // Double a,b,c;
    //double semiperimeter;
    /*public  Triangle(double a , double b , double c ) 
    { 
        this.a= a;
        this.b= b;
        this.c= c;  
        //semiperimeter= a+b+c/2;
        //this.h = Math.Sqrt(semiperimeter*((semiperimeter-a)*(semiperimeter-b)*(semiperimeter-c)));  
    }*/
    public override double area()
    {
        return Convert.ToDouble(A) * Convert.ToDouble(B) / 2; 
    }

    public override double perimeter()
    {
        return Convert.ToDouble(A) + Convert.ToDouble(B) + Convert.ToDouble(C);
    }
}
class Square : Shape
{
    private string w = " ";
    public string _w
    {
        get { return w; }
        set { w = value; }
    }
    //Double w;

    /*public Square(double w) 
    {
        this.w = w;
    }*/

    public override double area()
    {
        return Convert.ToDouble(w) * Convert.ToDouble(w);
    }

    public override double perimeter()
    {
        return 4 * Convert.ToDouble(w);
    }
}
class Rectangle : Shape
{
    private string l = " ";
    public string _l
    {
        get { return l; }
        set { l = value; }
    }
    private string w = " ";
    public string _w
    {
        get { return w; }
        set { w = value; }
    }
    //Double l, w;

    /*public Rectangle(double l , double w) 
    {
        this.l = l;
        this.w = w;
    }*/
    public override double area()
    {
        return Convert.ToDouble(l) * Convert.ToDouble(w);   
    }

    public override double perimeter()
    {
        return 2* Convert.ToDouble(l) + 2* Convert.ToDouble(w);
    }
}

