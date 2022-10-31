using System;

class GFG {
	

	static void printPascal(int n)
	{
		

	for (int line = 0; line < n; line++)
	{

		for (int i = 0; i <= line; i++)
		Console.Write(binomialCoeff
						(line, i)+" ");
						
		Console.WriteLine();
	}
	}
	
	static int binomialCoeff(int n, int k)
	{
		int res = 1;
		
		if (k > n - k)
		k = n - k;
			
		for (int i = 0; i < k; ++i)
		{
			res *= (n - i);
			res /= (i + 1);
		}
		return res;
	}
	
	public static void Main()
	{
	int n = 7;
	printPascal(n);
	}
}