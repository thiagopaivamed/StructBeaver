namespace StructBeaver.Ordenacao
{
    public class SelectionSort
    {
        public int[] Sort(int[] vetor)
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

        public int[] RecursiveSort(int[] vetor, int quantidadeElementos, int indice = 0)
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

            return RecursiveSort(vetor, quantidadeElementos, indice + 1);
        }

        private void Swap(int[] vetorDesordenado, int indiceAtual, int indiceMenorValor)
            => (vetorDesordenado[indiceMenorValor], vetorDesordenado[indiceAtual]) = 
                (vetorDesordenado[indiceAtual], vetorDesordenado[indiceMenorValor]);        
    }
}
