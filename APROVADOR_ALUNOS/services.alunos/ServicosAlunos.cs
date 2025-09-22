using APROVADOR_ALUNOS.entidades;
using System;
using APROVADOR_ALUNOS.services;
namespace APROVADOR_ALUNOS.services.alunos
{
    internal class ServicosAlunos
    {
        private static Lista<Aluno> lista = new Lista<Aluno>();

        public static Lista<Aluno> iniciar(String caminho) //Método usado para instanciar uma Lista de Alunos
        {
            using (StreamReader sr = new StreamReader(caminho))
            {
                String linha; 
                while ((linha = sr.ReadLine()) != null){ //lógica construida para percorrer o meu arquivo, instanciar e guardar meus objetos.
                    String[] vect = linha.Split(";");
                    Aluno aluno = new Aluno(int.Parse(vect[0]), vect[1], int.Parse(vect[2]));
                    lista.inserir(aluno);
                }
            }
            return lista;
        }

        public static Aluno Buscar_Matricula(int matricula) //Método usado para instanciar um Aluno a partir do Id.
        {
            No<Aluno> atual = lista.getInicio();

            while(atual != null)
            {
                Aluno aluno = atual.getElemento();
                if (matricula == aluno.getMatricula())
                {
                    return aluno;
                }
                atual = atual.getNo();
            }
            return null;
        }

        public static Aluno Buscar_Matricula(Lista<Aluno> listaAlunos, int matricula) //Sobrescrita usada para instanciar minha lista de Curso
        {
            No<Aluno> atual = listaAlunos.getInicio();

            while (atual != null)
            {
                Aluno aluno = atual.getElemento();
                if (aluno.getMatricula() == matricula)
                {
                    return aluno;
                }
                atual = atual.getNo();
            }

            return null;
        }


        public static Aluno Buscar_Nome(String nome) //Método usado para instanciar um Aluno a partir do nome.
        {
            No<Aluno> atual = lista.getInicio();

            while (atual != null)
            {
                Aluno aluno = atual.getElemento();
                if (nome == aluno.getNome())
                {
                    return aluno;
                }
                atual = atual.getNo();
            }
            return null;
        }

        public static Boolean verificador_nome(String nome) //Verificador se o nome procurado está na minha lista
        {
            No<Aluno> atual = lista.getInicio();

            while (atual != null)
            {
                Aluno aluno = atual.getElemento();
                if (nome == aluno.getNome())
                {
                    return true;
                }
                atual = atual.getNo();
            }
            return false;
        }
    }
}
