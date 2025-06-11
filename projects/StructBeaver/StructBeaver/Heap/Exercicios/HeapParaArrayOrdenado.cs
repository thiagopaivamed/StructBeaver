namespace StructBeaver.Heap.Exercicios
{
    public class HeapParaArrayOrdenado
    {
        public int[] Converter(MaxHeap maxHeap)
        {
            List<int> novaHeap = new();

            while (maxHeap.Tamanho > 0)
                novaHeap.Add(maxHeap.Remover());

            return [.. novaHeap];
        }
    }
}
