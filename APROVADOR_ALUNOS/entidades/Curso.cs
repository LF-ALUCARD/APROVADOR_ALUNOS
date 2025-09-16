using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APROVADOR_ALUNOS.entidades
{
    internal class Curso
    {
        private int matricula;
        private int codicoDisciplina;
        private float nota1;
        private float nota2;

        public Curso() { }

        public Curso (int matricula, int codicoDisciplina, float nota1, float nota2)
        {
            this.matricula = matricula;
            this.codicoDisciplina = codicoDisciplina;
            this.nota1 = nota1;
            this.nota2 = nota2;
        }

        public int getMatricula() { return matricula; }
        public void setMatricula(int matricula) {  this.matricula = matricula; }

        public int getCodicoDisciplina() { return codicoDisciplina;}
        public void setCodicoDisciplina(int codicoDisciplina) {this.codicoDisciplina = codicoDisciplina;}

        public float getNota1() { return nota1; }
        public void setNota1(float nota1) { this.nota1 = nota1; }

        public float getNota2() { return nota2; }
        public void setNota2(float nota2) { this.nota2 = nota2; }

        public override string ToString()
        {
            return $"Matricula: {this.matricula} || Códico Disciplina: {this.codicoDisciplina} " +
                $"|| 1° Nota: {this.nota1} || 2° Nota: {this.nota2}";
        }

    }
}
