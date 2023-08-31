Conta c = new Conta();
c.numero = 1;
c.titular = "Gabriel";
c.saldo = 100;
c.saldo -= 50;

Console.WriteLine(c.Saca(30));

c.Deposita(70);