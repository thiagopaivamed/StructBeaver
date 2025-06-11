namespace StructBeaver.Heap.Exercicios
{
    public class K_esimoMaiorComHeap
    {
        public int? PegarK_esimoMaior(int[] array, int k)
        {
            if (array is null || array.Length < k || k <= 0)
                return null;

            MaxHeap heap = new();

            foreach (int num in array)
                heap.Inserir(num);

            for (int i = 1; i < k; i++)
                heap.Remover();

            return heap.Peek();
        }
    }
}