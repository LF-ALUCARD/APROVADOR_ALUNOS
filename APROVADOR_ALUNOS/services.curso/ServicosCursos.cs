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



        public static void ListarDesempenhoDoAluno(Aluno aluno, Lista<Curso> curso)
        {
            Console.Clear();
            string caminhoPasta = @"C:\dados_pesquisa";
            string caminhoArquivo = Path.Combine(caminhoPasta, "dados_pesquisa.txt");

            // Verifica se a pasta existe, senão cria
            if (!Directory.Exists(caminhoPasta))
            {
                Directory.CreateDirectory(caminhoPasta);
            }

            using (StreamWriter writer = new StreamWriter(caminhoArquivo, true)) // true = append
            {
                string cabecalho = $"Desempenho do aluno: {aluno.getNome()} (Matrícula: {aluno.getMatricula()})\n";
                Console.WriteLine(cabecalho);
                writer.WriteLine(cabecalho);

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

                        string dadosDisciplina = $"Disciplina: {disciplina.getNome()}\n" +
                                                 $"Nota 1: {nota1} | Nota 2: {nota2} | Média: {media:F1}\n" +
                                                 $"Nota mínima: {notaMinima} | Resultado: {resultado}\n" +
                                                 "----------------------------------------";

                        Console.WriteLine(dadosDisciplina);
                        writer.WriteLine(dadosDisciplina);
                    }

                    atual = atual.getNo();
                }

                if (!encontrou)
                {
                    string msg = "Nenhuma disciplina encontrada para este aluno.\n";
                    Console.WriteLine(msg);
                    writer.WriteLine(msg);
                }
            }
        }


        public static void ListarDesempenhoDaDisciplina(Disciplina disciplina, Lista<Curso> cursos)
        {
            Console.Clear();
            string caminhoPasta = @"C:\dados_pesquisa";
            string caminhoArquivo = Path.Combine(caminhoPasta, "dados_pesquisa.txt");

            // Verifica se a pasta existe, senão cria
            if (!Directory.Exists(caminhoPasta))
            {
                Directory.CreateDirectory(caminhoPasta);
            }

            using (StreamWriter writer = new StreamWriter(caminhoArquivo, true)) // true = append
            {
                string cabecalho = $"Desempenho na disciplina: {disciplina.getNome()} (Código: {disciplina.getCodicoDisciplina()})\n";
                Console.WriteLine(cabecalho);
                writer.WriteLine(cabecalho);

                No<Curso> atual = cursos.getInicio();
                bool encontrou = false;

                while (atual != null)
                {
                    Curso cursoAtual = atual.getElemento();

                    // Verifica se o curso é da disciplina desejada
                    if (cursoAtual.getAluno().getDisciplina().getCodicoDisciplina() == disciplina.getCodicoDisciplina())
                    {
                        encontrou = true;

                        Aluno aluno = cursoAtual.getAluno().getAluno();
                        float nota1 = cursoAtual.getNota1();
                        float nota2 = cursoAtual.getNota2();
                        float media = (nota1 + nota2) / 2;
                        float notaMinima = disciplina.getNotaMinima();

                        string resultado = media >= notaMinima ? "Aprovado" : "Reprovado";

                        string dadosAluno = $"Aluno: {aluno.getNome()} (Matrícula: {aluno.getMatricula()})\n" +
                                            $"Nota 1: {nota1} | Nota 2: {nota2} | Média: {media:F1}\n" +
                                            $"Nota mínima: {notaMinima} | Resultado: {resultado}\n" +
                                            "----------------------------------------";

                        Console.WriteLine(dadosAluno);
                        writer.WriteLine(dadosAluno);
                    }

                    atual = atual.getNo();
                }

                if (!encontrou)
                {
                    string msg = "Nenhum aluno encontrado para esta disciplina.\n";
                    Console.WriteLine(msg);
                    writer.WriteLine(msg);
                }
            }
        }


    }
}
