using System;
class ChangeValue{
	public void Change(int n1,int n2){
		n1=n1+n2;
		n2=n1-n2;
	}
}
class ChangeRef{
	public void Change(Demo d1){
		d1.rn1=d1.rn1+d1.rn2;
		d1.rn2=d1.rn1-d1.rn2;
	}
}
class Demo{
	public int rn1=100,rn2=200;
	static void Main(){
		ChangeValue cv = new ChangeValue();
		int n1=100,n2=200;
		Console.WriteLine("Before change : \nn1="+n1+", n2="+n2);
		cv.Change(n1,n2);
		Console.WriteLine("After change : \nn1="+n1+", n2="+n2);
		ChangeRef cr =new ChangeRef();
		Demo d=new Demo();
		Console.WriteLine("Before change : \nrn1="+d.rn1+", rn2="+d.rn2);
		cr.Change(d);
		Console.WriteLine("After change : \nrn1="+d.rn1+", rn2="+d.rn2);
	}
	
}