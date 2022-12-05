using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Contrato
    {
        public int Id { get; set; }
        public string Contratante { get; set; }
        public double Valor { get; set; }
        public int Prazo { get; set; }

        public Contrato()
        {

        }

        public Contrato(int id, string contratante, double valor, int prazo)
        {
            Id = id;
            Contratante = contratante;
            Valor = valor;
            Prazo = prazo;

        }
        public virtual string Contratosla()
        {
            return "Esse é o Id"
                 +Id
                 + ", Esse é o Contratante"
                 + Contratante
                 + ", Esse é o Valor"
                 + Valor
                 + ", Esse é o Prazo"
                 + Prazo;

        }


    }
}
