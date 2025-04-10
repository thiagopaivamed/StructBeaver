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

            for(int indiceAtual = 0; indiceAtual < quantidadeElementos - 1; indiceAtual++)
            {
                indiceMenorValor = indiceAtual;

                for(int proximoIndice = indiceAtual + 1; proximoIndice < quantidadeElementos; proximoIndice++)
                {
                    if (vetor[proximoIndice] < vetor[indiceMenorValor])
                        indiceMenorValor = proximoIndice;
                }

                if (vetor[indiceAtual] != vetor[indiceMenorValor])
                    Swap(vetor, indiceAtual, indiceMenorValor);
            }

            return vetor;
        }

        private void Swap(int[] vetorDesordenado, int indiceAtual, int indiceMenorValor)
        {
            int valorTemporario = vetorDesordenado[indiceAtual];
            vetorDesordenado[indiceAtual] = vetorDesordenado[indiceMenorValor];
            vetorDesordenado[indiceMenorValor] = valorTemporario;
        }
    }
}
