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

}