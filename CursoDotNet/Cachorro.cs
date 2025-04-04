using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDotNet
{
    internal class Cachorro : Animal
    {
        private string _Raca;

        public Cachorro(string nome) : base(nome)
        {
            _Raca = nome;
        }

        public string Raca { get => _Raca; set => _Raca = value; }

        public override string emitirSom()
        {
            return "au au";
        }
    }
}
