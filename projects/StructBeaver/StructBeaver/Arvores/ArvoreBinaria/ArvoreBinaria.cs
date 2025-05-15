namespace StructBeaver.Arvores.ArvoreBinaria
{
    public class ArvoreBinaria(NoArvore raiz)
    {
        public NoArvore Raiz = raiz;

        public NoArvore Inserir(int valor)
        {
            NoArvore novoNo = new (valor);

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

        public NoArvore? PesquisarComBfs(int valor)
        {
            if (Raiz is null) 
                return null;

            Queue<NoArvore> nosVisitados = new();
            nosVisitados.Enqueue(Raiz);

            while (nosVisitados.Count > 0)
            {
                NoArvore noAtual = nosVisitados.Dequeue();

                if (noAtual.Valor == valor)
                    return noAtual;

                if (noAtual.NoEsquerdo is not null)
                    nosVisitados.Enqueue(noAtual.NoEsquerdo);

                if (noAtual.NoDireito is not null)
                    nosVisitados.Enqueue(noAtual.NoDireito);
            }

            return null;
        }

        public NoArvore? PesquisarComDfsPreOrdem(int valor)
        {
            if (Raiz is null)
                return null;

            Stack<NoArvore> pilha = new();
            pilha.Push(Raiz);

            while (pilha.Count > 0)
            {
                NoArvore noAtual = pilha.Pop();

                if (noAtual.Valor == valor)
                    return noAtual;
                                
                if (noAtual.NoDireito is not null)
                    pilha.Push(noAtual.NoDireito);

                if (noAtual.NoEsquerdo is not null)
                    pilha.Push(noAtual.NoEsquerdo);
            }

            return null;
        }

        public NoArvore? PesquisarDfsEmOrdem(int valor)
            => PesquisarDfsEmOrdemRecursivo(Raiz, valor);
        
        private NoArvore? PesquisarDfsEmOrdemRecursivo(NoArvore? noAtual, int valor)
        {
            if (noAtual is null)
                return null;

            // Busca na subárvore esquerda
            NoArvore? noEsquerdo = PesquisarDfsEmOrdemRecursivo(noAtual.NoEsquerdo, valor);
            if (noEsquerdo is not null)
                return noEsquerdo;

            // Verifica o nó atual
            if (noAtual.Valor == valor)
                return noAtual;

            // Busca na subárvore direita
            return PesquisarDfsEmOrdemRecursivo(noAtual.NoDireito, valor);
        }

        public NoArvore? PesquisarDfsPosOrdem(int valor)
            => PesquisarDfsPosOrdemRecursivo(Raiz, valor);
        
        private NoArvore? PesquisarDfsPosOrdemRecursivo(NoArvore? noAtual, int valor)
        {
            if (noAtual is null)
                return null;

            // Busca na subárvore esquerda
            NoArvore? noEsquerdo = PesquisarDfsPosOrdemRecursivo(noAtual.NoEsquerdo, valor);
            if (noEsquerdo is not null)
                return noEsquerdo;

            // Busca na subárvore direita
            NoArvore? noDireito = PesquisarDfsPosOrdemRecursivo(noAtual.NoDireito, valor);
            if (noDireito is not null)
                return noDireito;

            // Verifica o nó atual
            if (noAtual.Valor == valor)
                return noAtual;

            return null;
        }

        public void Remover(int valor)
        {
            if (Raiz is null) 
                return;

            if (Raiz.Valor == valor)
            {
                Raiz = RemoverNo(Raiz);
                return;
            }

            RemoverRecursivo(Raiz, valor);
        }

        private void RemoverRecursivo(NoArvore? noPai, int valor)
        {
            if (noPai is null) 
                return;

            if (noPai.NoEsquerdo is not null && noPai.NoEsquerdo.Valor == valor)            
                noPai.NoEsquerdo = RemoverNo(noPai.NoEsquerdo);
            
            else if (noPai.NoDireito is not null && noPai.NoDireito.Valor == valor)            
                noPai.NoDireito = RemoverNo(noPai.NoDireito);
            
            else
            {
                RemoverRecursivo(noPai.NoEsquerdo, valor);
                RemoverRecursivo(noPai.NoDireito, valor);
            }
        }

        private NoArvore? RemoverNo(NoArvore noAtual)
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
            // Promove o filho esquerdo e insere o filho direito no nó mais à direita
            NoArvore novoNo = noAtual.NoEsquerdo;
            NoArvore noDireito = novoNo;
            while (noDireito.NoDireito is not null)
                noDireito = noDireito.NoDireito;

            noDireito.NoDireito = noAtual.NoDireito;

            return novoNo;
        }
    }
}