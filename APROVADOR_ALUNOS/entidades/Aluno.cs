using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APROVADOR_ALUNOS.entidades
{
    internal class Aluno
    {
        private int matricula;
        private String nome;
        private int idade;

        public Aluno () { }

        public Aluno (int matricula, String nome, int idade)
        {
            this.matricula = matricula;
            this.nome = nome;
            this.idade = idade;
        }

        public int getMatricula () { return matricula; }
        public void setMatricula (int matriculo) {  this.matricula = matriculo;}

        public String getNome () { return nome; }
        public void setNome(String nome) { this.nome = nome;}

        public int getIdade () { return idade; }
        public void setIdade (int idade) { this.idade = idade;}

        public override string ToString()
        {
            return $"Nome: {this.nome} || Idade: {this.idade} || Matricula: {this.matricula}";
        }
    }
}
