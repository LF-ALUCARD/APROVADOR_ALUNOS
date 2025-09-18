using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APROVADOR_ALUNOS.services
{
    internal class Lista<T>
    {
        private No<T> inicio;
        private int tamanho;
    
        public Lista()
        {
            inicio = null;
            tamanho = 0;
        }

        public int getTamanho() { return tamanho; }

    }
}
