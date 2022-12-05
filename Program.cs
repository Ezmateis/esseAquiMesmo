using System;
using System.Globalization;
using System.Collections.Generic;
using ConsoleApp1;
using System.ComponentModel;
using static System.Net.Mime.MediaTypeNames;
using System.Drawing;

namespace esse
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Contrato> list = new List<Contrato>();
            ContratoPessoaFisica f = new ContratoPessoaFisica();

            Console.WriteLine("Quantas pessoas serao :");
            int n = int.Parse(Console.ReadLine());

            for(int i = 1; i <= n; i++)
            {
                Console.WriteLine("Qual o seu ID:");
                int Id = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Qual o Contratante:");
                string Contratante = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Qual sera o valor:");
                double Valor = double.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("Qual sera o prazo em dias:");
                int Prazo = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("O contrato sera pra pessoa Fisica ou Juridica (F/J)");
                char r = char.Parse(Console.ReadLine());

                if(r == 'F'|| r== 'f')
                {
                    Console.WriteLine("Qual é o CPF:");
                    int CPF = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Qual a Idade:");
                    int Idade = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    list.Add(new ContratoPessoaFisica(CPF, Idade, Id, Contratante, Valor, Prazo));
                }

                else if(r == 'J' || r == 'j')
                {
                    Console.WriteLine("Qual o CNPJ:");
                    int CNPJ = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    Console.WriteLine("Qual o numero da Inscricao Estadual");
                    int InscricaoEstadual = int.Parse(Console.ReadLine());
                    Console.WriteLine();
                    list.Add(new ContratoPessoaJuridica(CNPJ, InscricaoEstadual));
                }

                else
                {
                    Console.WriteLine("Letra n coresponde, Digite F (Pessoa Fisica) ou J (Pessoa Juridica)");
                }

                f.alcularPrestação();

                Console.WriteLine("Informacao do Contrato");
                foreach (Contrato pro in list)
                {
                    Console.WriteLine(pro.Contratosla());
                }

            }
        }
    }
}
