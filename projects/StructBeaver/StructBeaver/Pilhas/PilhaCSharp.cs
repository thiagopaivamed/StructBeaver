namespace StructBeaver.Pilhas
{
    public class PilhaCSharp
    {
        private Stack<int> itens;

        public PilhaCSharp()
            => itens = new Stack<int>();

        public void Push(int item) => itens.Push(item);

        public int Pop() => itens.Pop();

        public int Peek() => itens.Peek();

        public bool IsEmpty() => itens.Count == 0;

        public int Tamanho() => itens.Count;
    }
}
