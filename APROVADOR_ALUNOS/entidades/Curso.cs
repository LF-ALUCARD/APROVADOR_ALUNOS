using APROVADOR_ALUNOS.entidades.PK;
using APROVADOR_ALUNOS.services.alunos;
using APROVADOR_ALUNOS.services.disciplina;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APROVADOR_ALUNOS.entidades
{
    internal class Curso
    {
        private Aluno_Curso aluno;
        private float nota1;
        private float nota2;

        public Curso() { }

        public Curso (int matricula, int codicoDisciplina, float nota1, float nota2)
        {
            aluno.setAluno(ServicosAlunos.Buscar_Matricula(matricula)); // Busca o aluno da lista de Matricula
            aluno.setDisciplina(ServicosDisciplina.Buscar_codigo(codicoDisciplina));
            this.nota1 = nota1;
            this.nota2 = nota2;
        }

        public float getNota1() { return nota1; }
        public void setNota1(float nota1) { this.nota1 = nota1; }

        public float getNota2() { return nota2; }
        public void setNota2(float nota2) { this.nota2 = nota2; }

        public override string ToString()
        {
            return $"Matricula: {this.aluno.getAluno().getMatricula} || Códico Disciplina: {this.aluno.getDisciplina().getCodicoDisciplina} " +
                $"|| 1° Nota: {this.nota1} || 2° Nota: {this.nota2}";
        }

    }
}
