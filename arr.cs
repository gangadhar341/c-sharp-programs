using System;
class List{
   int[] a;
   int size,n;
   public List(int size=20){
     this.size=size;
	 a=new int[this.size];
	}
	public void ReadElements(int n){
	   this.n=n;
	   Console.WriteLine("Enter Elements: ");
	   for(int i=0;i<n;i++)
	     a[i]=Convert.ToInt32(Console.ReadLine());
	}
	public void InsertElement(int ele,int position){
	  for(int i=n-1;i>=position;i--){
	    a[i+1]=a[i];
	  }
	  a[position]=ele;
	  n++;
    }
    public void DeletePosition(int position){
      for(int i=position;i<n;i++){
          a[i]=a[i+1];
	    }
		n--;
    }
	public int SearchElement(int ele){
	  for(int i=0;i<n;i++)
	    if(a[i]==ele)
		  return i;
	  return -1;
	}
	public void SortList(){
	  for(int i=0;i<n-1;i++)
	    for(int j=i;j<n;j++)
		  if(a[i]>a[j])
		    Swap(i,j);
	}
	public void ReverseList(){
	  for(int i=0,j=n-1;i!=j;i++,j--){
	    Swap(i,j);
	  }
	}
	public void PrintList(){
	  for(int i=0;i<n;i++){
	    Console.WriteLine(a[i]+"\t");
	  }
	  Console.WriteLine();
	}
	void Swap(int i,int j){
	  int temp=a[i];
	  a[i]=a[j];
	  a[j]=temp;
	}
}
class ListDemo{
  static void Main(){
     int size,n=0;
	 Console.WriteLine("Enter the size of the list: ");
	 size=Convert.ToInt32(Console.ReadLine());
	 List l=new List(size);
	 while(true){
	  Console.WriteLine("Enter Operations:\n0.Exit\n1.ReadList\n2.AddElement\n3.DeletePosition\n4.SearchElement\n5.ReverseList\nEnter Your Choice:");
	  int ch=Convert.ToInt32(Console.ReadLine());
	  switch(ch){
	    case 0:Environment.Exit(n);
		       break;
		case 1:Console.WriteLine("Enter no.of Elements:");
		       n=Convert.ToInt32(Console.ReadLine());
			   if(n<=size)
			      l.ReadElements(n);
				  Console.WriteLine("List:");
				  l.PrintList();
				  break;
		case 2:Console.WriteLine("Enter the elements to insert:");
		       int ele=Convert.ToInt32(Console.ReadLine());
			   Console.WriteLine("Enter the position to insert:");
			   int position=Convert.ToInt32(Console.ReadLine());
			   if(position>0&&position<=n&&(n+1)<size)
			     l.InsertElement(ele,position);
				 Console.WriteLine("List after insert:");
				 l.PrintList();
				 break;
		case 3:Console.WriteLine("Enter the position to delete:");
			   position=Convert.ToInt32(Console.ReadLine());
			   if(position>0&&position<=n)
			     l.DeletePosition(position);
				 Console.WriteLine("List after delete:");
				 l.PrintList();
				 break;
		case 4:Console.WriteLine("Enter the elements to search:");
		       ele=Convert.ToInt32(Console.ReadLine());
			   position=l.SearchElement(ele);
			   if(position<0)
			     Console.WriteLine("Element not found");
			   else
			     Console.WriteLine("Element found at:"+position);
			   break;
	    case 5:l.SortList();
		       Console.WriteLine("List after Sort:");
			   l.PrintList();
			   break;
		case 6:l.ReverseList();
		       Console.WriteLine("List after Reverse:");
			   l.PrintList();
			   break;
		}
	}
 }
}
