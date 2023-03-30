using System.Collections.Generic;

namespace ExercicioBanco;
public class Program
{
    public static void Main(string[] args)
    {
        Menu();
    }
    static void Menu()
    {
        string Id = "";
        string Nome = "";
        //long Cpf = 0;

        Dictionary<string, string> clienteId = new Dictionary<string, string>();
        clienteId.Add("0123", "Rafael");
        clienteId.Add("0456", "Letícia");

        Console.Clear();
        Console.WriteLine("Seja Bem-Vindo ao Banco RMM!");
        Console.WriteLine("Digite o CÓDIGO do Cliente: ");
        Id = (Console.ReadLine()!);
        if (clienteId.ContainsKey(Id))
        {
            Console.WriteLine($"Seja Bem-Vindo {clienteId[Id]}");
        }
        else
        {
            Console.WriteLine("Novo Cliente");
            string Identificador = Guid.NewGuid().ToString("N").ToUpper()[..4];
            Console.WriteLine($"Id do Novo Cliente: {Identificador}");
            Console.WriteLine("Digite o NOME do Cliente: ");
            string NomeCli = Console.ReadLine()!;
            // Console.WriteLine("Digite o CPF do Cliente: ");
            // Cpf = long.Parse(Console.ReadLine()!);
            clienteId.Add(Identificador, NomeCli);
        }
        //----------------------------------------------------------
        CadastroCliente cliente1 = new CadastroCliente(Id, Nome);
        //----------------------------------------------------------

        Console.WriteLine("Aperte qualquer tecla [1] para Cadastrar Mais um Cliente");
        Console.WriteLine("Aperte qualquer tecla [2] para ir ao Menu");
        Console.WriteLine("Aperte qualquer tecla [3] para Lista de Clientes");
        Console.WriteLine("-----------------------------------------");
        int opcao = int.Parse(Console.ReadLine()!);
        switch (opcao)
        {
            case 1: Menu(); break;
            case 2: cliente1.Menu2(); break;
            case 3:
                Console.WriteLine("-----------------------------------------");
                foreach (string nomes in clienteId.Values)
                {
                    Console.WriteLine(nomes);
                }
                Console.WriteLine("Digite qualquer tecla para retornar");
                Console.ReadLine();
                Menu();
                break;
            default: Console.WriteLine("Opção Inválida!"); break;
        }
    }
}
