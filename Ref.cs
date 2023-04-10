using System;
class Test{
	public int a;
	public Test(int a){
		this.a=a;
		
	}
}
class SwapDemo{
	public void Swap(ref int n1,ref int n2){
		int temp=n1;
		n1=n2;
		n2=temp;
	}
	public void Swap(ref Test t1,ref Test t2){
		Test temp=t1;
		t1=t2;
		t2=temp;
	}
}
class SwapTest{
	static void Main(){
		Console.WriteLine("Enter two Nummbers:");
		int n1=Convert.ToInt32(Console.ReadLine());
		int n2=Convert.ToInt32(Console.ReadLine());
		SwapDemo sd=new SwapDemo();
		Console.WriteLine("n1="+n1+", n2="+n2);
		sd.Swap(ref n1,ref n2);
		Console.WriteLine("n1="+n1+", n2="+n2);
		Test t1=new Test(10);
		Test t2=new Test(100);
		Console.WriteLine("Before Swap:t1a="+t1.a+", t2.a="+t2.a);
		sd.Swap(ref t1,ref t2);
		Console.WriteLine("After Swap:t1.a="+t1.a+", t2.a="+t2.a);
	}
}