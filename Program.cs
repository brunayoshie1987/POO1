using System;

namespace POO__1
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBancaria contabancaria = new ContaBancaria();

            contabancaria.agencia = "123";
            contabancaria.conta = "321";
            contabancaria.Nome = "Bruna";
            contabancaria.senha = "123";
            contabancaria.ImprimirSaldo();
           


        }
    }
}
