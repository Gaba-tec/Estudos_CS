namespace GeneralValidation
{
	public static class Class1
	{
		public static string ValidaCpf(string cpf)
		{
			if(cpf != null)
			{
				return cpf;
			}
			else
			{
				return "Cpf invalido";
			}
		}
	}
}