using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace ConsoleApp1
{
    class ContratoPessoaFisica : Contrato
    {
        public int CPF { get; set; }
        public int Idade { get; set; }
        public double calcu { get; private set; }
        public double Valortotal { get; private set; }

        public ContratoPessoaFisica()
        {

        }

        public ContratoPessoaFisica(int cpf, int idade, int id, string contratante, double valor, int prazo)
            : base(id, contratante, valor, prazo)
        {
            CPF = cpf;
            Idade = idade;
        }


        public void calcuIfElse()
        {
            if (Idade <= 30)
            {
                calcu = Valor + 1;
            }
            else if (Idade <= 40)
            {
                calcu = Valor + 2;
            }
            else if (Idade <= 50)
            {
                calcu = Valor + 3;
            }
            else
            {
                calcu = Valor + 4;
            }
        }

        public void alcularPrestação()
        {
            Valortotal = calcu / Prazo;
        }

        public override string Contratosla()
        {
            return "Esse é o CPF "
                + CPF
                + "Esse é a Idade "
                + Idade
                + "Esse é o Valor "
                + Valortotal
                ;

        }
    }
}