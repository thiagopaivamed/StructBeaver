namespace StructBeaver.Pilhas
{
    public class Pilha
    {
        private int[] Itens;
        private int Topo;
        private const int Capacidade = 10;

        public Pilha()
        {
            Itens = new int[Capacidade];
            Topo = -1;
        }

        public void Push(int item)
        {
            if (Topo == Itens.Length - 1)
                Redimensionar();

            Topo = Topo + 1;
            Itens[Topo] = item;
        }

        public int Pop()
        {
            if (IsEmpty())
                throw new InvalidOperationException("A pilha está vazia.");

            int item = Itens[Topo];
            Itens[Topo] = default;
            Topo = Topo - 1;

            return item;
        }

        public int Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("A pilha está vazia.");

            return Itens[Topo];
        }

        public bool IsEmpty() => Topo == -1;

        public int Tamanho() => Topo + 1;

        private void Redimensionar()
        {
            int novaCapacidade = Capacidade * 2;
            int[] novosItens = new int[novaCapacidade];

            for (int indice = 0; indice < Itens.Length; indice++)
                novosItens[indice] = Itens[indice];

            Itens = novosItens;
        }
    }
}
