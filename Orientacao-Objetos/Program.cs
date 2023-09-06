/*
Conta c = new Conta();
c.numero = 1;
c.titular = "Gabriel";
c.saldo = 100;
c.saldo -= 50;

Console.WriteLine(c.Saca(30));

c.Deposita(70);
*/

/*
Conta victor = new Conta();
Conta guilherme = new Conta();

victor.saldo = 1000;

victor.Transfere(100,guilherme);
*/

/*
Cliente victor = new Cliente();
victor.nome = "victor";

Conta umaConta = new Conta();
umaConta.titular = victor;

umaConta.titular.rg = "12345678-9";


Console.WriteLine(umaConta.titular.nome);
Console.WriteLine(victor.rg);
*/

// TRABALHANDO COM ATRIBUTOS/MÉTODOS PRIVADOS

/*
Conta c = new Conta();
c.Deposita(100);
c.ColocaNumero(212);
Console.WriteLine($"Saldo da conta: {c.PegaSaldo()}");
*/

// TRABALHANDO COM PROPERTIES GET E SET

/*
Conta c = new Conta();
c.ColocaNumero(212);
Console.WriteLine($"O número da conta é: {c.Numero}");
*/

// SIMPLIFICANDO A DECLARAÇÃO DE PROPRIEDADES GET E SET


/*
Conta c = new Conta();

c.Numero = 212;
Console.WriteLine(c.Numero); // Funciona porque minha propriedade foi definida com o Get e o Set publico

//c.Saldo = 0; // Não funciona porque meu set é privado;

c.Deposita(200);
Console.WriteLine(c.Saldo);
*/

//**CONSTRUTORES**

Cliente gabriel = new Cliente("Gabriel")
{
    Cpf = "488.385.408-61",
    Rg = "38.354.068-9",
    Idade = 24
};




