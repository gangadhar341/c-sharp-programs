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
		Console.WriteLine("Enter elements:");
		for(int i=0;i<n;i++)
			a[i]=Convert.ToInt32(Console.ReadLine());
	}
	public void InsertElements(int ele,int pos){
		for(int i=n-1;i>=pos;i--){
			a[i+1]=a[i];
		}
		a[pos]=ele;
		n++;
	}
	public void DeletePosition(int pos){
		for(int i=pos;i<n;i++){
			a[i]=a[i+1];
		}
		n--;
	}
	public int SearchElement(int ele){
		for(int i=0;i<n;i++){
			if(a[i]==ele)
				return i;
		}
		return -1;
		
	}
	public void SortList(){
		for(int i=0;i<n-1;i++)
			for(int j=1;j<n;j++)
				if(a[i]>a[j])
					Swap(i,j);
	}
	public void ReversList(){
		for(int i=0,j=n-1;i!=j;i++,j--)
			Swap(i,j);
	}
	public void PrintList(){
		for(int i=0;i<n;i++){
			Console.Write(a[i]+"\t");
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
		Console.WriteLine("Enter the size of the list:");
		size=Convert.ToInt32(Console.ReadLine());
		List l=new List(size);
		while(true){
			Console.WriteLine("List Of Operations:\n0.Exit\n1.ReadList\n2.AddElement\n3.DeletePosition\n4.SearchElement\n5.SortList\n6.ReverseList\nEnter Your Choice:");
			int ch=Convert.ToInt32(Console.ReadLine());
			switch(ch){
				case 0:Environment.Exit(0);
						break;
				case 1:Console.WriteLine("Enter no.of Elements:");
						n=Convert.ToInt32(Console.ReadLine());
						if(n<=size)
							l.ReadElements(n);
						Console.WriteLine("List is:");
						l.PrintList();
						break;
				case 2:Console.WriteLine("Enter the  element to insert:");
						int ele=Convert.ToInt32(Console.ReadLine());
						Console.WriteLine("Enter the position:");
						int pos=Convert.ToInt32(Console.ReadLine());
						if(pos>0&&pos<=n&&(n+1)<size)
							l.InsertElements(ele,pos);
						Console.WriteLine("List After insertion:");
						l.PrintList();
						break;
				case 3:Console.WriteLine("Enter the element to delete:" );
						pos=Convert.ToInt32(Console.ReadLine());
						if(pos>0&&pos<n)
							l.DeletePosition(pos);
						Console.WriteLine("List After Deletion:");
						l.PrintList();
						break;
				case 4:Console.WriteLine("Enter Element to search:");
						 ele=Convert.ToInt32(Console.ReadLine());
						pos=l.SearchElement(ele);
						if(pos<0)
							Console.WriteLine("Element is not found:");
						else
							Console.WriteLine("Element found at position:"+pos);
						break;
				case 5:l.SortList();
						Console.WriteLine("After Sorting the List is:");
						l.PrintList();
						break;
				case 6:l.ReversList();
						Console.WriteLine("After Reversing the List is:");
						l.PrintList();
						break;
		}
	}
}}