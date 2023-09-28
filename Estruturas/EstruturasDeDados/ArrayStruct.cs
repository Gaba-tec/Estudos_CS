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

	public List<int> dynamicArray(int n, List<List<int>> queries)
	{
		List<List<int>> list2d = new List<List<int>>();

		List<int> lastAnswers = new List<int>();

		int lastAnswer = 0;

		for(int i = 0; i <= n; i++)
		{
			list2d.Add(new List<int>());
		}

		foreach(List<int> query in queries)
		{
			int type = query[0];
			int x = query[1];
			int y = query[2];
			int idx = (x ^ lastAnswer) % n;
			if(type == 1)
			{
				list2d[idx].Add(y);
			}
			else
			{
				lastAnswer = list2d[idx][y % list2d[idx].Count];
				lastAnswers.Add(lastAnswer);
			}

		}

		return lastAnswers;

	}

}