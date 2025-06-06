namespace StructBeaver.Heap
{
    public class MinHeap
    {
        private PriorityQueue<int, int> _fila = new();

        public int Tamanho => _fila.Count;

        public void Inserir(int valor)
            => _fila.Enqueue(valor, valor); 

        public int Remover()
        {
            if (_fila.Count == 0)
                throw new InvalidOperationException("Heap está vazia.");

            return _fila.Dequeue(); 
        }

        public int Peek()
        {
            if (_fila.Count == 0)
                throw new InvalidOperationException("Heap está vazia.");

            return _fila.Peek();
        }
    }
}
