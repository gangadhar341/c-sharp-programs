using System;

class List{
	int[] a;
	int size,n;
	public List(int size=0){
		this.size=size;
		a= new int[this.size];
	}
	public void ReadElements(int n){
		this.n=n;
		Console.WriteLine("Enter Elements:");
		for(int i=0;i<n;i++)
			a[i]=Convert.ToInt32(Console.ReadLine());
	}
	public void InsertElement(int ele,int Position){
		for(int i=n-1;i>=Position;i--){
			a[i+1]=a[i];
		}
		a[Position]=ele;
		n++;
	}
	public void DeletePosition(int Position){
		for(int i=Position;i<n;i++){
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
					swap(i,j);
	}
	public void ReverseList(){
		for(int i=0,j=n-1;i!=j;i++,j--){
			swap(i,j);
		}
	}
	public void PrintList(){
		for(int i=0;i<n;i++){
			Console.Write(a[i]+"\t");
		}
		Console.WriteLine();
	}
	void swap(int i,int j){
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
		List l= new List(size);
		while(true){
			Console.WriteLine("List of Operration:\n0. Exit\n1.ReadList\n2.AddElement\n3.DeletePosition\n4.SearchElement\n5.SortList\n6.ReverseList\nEnter Your Choice:");
			int ch=Convert.ToInt32(Console.ReadLine());
			switch(ch){
				case 0:Environment.Exit(0);
						break;
				case 1:Console.WriteLine("Enter nO.of Elements:");
						n=Convert.ToInt32(Console.ReadLine());
						if(n<=size)
							l.ReadElements(n);
						    Console.WriteLine("List:");
						    l.PrintList();
						    break;
				case 2:Console.WriteLine("Enter Element to Insert:");
						int ele=Convert.ToInt32(Console.ReadLine());
						Console.WriteLine("Enter the Position to Insert:");
						int Position=Convert.ToInt32(Console.ReadLine());
						
						if(Position>0 && Position<=n && (n+1)<size)
							l.InsertElement(ele,Position);
						    Console.WriteLine("List after Insert");
						    l.PrintList();
						    break;
				case 3:Console.WriteLine("Enter the Position to Delete:");
						Position=Convert.ToInt32(Console.ReadLine());
						if(Position>0 && Position<n)
							l.DeletePosition(Position);
						    Console.WriteLine("List after delete:");
						    l.PrintList();
						break;
				case 4:Console.WriteLine("Enter the element to insert:");
						ele=Convert.ToInt32(Console.ReadLine());
						Position=l.SearchElement(ele);
						if(Position<0)
							Console.WriteLine("Element not Found!");
						else
							Console.WriteLine("Element Found at:"+Position);
						    break;
				case 5:l.SortList();
				       Console.WriteLine("List After Sort:");
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
