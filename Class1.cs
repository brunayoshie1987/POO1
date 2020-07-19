using System;
using System.Collections.Generic;
using System.Text;

namespace POO__1
{
    class ContaBancaria

    {
        public string conta { get; set; }
        public string agencia{get; set; }

        internal void ImprimirSaldo()
        {
            throw new NotImplementedException();
        }

        public string Nome { get; set; }
        public string senha { private get; set; }
        private int Saldo;

        public ContaBancaria(int saldo)
        {
            Saldo = saldo;
        }

        public ContaBancaria()
        {
        }

        public void Depositar(int valor)
        {
            Saldo = Saldo + valor;
        }

        public void Sacar(int valor)
        {
            Saldo = Saldo - valor;
        }

        public int ConsultarSaldo()
        {
            int taxa = 10;
            int valortaxa = (Saldo * taxa) / 100;
            return Saldo = valortaxa;
        }

        public void ImprimirSaldo (int saldo)
        {
            Console.WriteLine($"O saldo da sua conta {conta} na agencia {agencia} é: {ConsultarSaldo()}");
        }     

        

    
    }
}
