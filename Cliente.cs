using System.Collections.Generic;
using System.Collections.Generic;

namespace ExercicioBanco;
public class CadastroCliente : Conta
{
    public string nome;
    public decimal saldo;

    public CadastroCliente(string idConta, string nome, decimal saldo)
    {
        this.idConta = idConta;
        this.nome = nome;
        this.saldo = saldo;
    }

}

