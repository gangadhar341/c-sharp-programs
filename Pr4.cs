using System;
abstract class Shapes{
	abstract public double area();
	abstract public double perimeter();
	public void show(string shape){
		Console.WriteLine("====="+shape+"=====");
	}
}

class Circle:Shapes{
	int r;
	public Circle(int r){
		this.r=r;
	}
	public override double area(){
		return 3.14*r*r;
	}
	public override double perimeter(){
		return 2*3.14*r;
	}
	
}

class Rectangle:Shapes{
	int l,b;
	public Rectangle(int l,int b){
		this.l=l;
		this.b=b;
	}
	public override double area(){
		return (l*b);
	}
	public override double perimeter(){
		return 2*(l+b);
	}
	
}

class Pr4{
	static void Main(){
		Console.WriteLine("Enter Circle Radius:");
		Circle c=new Circle(Convert.ToInt32(Console.ReadLine()));
		c.show("Circle");
		Console.WriteLine("Area:"+c.area());
		Console.WriteLine("Perimeter:"+c.perimeter());
		
		Console.WriteLine("Enter Rectangle l&b:");
		int l=Convert.ToInt32(Console.ReadLine());
		int b=Convert.ToInt32(Console.ReadLine());
		Rectangle r=new Rectangle(l,b);
		c.show("Rectangle");
		Console.WriteLine("Area:"+c.area());
		Console.WriteLine("Perimeter:"+c.perimeter());
	}
}