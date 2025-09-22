using APROVADOR_ALUNOS.entidades;
using System;
using APROVADOR_ALUNOS.services;
namespace APROVADOR_ALUNOS.services.alunos
{
    internal class ServicosAlunos
    {
        private static Lista<Aluno> lista = new Lista<Aluno>();

        public static Lista<Aluno> iniciar(String caminho)
        {
            using (StreamReader sr = new StreamReader(caminho))
            {
                String linha;
                while ((linha = sr.ReadLine()) != null){
                    String[] vect = linha.Split(";");
                    Aluno aluno = new Aluno(int.Parse(vect[0]), vect[1], int.Parse(vect[2]));
                    lista.inserir(aluno);
                }
            }
            return lista;
        }

        public static Aluno Buscar_Matricula(int matricula)
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

        public static Aluno Buscar_Matricula(Lista<Aluno> listaAlunos, int matricula)
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


        public static Aluno Buscar_Nome(String nome)
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

        public static Boolean verificador_nome(String nome)
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
