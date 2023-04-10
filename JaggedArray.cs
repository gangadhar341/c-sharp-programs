using System;
class JaggedArray{
   static void Main(){
      int flag=1;
      while(flag>0){
		  
          Console.Write("Menu \n1.Jagged Array OneD \n2.Jagged Array TwoD\n0.Exit");
          int c=int.Parse(Console.ReadLine());
          switch(c){
			  
              case 0: flag=0;
			  break;
              case 1:Console.WriteLine("Enter the size of JaggedArray :");
              int n2=int.Parse(Console.ReadLine());
              int[][] ja=new int[n2][];
			  int[] size=new int[n2];
			  for(int i=0; i<n2; i++){
				  Console.WriteLine("Enter the size of row "+(i+1)+":");
				  size[i]=int.Parse(Console.ReadLine());
				  ja[i]=new int[size[i]];
				  Console.WriteLine("Enter row "+(i+1)+"elements :");
                  for(int j=0; j<size[i]; j++){
					  ja[i][j]=int.Parse(Console.ReadLine());
				  }
			   }
			   Console.WriteLine("The elements of JaggedArray are :");
               for(int i=0; i<n2; i++){
				  for(int j=0; j<size[i]; j++){
					 Console.Write(ja[i][j]+"\t");
				  }
				  Console.WriteLine();
				}
				break;
				case 2: 
						Console.WriteLine("Enter the size of JaggedArray 2D:");
						int n3=int.Parse(Console.ReadLine());
						int[][,] ja2=new int[n3][,];
						int[] r=new int[100];
						int[] c2=new int[100];
						for(int i=0;i<n3; i++){
							Console.WriteLine("Enter size of row in row 4"+(i+1)+":");
							  r[i]=int.Parse(Console.ReadLine());
							Console.WriteLine("Enter size of column in row "+(i+1)+":");
							c2[i]=int.Parse(Console.ReadLine());
							ja2[i]=new int[r[i],c2[i]];
							Console.WriteLine("Enter row "+(i+1)+"elements :");
							Console.WriteLine("Enter"+(r[i]*c2[i])+" elements :");
							for(int j=0; j<r[i]; j++){
								for(int k=0; k<c2[i]; k++){
									ja2[i][j,k]=int.Parse(Console.ReadLine());
								}
							}
						}
						Console.WriteLine("The elements of 2D JaggedArray are :");
						for(int i=0; i<n3; i++){
							Console.WriteLine("row "+(i+1)+" :");
							for(int j=0; j<r[i]; j++){
								for(int k=0; k<c2[i]; k++){
									Console.Write(ja2[i][j,k]+"\t");
								}
							Console.WriteLine();
							}
						Console.WriteLine();
						}
						Console.WriteLine();
						break;
						default :Console.WriteLine("Enter only options from 0 to 2");
						break;
					}
		}
    }
}