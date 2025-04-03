using System;

namespace BuscaLinear_ListaObjetos
{
    class Aluno
    {
        public string Nome { get; set; }
        public int Matricula { get; set; }

        public Aluno(string nome, int matricula)
        {
            Nome = nome;
            Matricula = matricula;
        }
    }
    class Program
    {
        static Aluno BuscarAluno(Aluno[] alunos, int matricula)
        {
            foreach (Aluno aluno in alunos)
                {
                    if(aluno.Matricula == matricula){
                        return aluno;

                    }

                }
                return null;
        }

        static void Main()
        {
            Aluno[] listaAlunos =
            {
            new Aluno("Joao", 24),
            new Aluno("Maria", 32),
            new Aluno("Elena", 16),
            new Aluno("Carlos", 19),
            new Aluno("Mariana", 29)

        };
        int buscaMatricula = 29;
        Aluno alunoEncontrado = BuscarAluno(listaAlunos, buscaMatricula);
                
                if (alunoEncontrado != null)
                    Console.WriteLine($"Aluno encontrado: {alunoEncontrado.Nome}, sua matrícula é: {alunoEncontrado.Matricula}");
                else
                    Console.WriteLine($"Nenhum aluno encontrado com matrícula {buscaMatricula}");

                Console.ReadKey();
            }
            
        }
    }



