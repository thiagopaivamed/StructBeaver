namespace StructBeaver.Ordenacao.Exercicios
{
    public class BubbleSortRecursivo
    {
        private BubbleSort _bubbleSort;

        public BubbleSortRecursivo()
            => _bubbleSort = new();

        public int[] OrdenarRecursivamente(int[] vetor)
            => _bubbleSort.RecursiveSort(vetor, vetor.Length);
    }
}