using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APROVADOR_ALUNOS.entidades
{
    internal class Disciplina
    {
        private int codicoDisciplina;
        private String nome;
        private float notaMinima;

        public Disciplina() { }

        public Disciplina(int codicoDisciplina, string nome, float notaMinima)
        {
            this.codicoDisciplina = codicoDisciplina;
            this.nome = nome;
            this.notaMinima = notaMinima;
        }

        public int getCodicoDisciplina() { return codicoDisciplina; }
        public void setCodicoDisciplina(int codicoDisciplina) { this.codicoDisciplina = codicoDisciplina; }

        public String getNome() { return nome; }
        public void setNome(String nome) { this.nome = nome; }

        public float getNotaMinima() { return notaMinima; }
        public void setNotaMinma(float notaMinima) { notaMinima = notaMinima; }

        public override string ToString()
        {
            return $"Códico Disciplina: {this.codicoDisciplina} || Nome: {this.nome} || Nota Minima: {this.notaMinima}";
        }
    }
}
