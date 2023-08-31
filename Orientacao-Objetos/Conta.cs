class Conta
{
    public int numero;
    public string titular = "";
    public double saldo = 100;


    public bool Saca(double valor)
    {
        if(this.saldo >= valor)
        {
            this.saldo -= valor;
            Console.WriteLine($"Saque realizado com sucesso, valor na conta: {this.saldo}");
            return true;
        }
        else
        {
            Console.WriteLine($"Saque Insuficiente, valor na conta: {this.saldo}");
            return false;
        }
    }

    public void Deposita(double valor)
    {
        this.saldo += valor;
    }
}