using System.Collections.Generic;

namespace ExercicioBanco;
public class Program
{
    public static void Main(string[] args)
    {
        Dictionary<string, string> ListaID_Clientes = new Dictionary<string, string>();
        Dictionary<string, decimal> ListaClientes_Saldo = new Dictionary<string, decimal>();

        CadastroCliente cliente1 = new CadastroCliente("3322", "Rafael Morais", 3500);
        ListaID_Clientes.Add(cliente1.IDConta, cliente1.nome);
        ListaClientes_Saldo.Add(cliente1.nome, cliente1.saldo);
        CadastroCliente cliente2 = new CadastroCliente("4455", "Letícia moreira", 5500);
        ListaID_Clientes.Add(cliente2.IDConta, cliente2.nome);
        ListaClientes_Saldo.Add(cliente2.nome, cliente2.saldo);
        CadastroCliente cliente3 = new CadastroCliente("5544", "Bebê Morais", 15000);
        ListaID_Clientes.Add(cliente3.IDConta, cliente3.nome);
        ListaClientes_Saldo.Add(cliente3.nome, cliente3.saldo);

        Menu2();

        void Menu()
        {
            Console.Clear();
            Console.WriteLine("-Banco RMM-");
            Console.WriteLine("Digite o ID do Cliente: ");
            string id = Console.ReadLine()!;
            if (ListaID_Clientes.ContainsKey(id))
            {
                Console.WriteLine($"Seja Bem-Vindo!");
                Menu3();
            }
            else
            {
                Console.WriteLine("Cliente não consta no banco de dados");
                Cadastrar();
            }
        }
        void Cadastrar()
        {
            string novoIdConta = Guid.NewGuid().ToString("N").ToUpper()[..4];
            Console.WriteLine("Anote seu ID: " + novoIdConta);
            Console.WriteLine("Digite o NOME do Cliente: ");
            string novoNomeCliente = Console.ReadLine()!;
            Console.WriteLine("Digite o VALOR do DEPÓSITO inicial: ");
            decimal novoSaldo = decimal.Parse(Console.ReadLine()!);
            CadastroCliente novoCliente = new CadastroCliente(novoIdConta, novoNomeCliente, novoSaldo);
            ListaID_Clientes.Add(novoCliente.IDConta, novoCliente.nome);
            ListaClientes_Saldo.Add(novoCliente.nome, novoCliente.saldo);
            Console.WriteLine("Usuário adicionado com sucesso!");
            Console.WriteLine("-------------------------------");
            Menu2();
        }
        void Menu2()
        {
            Console.Clear();
            Console.WriteLine("Aperte a tecla [1] para Cadastrar um Cliente");
            Console.WriteLine("Aperte a tecla [2] para ir ao Menu");
            Console.WriteLine("Aperte a tecla [3] para Lista de Clientes");
            Console.WriteLine("-----------------------------------------");
            int opcao = int.Parse(Console.ReadLine()!);
            switch (opcao)
            {
                case 1: Cadastrar(); break;
                case 2: Menu(); break;
                case 3:
                    Console.WriteLine("-----------------------------------------");
                    foreach (string nomes in ListaID_Clientes.Values)
                    {
                        Console.WriteLine(nomes);
                    }
                    Console.WriteLine("Digite qualquer tecla para retornar");
                    Console.ReadLine();
                    Menu2();
                    break;
                default: Console.WriteLine("Opção Inválida!"); break;
            }
        }
        void Menu3()
        {
            decimal saldo = cliente1.saldo;
            Console.WriteLine("[1] Extrato ");
            Console.WriteLine("[2] Deposito ");
            Console.WriteLine("[3] Saque ");
            Console.WriteLine("[4] Tela Inicial ");
            Console.WriteLine("[0] Sair ");
            int opcao = int.Parse(Console.ReadLine()!);

            switch (opcao)
            {
                case 1: Extrato(); break;
                case 2: Deposito(); break;
                case 3: Saque(); break;
                case 4: Menu(); break;
                case 0: System.Environment.Exit(0); break;
                default: Console.WriteLine("Opção Inválida!"); break;
            }


            void Extrato()
            {
                Console.WriteLine("--------------------");
                Console.WriteLine($"O Saldo é R${saldo}");
                Console.WriteLine("--------------------");
                Menu3();
            }

            void Deposito()
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
                    cliente1.saldo += Valor;
                    Console.WriteLine("-------------------");
                    Console.WriteLine("Depósito realizado!");
                }
                Console.WriteLine("Digite qualquer tecla para voltar ao Menu.");
                Console.ReadKey();
                Menu3();
            }

            void Saque()
            {
                Console.WriteLine("--------------");
                Console.WriteLine("Digite o valor a ser Sacado: ");
                decimal Valor = decimal.Parse(Console.ReadLine()!);
                if (Valor > saldo)
                {
                    Console.WriteLine("Valor inválido!");
                }
                else
                {
                    cliente1.saldo -= Valor;
                    Console.WriteLine("----------------");
                    Console.WriteLine("Saque realizado!");
                }
                Console.WriteLine("Digite qualquer tecla para voltar ao Menu.");
                Console.ReadKey();
                Menu3();
            }

        }
    }
}