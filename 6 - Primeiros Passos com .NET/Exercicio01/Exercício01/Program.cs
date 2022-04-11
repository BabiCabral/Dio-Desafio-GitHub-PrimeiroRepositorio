using System;

namespace revisao2
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            var indiceAluno = 0;
            string opçaoUsuario = ObterOpçaoUsuario();

            while (opçaoUsuario.ToUpper() != "X")
            {
                switch (opçaoUsuario)
                {
                    case "1":
                    
                        Console.WriteLine("Informe o nome do Aluno: ");
                        Aluno aluno = new Aluno();
                        aluno.Name = Console.ReadLine();

                        Console.WriteLine("Informe a nota do Aluno: ");

                        if (decimal.TryParse(Console.ReadLine(), out decimal Nota))
                        {
                           aluno.Nota = Nota; 
                        }
                        else
                        {
                            throw new ArgumentException("O valor da nota precisa ser decimal.");
                        }

                        alunos[indiceAluno] = aluno;
                        indiceAluno++;
                        
                        break;
                    case "2":
                        foreach(var a in alunos)
                        {
                            if(!string.IsNullOrEmpty(a.Name))
                            {
                                Console.WriteLine($"ALUNO: {a.Name} - NOTA: {a.Nota}");
                            }
                            
                        }
                        break;
                    case "3":
                        decimal notaTotal = 0;
                        var numeroDeAlunos = 0;
                        for (int i=0; i < alunos.Length; i++)
                        {
                            if(!string.IsNullOrEmpty(alunos[i].Name))
                            {
                                notaTotal = notaTotal + alunos[i].Nota;
                                numeroDeAlunos++;
                            }
                        }

                        var mediaGeral = notaTotal / numeroDeAlunos;
                        conceitoEnum conceitoGeral;

                        if (mediaGeral <= 2)
                        {
                            conceitoGeral = conceitoEnum.E;
                        } 
                        else if (mediaGeral <= 4)
                        {
                            conceitoGeral = conceitoEnum.D;
                        }
                        else if (mediaGeral <= 6)
                        {
                            conceitoGeral = conceitoEnum.C;
                        }
                        else if (mediaGeral <= 8)
                        {
                            conceitoGeral = conceitoEnum.B;
                        }
                        else
                        {
                            conceitoGeral = conceitoEnum.A;
                        }

                        Console.WriteLine($"Média Geral: {mediaGeral} - CONCEITO: {conceitoGeral}");

                        break;

                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opçaoUsuario = ObterOpçaoUsuario();

            }
        }

        private static string ObterOpçaoUsuario()
        {
            Console.WriteLine();
            Console.WriteLine("Informe a opção desejada");
            Console.WriteLine("1- Inserir novo aluno");
            Console.WriteLine("2- Listar alunos");
            Console.WriteLine("3- Calcular média geral");
            Console.WriteLine("X - Sair");
            Console.WriteLine();

            String opçaoUsuario = Console.ReadLine();
            return opçaoUsuario;
        }
    }
}