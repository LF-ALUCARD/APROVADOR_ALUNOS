using APROVADOR_ALUNOS.entidades;
using APROVADOR_ALUNOS.services;
using System;
using System.IO;

namespace APROVADOR_ALUNOS.services.disciplina
{
    internal class ServicosDisciplina
    {
        private static Lista<Disciplina> lista;

        public static Lista<Disciplina> iniciar(string caminho)
        {
            lista = new Lista<Disciplina>(); // instanciando a lista

            using (StreamReader sr = new StreamReader(caminho))
            {
                string linha;
                while ((linha = sr.ReadLine()) != null)
                {
                    string[] vect = linha.Split(";");
                    Disciplina disciplina = new Disciplina(int.Parse(vect[0]), vect[1], float.Parse(vect[2]));
                    lista.inserir(disciplina);
                }
            }
            return lista;
        }

        public static Disciplina Buscar_codigo(int codigo)
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
    }
}
