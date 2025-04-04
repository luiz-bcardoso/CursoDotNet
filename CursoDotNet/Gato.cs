using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDotNet
{
    internal class Gato : Animal
    {
        public Gato(string nome) : base(nome)
        {
        }

        public override string emitirSom()
        {
            return "Miau!";
        }

        public string ronronar()
        {
            return "Prrrrr...";
        }

        public override string caminhar()
        {
            return "O gato está dormindo";
        }
    }
}
