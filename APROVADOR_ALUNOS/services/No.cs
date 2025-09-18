using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APROVADOR_ALUNOS.services
{
    internal class No<T>
    {
        private T elemento;
        private No<T> no;

        public No(T elemento)
        {
            this.elemento = elemento;
            this.no = null;
        }

        public No(T elemento, No<T> no)
        {
            this.elemento = elemento;
            this.no = no;
        }

        public T getElemento() { return elemento; }
        public void setElemento(T elemento) { this.elemento = elemento; }

        public No<T> getNo() { return no; }
        public void setNo(No<T> no) { this.no = no; }
    }
}
