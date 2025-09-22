using APROVADOR_ALUNOS.entidades;
using APROVADOR_ALUNOS.services;
using System;
using System.IO;

namespace APROVADOR_ALUNOS.services.disciplina
{
    internal class ServicosDisciplina
    {
        private static Lista<Disciplina> lista = new Lista<Disciplina>(); //Lista separada para a classe Lista
        public static Lista<Disciplina> iniciar(string caminho) //Instancia minha lista de Disciplinas a partir do meu arquivo
        {
            lista = new Lista<Disciplina>(); // instanciando a lista

            using (StreamReader sr = new StreamReader(caminho))
            {
                string linha;
                while ((linha = sr.ReadLine()) != null) //Lógica para percorrer a minha lista no .txt
                {
                    string[] vect = linha.Split(";");
                    Disciplina disciplina = new Disciplina(int.Parse(vect[0]), vect[1], float.Parse(vect[2]));
                    lista.inserir(disciplina);
                }
            }
            return lista;
        }

        public static Disciplina Buscar_codigo(int codigo) //método stático para instanciar um objeto a partir do Id
        {
            No<Disciplina> atual = lista.getInicio();

            while (atual != null)
            {
                Disciplina disciplina = atual.getElemento();
                if (codigo == disciplina.getCodicoDisciplina())
                {
                    return disciplina;
                }
                atual = atual.getNo();
            }
            return null;
        }

        public static Disciplina Buscar_Nome(String nome) //Método usado para instanciar um Aluno a partir do nome.
        {
            No<Disciplina> atual = lista.getInicio();

            while (atual != null)
            {
                Disciplina disciplina = atual.getElemento();
                if (nome == disciplina.getNome())
                {
                    return disciplina;
                }
                atual = atual.getNo();
            }
            return null;
        }

        public static Disciplina Buscar_codigo(Lista<Disciplina> listaDisciplinas, int codigo) //método stático sobrescrito para instanciar um objeto no Curso
        {
            No<Disciplina> atual = listaDisciplinas.getInicio();

            while (atual != null)
            {
                Disciplina disciplina = atual.getElemento();
                if (disciplina.getCodicoDisciplina() == codigo)
                {
                    return disciplina;
                }
                atual = atual.getNo();
            }

            return null;
        }

        public static Boolean verificador_nome(String nome)
        {
            No<Disciplina> atual = lista.getInicio();

            while (atual != null)
            {
                Disciplina disiciplina = atual.getElemento();
                if (nome == disiciplina.getNome())
                {
                    return true;
                }
                atual = atual.getNo();
            }
            return false;
        }

        public static Boolean verificador_id(int id)
        {
            No<Disciplina> atual = lista.getInicio();

            while (atual != null)
            {
                Disciplina disiciplina = atual.getElemento();
                if (id == disiciplina.getCodicoDisciplina())
                {
                    return true;
                }
                atual = atual.getNo();
            }
            return false;
        }
    }
}
