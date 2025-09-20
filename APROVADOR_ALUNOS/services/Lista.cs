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

        public void inserir(T elemento)
        {
            No<T> celula = new No<T>(elemento);
            if (tamanho == 0)
            {
                inicio = celula;
            }
            else
            {
                No<T> atual = inicio;
                while (atual.getNo() != null)
                {
                    atual = atual.getNo();
                }
                atual.setNo(celula);
            }
            tamanho++;
        }

        public void remover_final()
        {
            No<T> atual = inicio;

            for (int i = 0; i < tamanho - 2; i++)
            {
                atual = atual.getNo();
            }
            atual.setNo(null);
        }

        public T Buscar(int id)
        {
            No<T> atual = inicio;
            for(int i = 0; i < tamanho; i++)
            {
                if (id == i)
                {
                    return atual.getElemento();
                }
                atual = atual.getNo();
            }
            return default(T);
            
        }

        public void print()
        {
            No<T> atual = inicio;
            while (atual != null)
            {
                Console.WriteLine(atual.getElemento());
                atual = atual.getNo();
            }
        }
    }
}
