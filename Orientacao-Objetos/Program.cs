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

Cliente victor = new Cliente();
victor.nome = "victor";

Conta umaConta = new Conta();
umaConta.titular = victor;

umaConta.titular.rg = "12345678-9";


Console.WriteLine(umaConta.titular.nome);
Console.WriteLine(victor.rg);