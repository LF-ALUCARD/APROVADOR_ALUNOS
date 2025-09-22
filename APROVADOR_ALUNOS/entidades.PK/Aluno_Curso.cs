using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APROVADOR_ALUNOS.entidades.PK
{
    internal class Aluno_Curso //CLASSE DA MINHA CHAVE COMPOSTA DE CURSO
    {
        private Aluno aluno;
        private Disciplina disciplina;

        public Aluno_Curso()
        {
        }

        public Aluno getAluno() { return aluno; }
        public void setAluno (Aluno aluno) { this.aluno = aluno; }

        public Disciplina getDisciplina() { return disciplina; }
        public void setDisciplina(Disciplina disciplina) {this.disciplina = disciplina; }
    }
}
