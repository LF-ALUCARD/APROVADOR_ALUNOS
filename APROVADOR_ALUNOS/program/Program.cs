using APROVADOR_ALUNOS.entidades;
using APROVADOR_ALUNOS.services;

using APROVADOR_ALUNOS.services.disciplina;

namespace APROVADOR_ALUNOS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String caminho = "C:\\Users\\luiz.oliveira\\Documents\\aluno.txt";
            String caminho2 = "C:\\Users\\luiz.oliveira\\Documents\\disciplina.txt";

            Lista<Disciplina> lista = ServicosDisciplina.iniciar(caminho2);

            lista.print();

            //while (true) {
           //     UI.menu();
           // }

        }
    }
}
