using System;
class Add3Numbers{
	int Add(int a,int b=0,int c=0){
		return a+b+c;
	}
	static void Main(){
		Add3Numbers a= new Add3Numbers();
		Console.WriteLine("Addition is : "+a.Add(10));
	}
}