namespace Ordenacao
{
    public class MetodosOrdenacao
    {
        public int[] BubbleSort(int[] vetor)
        {
            int quantidadeElementos = vetor.Length;

            for (int indice = 0; indice < quantidadeElementos - 1; indice++)
            {
                for (int indiceAux = 0; indiceAux < quantidadeElementos - indice - 1; indiceAux++)
                {
                    if (vetor[indiceAux] > vetor[indiceAux + 1])
                        Swap(vetor, indiceAux);
                }
            }

            return vetor;
        }

        private void Swap(int[] vetorDesordenado, int indice)
        {
            int auxiliar = vetorDesordenado[indice];
            vetorDesordenado[indice] = vetorDesordenado[indice + 1];
            vetorDesordenado[indice + 1] = auxiliar;
        }
    }
}
