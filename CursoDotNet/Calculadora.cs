using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDotNet
{
    internal class Calculadora
    {
        static void calcular(int n1, int n2)
        {
            double res = 0;

            while(true)
            {
                switch (opt)
                {
                    case '+':
                        res = n1 + n2;
                        Console.WriteLine(n1 + " + " + n2 + " = " + res);
                        break;
                    case '-':
                        res = n1 - n2;
                        Console.WriteLine(n1 + " - " + n2 + " = " + res);
                        break;
                    case '*':
                        res = n1 * n2;
                        Console.WriteLine(n1 + " * " + n2 + " = " + res);
                        break;
                    case '/':
                        res = n1 / n2;
                        Console.WriteLine(n1 + " / " + n2 + " = " + res.toString("N2"));
                        break;
                    default:
                        Console.WriteLine("Opção Inválida!");
                }
            } 
        }
    }
}
