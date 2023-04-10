using System;
class RefOut{
	public void Ref(int a,int b,ref int c,ref int d){
		c=a+b;
		d=a*b;
	}
	public void Out(int a,int b,out int c,out int d){
		c=a-b;
		d=a/b;
	}
}
class RefOutDemo{
	static void Main(){
		int m,n;
		RefOut rf=new RefOut();
		
		Console.WriteLine("Enter two value for Ref&Out: ");
		
		m=Convert.ToInt32(Console.ReadLine());
		n=Convert.ToInt32(Console.ReadLine());
		
		int p=0,q=0;
		rf.Ref(m,n,ref p,ref q );
		Console.WriteLine("Using Ref Key Word:" );
		Console.WriteLine(p+" "+q);
		
		int x,y;
		
		rf.Out(m,n,out  x,out  y);
		Console.WriteLine("Using Out Key Word: ");
		Console.WriteLine(x+" "+y);
		
		
		
	}
}