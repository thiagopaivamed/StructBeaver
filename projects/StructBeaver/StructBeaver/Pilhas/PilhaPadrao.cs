namespace StructBeaver.Pilhas
{
    public class PilhaPadrao
    {
        private Stack<int> Itens;

        public PilhaPadrao()
            => Itens = new Stack<int>();

        public void Push(int item) => Itens.Push(item);

        public int Pop() => Itens.Pop();

        public int Peek() => Itens.Peek();

        public bool IsEmpty() => Itens.Count == 0;

        public int Tamanho() => Itens.Count;
    }
}
