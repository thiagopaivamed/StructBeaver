namespace StructBeaver.Ordenacao
{
    public class BubbleSort
    {
        public int[] Sort(int[] vetor)
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

        public int[] RecursiveSort(int[] vetor, int quantidadeElementos)
        {
            if (quantidadeElementos == 1)
                return vetor;

            for (int indice = 0; indice < quantidadeElementos - 1; indice++)
            {
                if (vetor[indice] > vetor[indice + 1])
                    Swap(vetor, indice);
            }

            return RecursiveSort(vetor, quantidadeElementos - 1);
        }

        private void Swap(int[] vetorDesordenado, int indiceAtual)
        {
            int valorTemporario = vetorDesordenado[indiceAtual];
            vetorDesordenado[indiceAtual] = vetorDesordenado[indiceAtual + 1];
            vetorDesordenado[indiceAtual + 1] = valorTemporario;
        }
    }
}
