// See https://aka.ms/new-console-template for more information
public class ArrayStruct
{
	public List<int> newArr = new List<int>();

	public ArrayStruct() {}

	public void ReverseArr(List<int> a)
	{
		for(int i = a.Count - 1; i >= 0; i--)
		{
			newArr.Add(a[i]);
		}

		foreach(int i in newArr)
		{
			Console.WriteLine(i);
		}
	}

	public void hourglassSum(int[,] arr2d)
	{
		int maiorValor = int.MinValue;
		int soma = 0;

		for(int i = 0; i < arr2d.GetLength(0) - 2; i++)
		{
			for(int j = 0; j < arr2d.GetLength(0) - 2; j++)
			{
				soma = arr2d[i, j] + arr2d[i, j+1] + arr2d[i, j+2] + arr2d[i + 1, j+1] + arr2d[i + 2, j] + arr2d[i + 2, j+1] + arr2d[i + 2, j+2];

				if(soma > maiorValor)
				{
					maiorValor = soma;
				}
			}
			
		}

		Console.WriteLine($"Maior valor {maiorValor}");

	}

}