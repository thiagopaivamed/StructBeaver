namespace Ordenacao
{
    public class MetodosOrdenacao
    {
        public int[] BubbleSort(int[] vetor)
        {
            int quantidadeElementos = vetor.Length;

            for (int indiceAtual = 0; indiceAtual < quantidadeElementos - 1; indiceAtual++)
            {
                for (int proximoIndice = 0; proximoIndice < quantidadeElementos - indiceAtual - 1; proximoIndice++)
                {
                    if (vetor[proximoIndice] > vetor[proximoIndice + 1])
                        Swap(vetor, proximoIndice);
                }
            }

            return vetor;
        }

        public int[] BubbleSortRecursivo(int[] vetor, int quantidadeElementos)
        {
            if (quantidadeElementos == 1)
                return vetor;

            for (int indice = 0; indice < quantidadeElementos - 1; indice++)
            {
                if (vetor[indice] > vetor[indice + 1])
                    Swap(vetor, indice);
            }

            return BubbleSortRecursivo(vetor, quantidadeElementos - 1);
        }

        private void Swap(int[] vetorDesordenado, int indiceAtual)
        {
            int valorTemporario = vetorDesordenado[indiceAtual];
            vetorDesordenado[indiceAtual] = vetorDesordenado[indiceAtual + 1];
            vetorDesordenado[indiceAtual + 1] = valorTemporario;
        }

        public int[] SelectionSort(int[] vetor)
        {
            int indiceMenorValor;
            int quantidadeElementos = vetor.Length;

            for (int indiceAtual = 0; indiceAtual < quantidadeElementos - 1; indiceAtual++)
            {
                indiceMenorValor = indiceAtual;

                for (int proximoIndice = indiceAtual + 1; proximoIndice < quantidadeElementos; proximoIndice++)
                {
                    if (vetor[proximoIndice] < vetor[indiceMenorValor])
                        indiceMenorValor = proximoIndice;
                }

                if (vetor[indiceAtual] != vetor[indiceMenorValor])
                    Swap(vetor, indiceAtual, indiceMenorValor);
            }

            return vetor;
        }

        public int[] SelectionSortRecursivo(int[] vetor, int quantidadeElementos, int indice = 0)
        {
            if (indice >= quantidadeElementos - 1)
                return vetor;

            int indiceMenorValor = indice;

            for (int proximoIndice = indice + 1; proximoIndice < quantidadeElementos; proximoIndice++)
            {
                if (vetor[proximoIndice] < vetor[indiceMenorValor])
                    indiceMenorValor = proximoIndice;
            }

            if (vetor[indice] != vetor[indiceMenorValor])
                Swap(vetor, indice, indiceMenorValor);

            return SelectionSortRecursivo(vetor, quantidadeElementos, indice + 1);
        }

        private void Swap(int[] vetorDesordenado, int indiceAtual, int indiceMenorValor)
        {
            int valorTemporario = vetorDesordenado[indiceAtual];
            vetorDesordenado[indiceAtual] = vetorDesordenado[indiceMenorValor];
            vetorDesordenado[indiceMenorValor] = valorTemporario;
        }

        public int[] InsertionSort(int[] vetor)
        {
            int quantidadeElementos = vetor.Length;

            for (int indiceAtual = 1; indiceAtual < quantidadeElementos; indiceAtual++)
            {
                int valorTemporario = vetor[indiceAtual];
                int indiceAuxiliar = indiceAtual - 1;

                while (indiceAuxiliar >= 0 && vetor[indiceAuxiliar] > valorTemporario)
                {
                    vetor[indiceAuxiliar + 1] = vetor[indiceAuxiliar];
                    indiceAuxiliar = indiceAuxiliar - 1;
                }

                vetor[indiceAuxiliar + 1] = valorTemporario;
            }

            return vetor;
        }
    }
}
