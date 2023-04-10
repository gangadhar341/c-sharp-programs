using System;
class TwoDArrayMultiply{
   static void Main(){
	   
       Console.WriteLine("Enter size of dimension 1 and dimension 2 of array 1:");
	   
       int[,] a= new int[Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine())];
       Console.WriteLine("Enter size of dimension 1 and dimension 2 of array 2:");
       int[,] b= new int[Convert.ToInt32(Console.ReadLine()),Convert.ToInt32(Console.ReadLine())];
       int[,] c=new int[a.GetUpperBound(0)+1,b.GetUpperBound(1)+1];
       Console.WriteLine("Enter array 1 elements:");
       for(int i=0;i<=a.GetUpperBound(0);i++){
          for(int j=0;j<=a.GetUpperBound(1);j++){		  
              Console.Write("enter row{0} col{1} :",i+1,j+1);
              a[i,j]=Convert.ToInt32(Console.ReadLine());
          }
	   }
       Console.WriteLine("Enter array 2 elements:");
       for(int i=0;i<=b.GetUpperBound(0);i++){
          for(int j=0;j<=b.GetUpperBound(1);j++){
             Console.Write("enter row{0} col{1} :",i+1,j+1);
             b[i,j]=Convert.ToInt32(Console.ReadLine());
          }
        }
		Console.WriteLine("Matrix after multiplication :");
       for(int i=0;i<=a.GetUpperBound(0);i++){
          for(int j=0;j<=b.GetUpperBound(1);j++){
              c[i,j]=0;
             for(int k=0;k<=b.GetUpperBound(0);k++){
                 c[i,j]+=a[i,k]*b[k,j];
             }
          Console.Write(c[i,j]+"\t");
          }
        Console.WriteLine();
        }
       
}
}