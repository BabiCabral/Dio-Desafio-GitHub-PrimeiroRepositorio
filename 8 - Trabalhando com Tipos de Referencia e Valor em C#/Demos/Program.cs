using static System.Console;

    public class Program
    {

        static int Adicionar20 (int x)
        {
            return x + 20;
        }

static void TrocarNome(Pessoa p1, string nomeNovo) 
        {
            p1.Nome = nomeNovo;
        }

 public static void Main()
 {
            Pessoa p1 = new Pessoa();
            p1.Nome = "Bárbara";
            p1.Idade = 24;
            p1.Documento = "1234";

            TrocarNome(p1, "Raissa");

            WriteLine($"O novo nome é {p1.Nome}");
        }
    }