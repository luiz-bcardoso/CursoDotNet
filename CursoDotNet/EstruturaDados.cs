using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CursoDotNet
{
    internal static class EstruturaDados
    {
        public static void ExercicioListaAlunos()
        {
            List<string> listaNomes = new List<string>();

            Console.Write("Digite a qtd. de alunos: ");
            int qtdAlunos = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < qtdAlunos; i++) {
                Console.Write("Digite o nome do aluno: ");
                string nome = Console.ReadLine().ToUpper();

                if (!listaNomes.Contains(nome)){
                    listaNomes.Add(nome);
                }
                else
                {
                    Console.WriteLine("Aluno já cadastrado.");
                }

            }

            listaNomes.Sort();

            ExibeListaIterador(listaNomes);

            string opcao = "";
            while (!opcao.Equals("SAIR")){
                Console.Write("Digite um aluno para remoção (ou digite 'sair' para sair): ");
                opcao = Console.ReadLine().ToUpper();

                if (listaNomes.Contains(opcao))
                {
                    listaNomes.Remove(opcao);
                }
                else
                {
                    Console.WriteLine("(ERRO): Aluno não encontrado!");
                }

                ExibeListaIterador(listaNomes);
            }
            
        }

        public static void ExibeListaIterador(List<string> lista)
        {
            IEnumerator<string> enumerator = lista.GetEnumerator();
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
            }
        }

        public static void ExercicioGlicemia()
        {
            //Gerar valores de glicemia entre 50-240. Aplicar a média, mediana e moda.
            List<double> valoresGlicemia = new List<double>();
            Random random = new Random();
            
            for (int i = 0; i < random.Next(10,50); i++)
            {
                valoresGlicemia.Add(random.NextDouble()*(240-50) + 50);
            }

            Console.WriteLine("LISTA ORIGINAL");
            foreach(double valor in valoresGlicemia)
            {
                Console.Write("[ "+valor.ToString("0.##")+" ] ");
            }
            Console.WriteLine();

            Console.WriteLine("Média: " + CalcularMedia(valoresGlicemia) );
            Console.WriteLine("Moda:" + CalcularModa(valoresGlicemia));
            Console.WriteLine("Mediana:" + CalcularMediana(valoresGlicemia) );
        }

        public static double CalcularMedia(List<double> lista)
        {
            double media = 0;
            
            foreach (var item in lista) { 
                media += item;
            }

            media = media / lista.Count;

            return media;
        }

        public static double CalcularMediana(List<double> lista)
        {
            double mediana = 0;
            
            lista.Sort();

            Console.WriteLine("LISTA ORDENADA");
            foreach (double valor in lista)
            {
                Console.Write("[ " + valor.ToString("0.##") + " ] ");
            }
            Console.WriteLine();

            if (lista.Count % 2  == 0)
            {
                mediana = lista.ElementAt(lista.Count/2);
            }
            else
            {
                mediana = lista.ElementAt((lista.Count - 1 )/ 2);
            }

            return mediana;
        }

        public static T CalcularModa<T>(this IEnumerable<T> lista)
        {
            T moda = default(T); 
            
            if(lista != null &&  lista.Count() > 0)
            {
                Dictionary<T, int> contador = new Dictionary<T, int>();
                
                //Conta a ocorrencia de cada elemento na lista
                foreach (T elemento in lista) 
                { 
                    if (contador.ContainsKey(elemento))
                        contador[elemento]++;

                    else 
                        contador.Add(elemento, 1);
                }

                int valorMax = 0;

                //Procura pelo elemento que mais repetiu no contador.
                foreach(KeyValuePair<T, int> count in contador)
                {
                    if(count.Value > valorMax)
                    {
                        moda = count.Key;
                        valorMax = count.Value;
                    }
                }
            }

            return moda;
        }

        public static List<int> PopulaListaInteiro(int tamanhoLista)
        {
            List<int> lista = new List<int>();
            Random gerador = new Random();
            lista.Capacity = tamanhoLista;

            while(lista.Count < tamanhoLista)
            {
                lista.Add(gerador.Next(1, 100));
            }

            return lista;
        }

        public static void ExercicioListaRecorrente(List<int> listaA, List<int> listaB)
        {
            HashSet<int> listaAB = new HashSet<int>();

            //Console.Write("ListaA : ");
            //foreach(int valorA in listaA)
            //{
            //    Console.Write("["+valorA+"] ,");
            //}
            
            //Console.WriteLine();

            //Console.Write("ListaB : ");
            //foreach (int valorB in listaB)
            //{
            //    Console.Write("[" + valorB + "] ,");
            //}

            //Console.WriteLine();

            //Cria uma nova lista com a ocorrencia das duas listas.
            //BigO(n^2)
            for (int i = 0; i < listaA.Count; i++)
            {
                for (int j = 0; j < listaB.Count; j++)
                {
                    if (listaA[i] == listaB[j])
                    {
                        listaAB.Add(listaA[i]);
                    }
                }
            }
            listaAB = new HashSet<int>(listaAB.OrderBy(x => x));
            Console.Write("Lista A∩B: ");
            foreach (int valor in listaAB)
            {  
                Console.Write("["+valor+"] ,");
            }
            Console.WriteLine();
        }

        public static void ExercicioListaRecorrenteOtimizado(List<int> listaA, List<int> listaB)
        {
            // Utiliza HashSet para evitar duplicatas
            HashSet<int> listaAB = new HashSet<int>();

            // Impressão das listas usando string.Join e lista.Select para melhor performance
            //Console.WriteLine("ListaA : [" + string.Join("] ,", listaA.Select(x => $"[{x}]")) + "]");
            //Console.WriteLine("ListaB : [" + string.Join("] ,", listaB.Select(x => $"[{x}]")) + "]");

            // Converte listaA para HashSet para busca O(1)
            HashSet<int> setA = new HashSet<int>(listaA);

            // Verifica ocorrências em O(n) ao invés de O(n²)
            foreach (int valor in listaB)
            {
                if (setA.Contains(valor))
                {
                    listaAB.Add(valor);
                }
            }
            listaAB = new HashSet<int>(listaAB.OrderBy(x => x));
            Console.WriteLine("Lista A∩B: [" + string.Join("] ,", listaAB.Select(x => $"[{x}]")) + "]");
        }
    }
}
