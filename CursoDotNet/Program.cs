using System.Diagnostics;

namespace CursoDotNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Stopwatch relogio = new Stopwatch();
            greeter();

            Console.WriteLine();
            contador(5, 2);

            Console.WriteLine();
            manipuladorDataAtual(new DateTime());

            //Console.WriteLine();
            //EstruturaDados.ExercicioListaAlunos();

            //Console.WriteLine();
            //EstruturaDados.ExercicioGlicemia();

            List<int> listaA = EstruturaDados.PopulaListaInteiro(100000);
            List<int> listaB = EstruturaDados.PopulaListaInteiro(100000);

            Console.WriteLine("------ Lista Recorrente O(n^2) ------");
            relogio.Start();
            EstruturaDados.ExercicioListaRecorrente(listaA, listaB);
            relogio.Stop();
            Console.WriteLine("Tempo de execução: " + relogio.ElapsedMilliseconds + "ms");
            relogio.Reset();
            Console.WriteLine("-------------------------------------");

            Console.WriteLine("------- Lista Recorrente O(n) ------");
            relogio.Start();
            EstruturaDados.ExercicioListaRecorrenteOtimizado(listaA, listaB);
            relogio.Stop();
            Console.WriteLine("Tempo de execução: " + relogio.ElapsedMilliseconds + "ms");
            relogio.Reset();
            Console.WriteLine("-------------------------------------");
        }

        static void greeter()
        {
            Console.Write("Say your name: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Hello, " + nome.ToUpper() + "!");
        }

        static void contador(int n1, int n2)
        {
            double res = 3/2;

            res = n1 + n2;
            Console.WriteLine(n1 + " + " + n2 + " = " + res);

            res = n1 - n2;
            Console.WriteLine(n1 + " - " + n2 + " = " + res);

            res = n1 * n2;
            Console.WriteLine(n1 + " * " + n2 + " = " + res);

            res = n1 / n2;
            Console.WriteLine(n1 + " / " + n2 + " = " + res);
        }

        static void manipuladorDataAtual(DateTime dt)
        {
            dt = DateTime.Now;
            Console.WriteLine("Hoje é o dia "+dt.Day+ ", e agora são "+dt.Hour+" horas e "+dt.Minute+" minutos.");
            Console.WriteLine("Estamos no mês "+dt.Month+ " do ano de "+dt.Year+".");
        }
    }
}