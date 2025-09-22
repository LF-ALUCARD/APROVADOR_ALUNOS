using APROVADOR_ALUNOS.entidades;
using System;
using APROVADOR_ALUNOS.services;
namespace APROVADOR_ALUNOS.services.alunos
{
    internal class ServicosAlunos
    {
        public static Lista<Aluno> iniciar(String caminho)
        {
            Lista<Aluno> lista = new Lista<Aluno>();
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
    }
}
