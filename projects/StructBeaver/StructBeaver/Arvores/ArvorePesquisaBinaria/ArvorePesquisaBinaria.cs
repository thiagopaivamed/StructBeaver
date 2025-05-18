namespace StructBeaver.Arvores.ArvorePesquisaBinaria
{
    public class ArvorePesquisaBinaria(NoArvore raiz)
    {
        public NoArvore Raiz = raiz;

        public NoArvore? Inserir(int valor)
            => InserirRecursivo(Raiz, valor);

        private NoArvore? InserirRecursivo(NoArvore noAtual, int valor)
        {
            if (valor < noAtual.Valor)
            {
                if (noAtual.NoEsquerdo is null)
                {
                    noAtual.NoEsquerdo = new(valor);
                    return noAtual.NoEsquerdo;
                }

                else
                    return InserirRecursivo(noAtual.NoEsquerdo, valor);                
            }

            else if (valor > noAtual.Valor)
            {
                if (noAtual.NoDireito == null)
                {
                    noAtual.NoDireito = new NoArvore(valor);
                    return noAtual.NoDireito;
                }

                else
                    return InserirRecursivo(noAtual.NoDireito, valor);                
            }

            // Se valor já existir, não insere
            return null;
        }

        public NoArvore? Pesquisar(int valor)
            => PesquisarRecursivo(Raiz, valor);
        
        private NoArvore? PesquisarRecursivo(NoArvore? noAtual, int valor)
        {
            if (noAtual is null)
                return null;

            if (valor == noAtual.Valor)
                return noAtual;

            if (valor < noAtual.Valor)
                return PesquisarRecursivo(noAtual.NoEsquerdo, valor);

            return PesquisarRecursivo(noAtual.NoDireito, valor);
        }

        public void Remover(int valor)
            => Raiz = RemoverRecursivo(Raiz, valor)!;
        
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
                // Caso 1: nó folha
                if (noAtual.NoEsquerdo is null && noAtual.NoDireito is null)
                    return null;

                // Caso 2: um filho
                if (noAtual.NoEsquerdo is null)
                    return noAtual.NoDireito;

                if (noAtual.NoDireito is null)
                    return noAtual.NoEsquerdo;

                // Caso 3: dois filhos
                NoArvore sucessor = EncontrarMinimo(noAtual.NoDireito);
                noAtual.Valor = sucessor.Valor;
                noAtual.NoDireito = RemoverRecursivo(noAtual.NoDireito, sucessor.Valor);
            }

            return noAtual;
        }

        private NoArvore EncontrarMinimo(NoArvore noAtual)
        {
            while (noAtual.NoEsquerdo is not null)            
                noAtual = noAtual.NoEsquerdo;
            
            return noAtual;
        }
    }
}