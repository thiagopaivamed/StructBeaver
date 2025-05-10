namespace StructBeaver.Arvores.ArvoreBinaria
{
    public class ArvoreBinaria(NoArvore raiz)
    {
        public NoArvore Raiz = raiz;

        public NoArvore Inserir(int valor)
        {
            NoArvore novoNo = new NoArvore(valor);

            if (Raiz is null)
            {
                Raiz = novoNo;
                return Raiz;
            }

            return InserirRecursivamente(Raiz, novoNo);
        }

        private NoArvore InserirRecursivamente(NoArvore atual, NoArvore novoNo)
        {
            if (novoNo.Valor < atual.Valor)
            {
                if (atual.NoEsquerdo is null)
                {
                    atual.NoEsquerdo = novoNo;
                    return novoNo;
                }

                return InserirRecursivamente(atual.NoEsquerdo, novoNo);
            }

            else
            {
                if (atual.NoDireito is null)
                {
                    atual.NoDireito = novoNo;
                    return novoNo;
                }

                return InserirRecursivamente(atual.NoDireito, novoNo);
            }
        }

        public NoArvore? Pesquisar(int valor)
            => PesquisarRecursivo(Raiz, valor);        

        private NoArvore? PesquisarRecursivo(NoArvore? atual, int valor)
        {
            if (atual is null)
                return null;

            if (atual.Valor == valor)
                return atual;

            NoArvore? noPesquisaLadoEsquerdo = PesquisarRecursivo(atual.NoEsquerdo, valor);

            if (noPesquisaLadoEsquerdo is not null)
                return noPesquisaLadoEsquerdo;

            return PesquisarRecursivo(atual.NoDireito, valor);
        }        
    }
}