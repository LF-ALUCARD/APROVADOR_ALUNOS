using APROVADOR_ALUNOS.entidades;
using APROVADOR_ALUNOS.entidades;

namespace APROVADOR_ALUNOS.services.curso
{
    internal class ServicosCursos
    {
        private static Lista<Curso> lista = new Lista<Curso>();
        public static Lista<Curso> iniciar(String caminho, Lista<Aluno> listaAlunos, Lista<Disciplina> listaDisciplinas)
        {
            Lista<Curso> lista = new Lista<Curso>();

            using (StreamReader sr = new StreamReader(caminho))
            {
                String linha;
                while ((linha = sr.ReadLine()) != null)
                {
                    String[] vect = linha.Split(";");
                    int matricula = int.Parse(vect[0]);
                    int codDisciplina = int.Parse(vect[1]);
                    float nota1 = float.Parse(vect[2]);
                    float nota2 = float.Parse(vect[3]);

                    Curso curso = new Curso(matricula, codDisciplina, nota1, nota2, listaAlunos, listaDisciplinas);
                    lista.inserir(curso);
                }
            }

            return lista;
        }


        public static void ListarDesempenhoDoAluno(Aluno aluno, Lista<Curso> curso)
        {
            Console.Clear();
            Console.WriteLine($"Desempenho do aluno: {aluno.getNome()} (Matrícula: {aluno.getMatricula()})\n");

            No<Curso> atual = curso.getInicio();
            bool encontrou = false;

            while (atual != null)
            {
                Curso cursoAtual = atual.getElemento();

                if (cursoAtual.getAluno().getAluno().getMatricula() == aluno.getMatricula())
                {
                    encontrou = true;

                    Disciplina disciplina = cursoAtual.getAluno().getDisciplina();
                    float nota1 = cursoAtual.getNota1();
                    float nota2 = cursoAtual.getNota2();
                    float media = (nota1 + nota2) / 2;
                    float notaMinima = disciplina.getNotaMinima();

                    string resultado = media >= notaMinima ? "Aprovado" : "Reprovado";

                    Console.WriteLine($"Disciplina: {disciplina.getNome()}");
                    Console.WriteLine($"Nota 1: {nota1} | Nota 2: {nota2} | Média: {media:F1}");
                    Console.WriteLine($"Nota mínima: {notaMinima} | Resultado: {resultado}");
                    Console.WriteLine("----------------------------------------");
                }

                atual = atual.getNo();
            }

            if (!encontrou)
            {
                Console.WriteLine("Este aluno não possui disciplinas registradas.");
            }
        }



        public static Curso BuscarPorMatricula(int matricula)
        {
            No<Curso> atual = lista.getInicio();

            while (atual != null)
            {
                Curso curso = atual.getElemento();
                if (curso.getAluno().getAluno().getMatricula() == matricula)
                {
                    return curso;
                }
                atual = atual.getNo();
            }
            return null;
        }

        public static Curso Buscar_Nome(String nome)
        {
            No<Curso> atual = lista.getInicio();

            while (atual != null)
            {
                Curso curso = atual.getElemento();
                if (nome == curso.getAluno().getAluno().getNome())
                {
                    return curso;
                }
                atual = atual.getNo();
            }
            return null;
        }


    }
}
