using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDotNet
{
    abstract class Animal
    {
        private string _Nome;

        public Animal(string nome)
        {
            _Nome = nome;
        }

        public string Nome { get => _Nome; set => _Nome = value; }

        public abstract String emitirSom();

        //virtual permite que a classe possa ser sobreescrita (override)
        public virtual string caminhar()
        {
            return "O animal está caminhando.";
        }


    }
}
