public class DadosClientes
{
    public string Email {get;private set;}

    public void ClienteEmail(string cliente)
    {
        this.Email = cliente.Substring(6,15);
    }
}