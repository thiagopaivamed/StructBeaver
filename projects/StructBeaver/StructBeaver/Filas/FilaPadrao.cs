namespace StructBeaver.Filas
{
    public class FilaPadrao
    {
        private Queue<int> Itens;

        public FilaPadrao()
            => Itens = new Queue<int>();

        public void Enqueue(int item)
            => Itens.Enqueue(item);

        public int Dequeue()
            => Itens.Dequeue();

        public int Peek()
            => Itens.Peek();

        public bool IsEmpty() => Itens.Count == 0;

        public int Size() => Itens.Count;
    }
}
