using APROVADOR_ALUNOS.entidades;
using APROVADOR_ALUNOS.services;

namespace APROVADOR_ALUNOS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista<Aluno> lista = new Lista<Aluno>();
            
            Aluno obj1 = new Aluno(48569, "BOT 1", 20);
            Aluno obj2 = new Aluno(48756, "BOT 2", 25);
            Aluno obj3 = new Aluno(48852, "BOT 3", 18);

            lista.inserir(obj1);
            lista.inserir(obj2);
            lista.inserir(obj3);

            Aluno busca = lista.Buscar(1);

            Console.WriteLine(busca);
        }
    }
}
