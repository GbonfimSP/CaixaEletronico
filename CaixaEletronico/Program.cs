//Projeto pessoal caixa eletronico.
using CaixaEletronico;

bool loop = true;
Conta MinhaConta = new();

while (loop) 
{
    Console.Clear();
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("><><><><><><><><><><><><><><><><><><><><><><><><");
    Console.WriteLine("\n\n\n\t\tCaixa Eletrônico\n\n\n");
    Console.WriteLine("><><><><><><><><><><><><><><><><><><><><><><><><\n");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine($"[{(int) menu.Saldo}] - Ver saldo");
    Console.WriteLine($"[{(int) menu.Deposito}] - Depositar dinheiro");
    Console.WriteLine($"[{(int) menu.Saque}] - Sacar dinheiro");
    Console.ResetColor();
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine($"[{(int) menu.Sair}] - Sair");
    Console.ResetColor();

    try { 
        Console.Write("Escolha uma opção: ");
        int opcao = Convert.ToInt32(Console.ReadLine());
       

        switch (opcao)
        {
            case (int) menu.Saldo:
                MinhaConta.MostrarSaldo();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n><><><><><><><><><><><><><><><><><><><><><><><><");
                Console.ResetColor();
                break;
            case (int)menu.Deposito:

                Console.WriteLine("Digite valor para deposito:");
                double deposito = Convert.ToDouble(Console.ReadLine());
                MinhaConta.Depositar(deposito);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n><><><><><><><><><><><><><><><><><><><><><><><><");
                Console.ResetColor();

                break;
            case (int)menu.Saque:
                Console.WriteLine("Quanto deseja sacar? ");
                double saque = Convert.ToDouble(Console.ReadLine());
                MinhaConta.Sacar(saque);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n><><><><><><><><><><><><><><><><><><><><><><><><");
                Console.ResetColor();
                break;
            case (int)menu.Sair:
                Console.WriteLine("Muito obrigado! Volte sempre.");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\n><><><><><><><><><><><><><><><><><><><><><><><><");
                Console.ResetColor();
                loop = false;
                break;
            default:
                Console.WriteLine("Opção invalida.");
                break;
        }
    } catch (FormatException)
    {
        Console.WriteLine("Por favor, digite um numero valido.");
    }
    Console.WriteLine();

    
    

}
public enum menu
{
    Saldo = 1,
    Deposito,
    Saque,
    Sair
}