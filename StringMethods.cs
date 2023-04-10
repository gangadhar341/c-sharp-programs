using System;
class Lab3{
	
    static void Main(){
        Console.WriteLine("Enter any two strings : ");
        string s="", t="";
        s=Console.ReadLine();
		t=Console.ReadLine();
		Console.WriteLine("Compare() Method :");
		if(string.Compare(s,t)==0){
			Console.WriteLine("Both Strings are equal in alphabetical order");
		}
		else if(string.Compare(s,t)==-1){			
			Console.WriteLine(s+" < "+t+" in alphabetical order");
		}
		else if(string.Compare(s,t)==1){
			Console.WriteLine(s+" > "+t+" in alphabetical order");
		}
		Console.WriteLine("Contains() Method :");
		if(s.Contains(t)){
			Console.WriteLine(s+" contains "+t);
		}
		else{
			Console.WriteLine(s+" doesn't contains "+t);
		}
		Console.WriteLine("Substring() Method :\nSubstring of "+s+" from index 1 to3 is : "+s.Substring(1,3));
		string tr=s+" and "+t;
		Console.WriteLine("Trim() Method :\nBefore Trim : "+tr+"\nAfter Trim :"+tr.Trim('s'));
		Console.WriteLine("ToLower() & ToUpper() Methods :\nGiven String in bothcases :"+s.ToLower()+"\t"+s.ToUpper());
		Console.WriteLine("IndexOf() Method :\nYou wil get the 1st occurence of 'e'in the given string\t"+s.IndexOf("e"));
		Console.WriteLine("LastIndexOf() Method :\nYou wil get the last occurenceof 'l' in the given string\t"+s.LastIndexOf("l"));
		Console.WriteLine("Equals() Method :");
		if(string.Equals("Hola","Hola")){
			Console.WriteLine("Both Hola and Hola are equal strings");
		}
		s=string.Concat(s,".exe");
		t=string.Concat("Hello! ",t);
		Console.WriteLine("Concat() Method\nAfter Concating the given strings:"+s+"\t"+t);
		if(t.StartsWith("Hello! ")){
			Console.WriteLine("StartsWith() Method\n"+t+" is starts with Hello!");
		}
		if(s.EndsWith(".exe")){
			Console.WriteLine("EndsWith() Method\n"+s+" is ends with .exe");
		}
		Console.WriteLine("GetType() Method\nType of "+s+" is "+s.GetType());
		Console.WriteLine("Insert() Method\nInserting '@$' at 0 index to"+s+"\nAfter Inserting '@$' = "+s.Insert(0,"@$"));
		s=s.Insert(0,"@$");
		Console.WriteLine("Remove() Method\nRemoving '@' at 0 index to"+s+"\nAfter Removing '@' = "+s.Remove(0,1));
		s=s.Remove(0,1);
		Console.WriteLine("Replace() Method\nReplacing '$' with '#' at 0 index to"+s+"\nAfter Replacing '$' = "+s.Replace("$","#"));
		Console.WriteLine("ToCharArray() Method :\nConverting String "+t+" into aCharacter Array");
		char[] ch=s.ToCharArray();
		foreach(char c in ch){
			
			Console.Write(c+"\t");
		}
	}
}