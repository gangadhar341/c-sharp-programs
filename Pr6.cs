using System;
interface Shape1{
	double Area();
}
interface Shape2:Shape1{
	double Circumference();
}
class Circle:Shape2{
	int r;
	public Circle(int r){
		this.r=r;
	}
	public double Area(){
		return 3.14*r*r;
	}
	public double Circumference(){
		return 2*3.14*r;
	}
}
class Pr6{
	static void Main(){
		Console.WriteLine("Enter Circle Radius:");
		Circle c = new Circle(Convert.ToInt32(Console.ReadLine()));
		Console.WriteLine("Area:"+c.Area());
		Console.WriteLine("Circumference:"+c.Circumference());
	}
}
	
