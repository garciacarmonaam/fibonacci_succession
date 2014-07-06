class Fibonacci {
    static int matrix(int n)
    {
        int[,] M= {{1,0},{0,1}};
        int[,] A= new int[2,2];
        for(int i=0;i<n;i++)
        {
            A[0,0] = M[0,0]*0+M[0,1]*1;
            A[0,1] = M[0,0]*1+M[0,1]*1;
            A[1,0] = M[1,0]*0+M[1,1]*1;
            A[1,1] = M[1,0]*1+M[1,1]*1;
            M[0,0] = A[0,0];
            M[0,1] = A[0,1];
            M[1,0] = A[1,0];
            M[1,1] = A[1,1];
        }
        return  M[0,1];
    }
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine(matrix(n));
    }
}
