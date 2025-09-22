using APROVADOR_ALUNOS.entidades;
using APROVADOR_ALUNOS.entidades;

namespace APROVADOR_ALUNOS.services.curso
{
    internal class ServicosCursos
    {
        private static Lista<Curso> lista = new Lista<Curso>(); //Instancia uma lista na classe para trabalhar com os métodos
        public static Lista<Curso> iniciar(String caminho, Lista<Aluno> listaAlunos, Lista<Disciplina> listaDisciplinas) //Instancia minha lista de curso a partir da minha lista de Alunos e Disciplinas
        {
            Lista<Curso> lista = new Lista<Curso>();

            using (StreamReader sr = new StreamReader(caminho))
            {
                String linha;
                while ((linha = sr.ReadLine()) != null) //Lógica construida para percorrer minha lista de Curso
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


        public static void ListarDesempenhoDoAluno(Aluno aluno, Lista<Curso> curso) //Lógica construida para exibir os dados do meu aluno, com as disciplina
        {
            Console.Clear();
            Console.WriteLine($"Desempenho do aluno: {aluno.getNome()} (Matrícula: {aluno.getMatricula()})\n");

            No<Curso> atual = curso.getInicio();
            bool encontrou = false;

            while (atual != null) //Lógica construida para buscar as disciplinas do meu aluno e exibir
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

            if (!encontrou) //Excessão para caso o meu aluno não tenha nenhuma disciplina
            {
                Console.WriteLine("Este aluno não possui disciplinas registradas.");
            }
        }

    }
}
