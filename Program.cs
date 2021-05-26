using System;

namespace Revisao
{
    class Program
    {
        static void Main(string[] args)
        {
            Aluno[] alunos = new Aluno[5];
            var indiceAluno = 0;
            string opcaoUsuario = ObterOpcaoDoUsuario();

            while (opcaoUsuario.ToUpper() != "X")
            {
                switch (opcaoUsuario)
                {
                    case "1":
                        Console.WriteLine("Informe o nome do aluno:");
                        var aluno = new Aluno();
                        aluno.Nome = Console.ReadLine();

                        Console.WriteLine("Informe a note do aluno:");
                        
                        if (decimal.TryParse(Console.ReadLine(), out decimal nota))
                        {
                                aluno.Nota = nota; 
                        }
                        else
                        {
                            throw new ArgumentException("Valor da nota deve ser decimal");
                        }

                        alunos [indiceAluno] = aluno;
                        indiceAluno++;
                        
                        break;
                    case "2":
                    foreach(var a in alunos)
                    {
                        if (!string.IsNullOrEmpty(a.Nome))
                        {
                        Console.WriteLine($"ALUNO: {a.Nome} - NOTA: {a.Nota}");
                        }
                    }
                        //TODO: listar alunos
                        break;
                    case "3":
                        //TODO: calcular média geral
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                opcaoUsuario = ObterOpcaoDoUsuario();
            }
        }

        private static string ObterOpcaoDoUsuario()
        {
            Console.WriteLine("Informe a opção desejada:");
            Console.WriteLine("1- Inserir novo aluno");
            Console.WriteLine("2- Listar alunos");
            Console.WriteLine("3- Calcular média geral");
            Console.WriteLine("X- Sair");
            Console.WriteLine();

            string opcaoUsuario = Console.ReadLine();
            return opcaoUsuario;
        }
    }
}
