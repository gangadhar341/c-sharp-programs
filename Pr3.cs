using System;
class SumOfNumbers{
	int sum(params int[] args ){
		int result=0;
		foreach(int n in args){
			result+=n;
		}
		return result;
	}
	static void Main(){
		SumOfNumbers s=new SumOfNumbers();
		Console.WriteLine("Enter three values:");
		int n1=Convert.ToInt32(Console.ReadLine());
		int n2=Convert.ToInt32(Console.ReadLine());
		int n3=Convert.ToInt32(Console.ReadLine());
		
		Console.WriteLine("Sum of one argument is:"+s.sum(n1));
		Console.WriteLine("Sum of two argument is:"+s.sum(n1,n2));
		Console.WriteLine("Sum of  three argument is:"+s.sum(n1,n2,n3));
	}
}
