using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaBanco_Exercicio
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Profissao { get; set; }


    }

    public void LerDados()
    {
        Console.WriteLine("Informe seus dados da pessoais: ");
        Console.Write("Nome: ");
        string nome = Console.ReadLine();
        Console.Write("Cpf : ");
        string CPF = (Console.ReadLine());
        Console.WriteLine("Profissão: ");
        string Profissao = Console.ReadLine();
    }
}


/*Cadastre as Contas Correntes pelos Clientes de um banco:
-O Cliente deve possuir (CPF, Nome e Endereço completo)
-A conta ao ser criada possui: Agencia, Numero e Saldo(inicialmente Zero)*/
