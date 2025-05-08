namespace StructBeaver.Filas
{
    public class Fila
    {
        private int[] Itens;
        private int Inicio;
        private int Fim;
        private int Tamanho;
        private const int Capacidade = 10;

        public Fila()
        {
            Itens = new int[Capacidade];
            Inicio = 0;
            Fim = 0;
            Tamanho = 0;
        }

        public void Enqueue(int item)
        {
            if (Tamanho == Capacidade)
                throw new InvalidOperationException("Fila cheia.");

            Itens[Fim] = item;
            Fim = Fim + 1;
            Tamanho = Tamanho + 1;
        }

        public int Dequeue()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Fila vazia.");

            int item = Itens[Inicio];
            Inicio = Inicio + 1;
            Tamanho = Tamanho - 1;
            return item;
        }

        public int Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Fila vazia.");

            return Itens[Inicio];
        }

        public bool IsEmpty() => Tamanho == 0;

        public int Size() => Tamanho;
    }
}