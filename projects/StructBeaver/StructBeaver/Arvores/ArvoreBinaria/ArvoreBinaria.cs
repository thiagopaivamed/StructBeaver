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

        private NoArvore? PesquisarRecursivo(NoArvore? noAtual, int valor)
        {
            if (noAtual is null)
                return null;

            if (noAtual.Valor == valor)
                return noAtual;

            NoArvore? noPesquisaLadoEsquerdo = PesquisarRecursivo(noAtual.NoEsquerdo, valor);

            if (noPesquisaLadoEsquerdo is not null)
                return noPesquisaLadoEsquerdo;

            return PesquisarRecursivo(noAtual.NoDireito, valor);
        }

        public void Remover(int valor)
            => Raiz = RemoverRecursivo(Raiz, valor);

        private NoArvore? RemoverRecursivo(NoArvore? noAtual, int valor)
        {
            if (noAtual is null)
                return null;

            if (valor < noAtual.Valor)
                noAtual.NoEsquerdo = RemoverRecursivo(noAtual.NoEsquerdo, valor);
            
            else if (valor > noAtual.Valor)
                noAtual.NoDireito = RemoverRecursivo(noAtual.NoDireito, valor);
            
            else
            {
                // Caso 1: Sem filhos
                if (noAtual.NoEsquerdo is null && noAtual.NoDireito is null)
                    return null;

                // Caso 2: Um filho
                if (noAtual.NoEsquerdo is null)
                    return noAtual.NoDireito;

                if (noAtual.NoDireito is null)
                    return noAtual.NoEsquerdo;

                // Caso 3: Dois filhos
                NoArvore noSucessor = EncontrarMinimo(noAtual.NoDireito);
                noAtual.Valor = noSucessor.Valor;
                noAtual.NoDireito = RemoverRecursivo(noAtual.NoDireito, noSucessor.Valor.Value);
            }

            return noAtual;
        }

        private NoArvore EncontrarMinimo(NoArvore? noAtual)
        {
            while (noAtual?.NoEsquerdo is not null)
                noAtual = noAtual.NoEsquerdo;

            return noAtual;
        }
    }
}