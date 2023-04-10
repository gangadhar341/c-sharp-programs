using System;
class Pr1{
	static void Main(){
		Console.WriteLine("TwoDArray Multiplication:");
		int r1,r2,c1,c2,i,j,k;
		int[,] a;
		int[,] b;
		int[,] c;
		
		Console.WriteLine("Enter first Matrix Dimensions(row&col):");
		r1=Convert.ToInt32(Console.ReadLine());
		c1=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter second Matrix Dimensions(row&col):");
		r2=Convert.ToInt32(Console.ReadLine());
		c2=Convert.ToInt32(Console.ReadLine());
		Console.WriteLine("Enter first Matrix Elements:");
			
			 a=new int[r1,c1];
			 b=new int[r2,c2];
			 c=new int[r1,c2];
			 
			for(i=0;i<r1;i++){
				for(j=0;j<c1;j++){
					a[i,j]=Convert.ToInt32(Console.ReadLine());
				}
			}
			Console.WriteLine(" first Matrix is:");
			for(i=0;i<r1;i++){
				for(j=0;j<c1;j++){
					Console.Write(a[i,j]+"\t");
				}
				Console.WriteLine();
			}
			
			
			Console.WriteLine("Enter second Matrix Elements:");
			for(i=0;i<r2;i++){
				for(j=0;j<c2;j++){
					b[i,j]=Convert.ToInt32(Console.ReadLine());
				}
			}
			Console.WriteLine(" second Matrix is:");
			for(i=0;i<r2;i++){
				for(j=0;j<c2;j++){
					Console.Write(b[i,j]+"\t");
				}
				Console.WriteLine();
			}
			if(c1==r2){
		    Console.WriteLine("After Multiplication:");
			for(i=0;i<r1;i++){
				for(j=0;j<c2;j++){
					c[i,j]=0;
					for(k=0;k<r2;k++){
						c[i,j]+=(a[i,k]*b[k,j]);
					}
					
				}
				Console.Write(c[i,j]+" ");
			}
			Console.WriteLine();
		}
		else
			Console.WriteLine("Matrix Multiplication is not posible:");
	}
}