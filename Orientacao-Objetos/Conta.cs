class Conta
{
    //private int numero;
    
    public int Numero {get;set;}
    
    //private double saldo = 100;

    public double Saldo{get; private set;}
    private Cliente titular;

    public bool Saca(double valor)
    {
        if(this.Saldo >= valor)
        {
            this.Saldo -= valor;
            Console.WriteLine($"Saque realizado com sucesso, valor na conta: {this.Saldo}");
            return true;
        }
        else
        {
            Console.WriteLine($"Saque Insuficiente, valor na conta: {this.Saldo}");
            return false;
        }
    }

    public void Deposita(double valor)
    {
        this.Saldo += valor;
    }


    public void Transfere(double valor, Conta destino)
    {
        if(this.Saca(valor))
        {   
           this.Deposita(valor);
        }
    }

    public double PegaSaldo()
    {
        return this.Saldo;
    }

    /*
    public void ColocaNumero(int numero)
    {
        this.numero = numero;
    }
    */
}