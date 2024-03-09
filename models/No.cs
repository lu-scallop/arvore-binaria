using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArvoreBinariaPTI.models
{
    public class No
    {
        public int Valor { get; set; }

        public No Esq { get; set; }

        public No Dir { get; set; }

        public No(int valor)
        {
            this.Valor = valor;
        }
    }
    public class ArvoreBinaria
    {
        public No Raiz { get; set; }
        public void Adiciona(int valor)
        {
            No novoNo = new No(valor);

            if (Raiz == null)
            {
                Raiz = novoNo;
            }
            else
            {
                No atual = Raiz;

                while (true)
                {
                    if (valor < atual.Valor)
                    {
                        if (atual.Esq == null)
                        {
                            atual.Esq = novoNo;
                            break; 
                        }
                        else
                        {
                            atual = atual.Esq;
                        }
                    }
                    else if (valor > atual.Valor)
                    {
                        if (atual.Dir == null)
                        {
                            atual.Dir = novoNo;
                            break; 
                        }
                        else
                        {
                            atual = atual.Dir;
                        }
                    }
                    else
                    {
                        return;
                    }
                }
            }
        }
        public int ContarEsquerdaFestiva()
        {
            return ContarEsquerdaFestiva(Raiz, false);
        }
        private int ContarEsquerdaFestiva(No no, bool filhaEsquerda)
        {
            if (no == null)
            {
                return 0;
            }
            else
            {
                int contador = 0;

                if (filhaEsquerda)
                {
                    contador++;
                }
                contador += ContarEsquerdaFestiva(no.Esq, true) + ContarEsquerdaFestiva(no.Dir, false);

                return contador;
            }
        }
        
        public void Imprimir()
        {
            Imprimir(Raiz, 0);
        }
        private void Imprimir(No no, int nivel)
        {
            if (no != null)
            {
                Console.WriteLine(new string(' ', nivel * 4) + no.Valor);

                Imprimir(no.Esq, nivel + 1);
                Imprimir(no.Dir, nivel + 1);
            }
            else
            {
                Console.WriteLine(new string(' ', nivel * 4) + "-");
            }
        }
    }
}