using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace CaixaEletronico
{
    public class Conta
    {
        public double Saldo = 0;


        public void MostrarSaldo()
        {
            Console.WriteLine($"Seu saldo atual é: R$ {Saldo.ToString("C")}");
            Console.WriteLine("Digite qualquer tecla para seguir...");
            Console.ReadKey();
        }
        public  void Depositar(double deposito)
        {
            if (deposito > 0)
            {
                Saldo += deposito;
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Valor depositado: " + deposito.ToString("C"));
                Console.ResetColor();
                Console.WriteLine("Saldo atual: " + this.Saldo.ToString("C"));
                Console.WriteLine("Digite qualquer tecla para seguir...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Valor invalido para deposito.");
                Console.ReadKey();
            }
            
        }
        public void Sacar(double saque)
        {
            if(this.Saldo >= saque)
            {
                this.Saldo -= saque;

                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Valor sacado: " + saque.ToString("C"));
                Console.ResetColor();
                Console.WriteLine("Saldo atual: " + this.Saldo.ToString("C"));
                Console.WriteLine("Digite qualquer tecla para seguir...");
                Console.ReadKey();
            }
            else if (saque < 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Valor invalido.");
                Console.ResetColor();
                Console.WriteLine("Digite qualquer tecla para seguir...");
                Console.ReadKey();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Saldo insuficiente.");
                Console.ResetColor();
                Console.WriteLine("Digite qualquer tecla para seguir...");
                Console.ReadKey();
            }
        }

    }
}
