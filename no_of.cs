using System;
class SumOfNums{
	int sum(params int[] args){
		int res=0;
		foreach(int n in args){
			res+=n;
		}
		return res;
	}
	static void Main(){
		SumOfNums s = new SumOfNums();
		Console.WriteLine("Sum is
		: "+s.sum());
		Console.WriteLine("Sum is: "+s.sum(2));
		Console.WriteLine("Sum is: "+s.sum(1,2,3,4));
	}
}