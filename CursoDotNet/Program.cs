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
            contador(5, 2, 'd');

            Console.WriteLine();
            manipuladorDataAtual(new DateTime());

            Console.WriteLine();
            DateTime dt = DateTime.Now;
            Pessoa p1 = new Pessoa("Mauricio Pereira Braga", "01139325577", "811753304", dt);
            Console.WriteLine(p1);

            Console.WriteLine();
            abstracaoHeranca(new Cachorro("Caramelo"), 
                             new Gato("Zacarias"));

            //Console.WriteLine();
            //EstruturaDadosExercicio edx = new EstruturaDadosExercicio();
            //edx.CadastraPessoas();

            //Console.WriteLine();
            //EstruturaDados.ExercicioListaAlunos();

            //Console.WriteLine();
            //EstruturaDados.ExercicioGlicemia();

            /*
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
            */
        }

        static void greeter()
        {
            Console.Write("Say your name: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Hello, " + nome.ToUpper() + "!");
        }

        static void contador(int n1, int n2, char opt)
        {
            double res = 0;

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

        static void abstracaoHeranca(Cachorro c, Gato g)
        {
            c.Raca = "SRD";

            Console.WriteLine("Nome do dog é " + c.Nome + ", ele é da raça " + c.Raca + " e ele faz '" + c.emitirSom() + "'.");
            Console.WriteLine(c.caminhar());

            Console.WriteLine("Ganhei um gato e dei o nome de " + g.Nome + ", ele na hora que eu falei ele fez " + g.emitirSom() + ".");
            Console.WriteLine("Eu: Salve gato");
            Console.WriteLine(g.Nome + ": " + g.ronronar());
            Console.WriteLine(g.caminhar());
        }
    }
}