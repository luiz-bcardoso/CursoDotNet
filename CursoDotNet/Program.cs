namespace CursoDotNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            greeter();

            Console.WriteLine();
            contador(5, 2);

            Console.WriteLine();
            manipuladorDataAtual(new DateTime());

            //Console.WriteLine();
            //EstruturaDados.ExercicioListaAlunos();

            //Console.WriteLine();
            //EstruturaDados.ExercicioGlicemia();

            Console.WriteLine();
            EstruturaDados.ExercicioListaRecorrente();

            Console.WriteLine();
            EstruturaDados.ExercicioListaRecorrente();
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