using bytebank.Modelos.ADM.Funcionarios;
using bytebank_ATENDIMENTO.bytebank.Atendimento;
using bytebank_GeradorChavePix;

Console.WriteLine("Boas Vindas ao ByteBank, Atendimento.");
new ByteBankAtendimento().AtendimentoCliente();

Console.WriteLine(GeradorPix.GetChavePix());

//public class Estagiario : Funcionario
//{
//    public Estagiario(double salario, string cpf) : base(salario, cpf)
//    {
//    }

//    public override void AumentarSalario()
//    {
//        // implementação;
//    }

//    protected override double getBonificacao()
//    {
//        // implementação;
//        return 0;
//    }
//}
