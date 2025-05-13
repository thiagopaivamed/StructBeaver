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