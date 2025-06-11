namespace StructBeaver.Heap.Exercicios
{
    public class MaxHeapValido
    {
        public bool Validar(MaxHeap heap)
        {
            List<int> itens = [];

            while (heap.Tamanho > 0)
                itens.Add(heap.Remover());

            for (int i = 1; i < itens.Count; i++)
            {
                if (itens[i] > itens[i - 1])
                    return false;
            }

            foreach (int item in itens)
                heap.Inserir(item);

            return true;
        }
    }
}