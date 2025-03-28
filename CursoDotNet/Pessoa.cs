using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDotNet
{
    internal class Pessoa
    {
        private string _nome;
        private string _cpf;
        private string _rg;
        private DateTime _dataNasc;

        public Pessoa(string nome, string cpf, string rg, DateTime dataNasc)
        {
            _nome = nome;
            _cpf = cpf;
            _rg = rg;
            _dataNasc = dataNasc;
        }

        public override string ToString()
        {
            return $"Indivíduo {_nome} de CPF nº {_cpf} nascido na data de {_dataNasc}, com possível registro geral de {_rg}";
        }
    }
}
