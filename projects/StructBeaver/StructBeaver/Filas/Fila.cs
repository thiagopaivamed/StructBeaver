namespace StructBeaver.Filas
{
    public class Fila
    {
        private int[] itens;
        private int inicio;
        private int fim;
        private int tamanho;
        private const int capacidade = 10;

        public Fila()
        {
            itens = new int[capacidade];
            inicio = 0;
            fim = 0;
            tamanho = 0;
        }

        public void Enqueue(int item)
        {
            if (tamanho == capacidade)
                throw new InvalidOperationException("Fila cheia.");

            itens[fim] = item;
            fim = fim + 1;
            tamanho = tamanho + 1;
        }

        public int Dequeue()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Fila vazia.");

            int item = itens[inicio];
            inicio = inicio + 1;
            tamanho = tamanho - 1;
            return item;
        }

        public int Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Fila vazia.");

            return itens[inicio];
        }

        public bool IsEmpty() => tamanho == 0;

        public int Size() => tamanho;
    }
}