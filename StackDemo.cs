using System;
class _Stack{
	int[] stack;
	int tos;
	public _Stack(){
		stack=new int[20];
		tos=-1;
	}
	public void Push(int ele){
		stack[++tos]=ele;
		Console.WriteLine("The Element: "+ ele +" is placed at tos");
	}
	public int Pop(){
		return stack[tos--];
	}
}
class StackDemo{
	static void Main(){
		_Stack s = new _Stack();
		for(int i=0;i<10;i++)
			s.Push(i+1);
		for(int i=0;i<10;i++)
			Console.WriteLine("The element at the tos is : "+s.Pop());
	}
}