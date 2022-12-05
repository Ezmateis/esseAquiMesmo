using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class ContratoPessoaJuridica : Contrato
    {
        public int CNPJ { get; set; }
        public int InscricaoEstadual { get; set; }

        public ContratoPessoaJuridica()
        {

        }

        public ContratoPessoaJuridica(int cnpj, int inscricaoEstadual)
        {
            CNPJ = cnpj;
            InscricaoEstadual = inscricaoEstadual;
        }

        public override string Contratosla()
        {
            return CNPJ
                + ","
                + InscricaoEstadual
                ;

        }
    }
}
