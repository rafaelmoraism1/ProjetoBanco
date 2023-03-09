namespace ExercicioBanco;

public class Conta
{
    public string Id = "";
    public string Nome = "";
    //public long Cpf = 0;
    private decimal Saldo = 0m;
    public Conta(string Id, string Nome)
    {
        this.Id = Id;
        this.Nome = Nome;
        // // this.Cpf = Cpf;
        // Console.WriteLine("-----------------------------------------");
        // Console.WriteLine($" Conta: {Id}\n Nome: {Nome}");
        // Console.WriteLine("-----------------------------------------");
    }

    public void Menu2()
    {
        Console.WriteLine("[1] Extrato ");
        Console.WriteLine("[2] Deposito ");
        Console.WriteLine("[3] Saque ");
        //Console.WriteLine("[4] Tela Inicial ");
        Console.WriteLine("[0] Sair ");
        int opcao = int.Parse(Console.ReadLine()!);

        switch (opcao)
        {
            case 1: Extrato(); break;
            case 2: Deposito(); break;
            case 3: Saque(); break;
            //case 4: Conta.Menu(); break;
            case 0: System.Environment.Exit(0); break;
            default: Console.WriteLine("Opção Inválida!"); break;
        }

    }
    public void Extrato()
    {
        Console.WriteLine("--------------------");
        Console.WriteLine($"O Saldo é R${Saldo}");
        Console.WriteLine("--------------------");
        // Menu2();
    }

    public void Deposito()
    {
        Console.WriteLine("---------------------------------");
        Console.WriteLine("Digite o valor a ser Depositado: ");
        decimal Valor = decimal.Parse(Console.ReadLine()!);
        if (Valor < 0)
        {
            Console.WriteLine("Valor inválido!");
        }
        else
        {
            Saldo += Valor;
            Console.WriteLine("-------------------");
            Console.WriteLine("Depósito realizado!");
        }
        Console.WriteLine("Digite qualquer tecla para voltar ao Menu.");
        Console.ReadKey();
        //Menu2();
    }

    public void Saque()
    {
        Console.WriteLine("--------------");
        Console.WriteLine("Digite o valor a ser Sacado: ");
        decimal Valor = decimal.Parse(Console.ReadLine()!);
        if (Valor > Saldo)
        {
            Console.WriteLine("Valor inválido!");
        }
        else
        {
            Saldo -= Valor;
            Console.WriteLine("----------------");
            Console.WriteLine("Saque realizado!");
        }
        Console.WriteLine("Digite qualquer tecla para voltar ao Menu.");
        Console.ReadKey();
        //Menu2();
    }
}