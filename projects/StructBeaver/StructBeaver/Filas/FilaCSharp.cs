namespace StructBeaver.Filas
{
    public class FilaCSharp
    {
        private Queue<int> itens;

        public FilaCSharp()
            => itens = new Queue<int>();

        public void Enqueue(int item)
            => itens.Enqueue(item);

        public int Dequeue()
            => itens.Dequeue();

        public int Peek()
            => itens.Peek();

        public bool IsEmpty() => itens.Count == 0;

        public int Size() => itens.Count;
    }
}
