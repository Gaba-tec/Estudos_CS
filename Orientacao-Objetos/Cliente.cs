class Cliente
{
    public string Nome{ get; set; }
    public string Cpf{ get; set; }
    public string Rg{ get; set;}
    public string Endereco{ get; set; }
     public int Idade{ get; set;}
    
    public Cliente(string nome)
    {
        this.Nome = nome;
    }

    public Cliente(string nome, int idade)
    {
        this.Nome = nome;
        this.Idade = idade;
    }
}