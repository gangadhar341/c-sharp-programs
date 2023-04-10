using System;
class Swap{
   static void Main(){
	int a,b;
	Console.WriteLine("Enter Any Two Numbers:");
	a=Convert.ToInt32(Console.ReadLine());
	b=Convert.ToInt32(Console.ReadLine());

	a=a^b;
	b=a^b;
	a=a^b;

	Console.WriteLine("After Swapping:"+a+" "+b);
}
}