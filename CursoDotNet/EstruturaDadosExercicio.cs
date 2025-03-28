namespace CursoDotNet
{
    /*
    Fazer um programa em Java, C# ou C++ que receba nomes completos de pessoas (validar se nome foi digitado completo). 
    A partir disso, gerar email da pessoa combinando o primeiro nome com o último nome, separados por '.', mais '@ufn.edu.br'. 
    Por exemplo, João Pedro Garcia -> joao.garcia@ufn.edu.br. Uma vez que o email foi gerado, adicionar o par (nome completo e email) em uma lista. 
    Essa lista pode ser composta por dicionários (email será a chave e nome completo o valor) ou por objetos (da classe Pessoa, com atributos nome e email). 
    Contudo, não pode haver emails repetidos. Ao final, exibir a lista com os dados (nomes e emails).
    */
    internal class EstruturaDadosExercicio
    {
        private readonly Dictionary<string, string> listaEmailPessoas = new();

        private void ExibirListaPessoas()
        {
            foreach (var (email, nome) in listaEmailPessoas)
            {
                Console.WriteLine($"Email: {email}\tNome: {nome}");
            }
        }

        public void CadastraPessoas()
        {
            while (true)
            {
                Console.Write("Digite um nome completo (deixe vazio para sair): ");
                string? nome = Console.ReadLine()?.Trim();

                if (string.IsNullOrEmpty(nome))
                {
                    Console.WriteLine("Fim do cadastro de pessoas.");
                    ExibirListaPessoas();
                    break;
                }

                if (nome.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length > 1)
                {
                    string email = GerarEmail(nome.ToLower());
                    listaEmailPessoas.Add(email, nome.ToUpper());
                    Console.WriteLine("Nome cadastrado com sucesso!");
                }
                else
                {
                    Console.WriteLine("(ERRO) Digite o nome completo.");
                }
            }
        }

        private string GerarEmail(string nome)
        {
            string[] partesNome = nome.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string emailBase = $"{partesNome[0]}.{partesNome[1]}@ufn.edu.br".ToLowerInvariant();
            string email = emailBase;

            int contador = 0;
            while (listaEmailPessoas.ContainsKey(email))
            {
                contador++;
                email = $"{partesNome[0]}.{partesNome[1]}{contador}@ufn.edu.br".ToLowerInvariant();
            }

            return email;
        }
    }
}
