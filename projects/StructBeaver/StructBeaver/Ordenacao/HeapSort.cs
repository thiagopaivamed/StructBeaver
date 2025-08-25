namespace StructBeaver.Ordenacao
{
    public class HeapSort
    {
        public void Sort(int[] array)
        {
            int tamanho = array.Length;

            for (int i = tamanho / 2 - 1; i >= 0; i--)
                Heapify(array, tamanho, i);

            for (int i = tamanho - 1; i >= 0; i--)
            {
                Trocar(array, 0, i);

                Heapify(array, i, 0);
            }
        }

        private void Heapify(int[] array, int tamanho, int indice)
        {
            int indiceMaiorValor = indice;
            int indiceFilhoEsquerdo = 2 * indice + 1;
            int indiceFilhoDireito = 2 * indice + 2;

            if (indiceFilhoEsquerdo < tamanho && array[indiceFilhoEsquerdo] > array[indiceMaiorValor])
                indiceMaiorValor = indiceFilhoEsquerdo;

            if (indiceFilhoDireito < tamanho && array[indiceFilhoDireito] > array[indiceMaiorValor])
                indiceMaiorValor = indiceFilhoDireito;

            if (indiceMaiorValor != indice)
            {
                Trocar(array, indice, indiceMaiorValor);
                Heapify(array, tamanho, indiceMaiorValor);
            }
        }

        private void Trocar(int[] array, int i, int j)
            => (array[j], array[i]) = (array[i], array[j]);        
    }
}