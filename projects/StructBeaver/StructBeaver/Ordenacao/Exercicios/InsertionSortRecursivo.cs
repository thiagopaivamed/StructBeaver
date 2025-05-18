namespace StructBeaver.Ordenacao.Exercicios
{
    public class InsertionSortRecursivo
    {
        private InsertionSort _insertionSort;

        public InsertionSortRecursivo()
            => _insertionSort = new();

        public int[] OrdenarRecursivamente(int[] vetor)
            => _insertionSort.RecursiveSort(vetor, vetor.Length);
    }
}
