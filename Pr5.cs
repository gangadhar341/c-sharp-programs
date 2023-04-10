using System;
class Person{
	private string name;
	public string  Name{
		get{
			return name;
		}
		set{
			name=value;
		}
	}
	class Pr5{
		static void Main(){
			Person p=new Person();
			p.Name="ALG";
			Console.WriteLine(p.Name);
			Console.WriteLine(p.Name);
		}
	}
	
}