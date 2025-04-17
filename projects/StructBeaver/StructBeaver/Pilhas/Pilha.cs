namespace StructBeaver.Pilhas
{
    public class Pilha
    {
        private int[] itens;
        private int topo;
        private const int capacidade = 10;

        public Pilha()
        {
            itens = new int[capacidade];
            topo = -1;
        }

        public void Push(int item)
        {
            if (topo == itens.Length - 1)
                Redimensionar();

            topo = topo + 1;
            itens[topo] = item;
        }

        public int Pop()
        {
            if (IsEmpty())
                throw new InvalidOperationException("A pilha está vazia.");

            int item = itens[topo];
            itens[topo] = default;
            topo = topo - 1;

            return item;
        }

        public int Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("A pilha está vazia.");

            return itens[topo];
        }

        public bool IsEmpty() => topo == -1;

        public int Tamanho() => topo + 1;

        private void Redimensionar()
        {
            int novaCapacidade = capacidade * 2;
            int[] novosItens = new int[novaCapacidade];

            for (int indice = 0; indice < itens.Length; indice++)
                novosItens[indice] = itens[indice];

            itens = novosItens;
        }
    }
}
