using APROVADOR_ALUNOS.entidades;
using APROVADOR_ALUNOS.services;
using APROVADOR_ALUNOS.program;

using APROVADOR_ALUNOS.services.alunos;

namespace APROVADOR_ALUNOS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String caminho = "C:\\Users\\luiz.oliveira\\Documents\\aluno.txt";
            String caminho2 = "C:\\Users\\luiz.oliveira\\Documents\\disciplina.txt";
            String caminho3 = "C:\\Users\\luiz.oliveira\\Documents\\curso.txt";

            UI ui = new UI(caminho, caminho2, caminho3); //Instancia minhas listas e meu UI de console

            while (true) {
                ui.menu();
            }
        }
    }
}
