// See https://aka.ms/new-console-template for more information
public class ArrayStruct
{
	public List<int> newArr = new List<int>();

	public void ReverseArr(List<int> arr)
	{
		
		for(int i = arr.Count; i > 0; i--)
		{
			newArr[arr.Count - i] = arr[i - 1];
		}

		Console.WriteLine(newArr);
	}

}