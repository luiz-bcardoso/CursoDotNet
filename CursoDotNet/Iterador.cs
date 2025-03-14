using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDotNet
{
    internal class Iterador
    {
        public void Incrementar(int n)
        {
            for(int i =0; i < n; i++)
            {
                Console.WriteLine(i);
            }
        }

        public void Decrementar(int n)
        {
            for(int i = n; i < 0; i++) 
            {
                Console.WriteLine(i);
            }
        }
    }
}
