using APROVADOR_ALUNOS.services;

namespace APROVADOR_ALUNOS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista<int> lista = new Lista<int>();

            lista.inserir(1);
            lista.inserir(2);
            lista.inserir(3);

            lista.print();
        }
    }
}
