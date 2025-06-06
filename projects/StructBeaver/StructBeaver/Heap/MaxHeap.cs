namespace StructBeaver.Heap
{
    public class MaxHeap
    {
        private List<int> _itens = [];

        public int Tamanho => _itens.Count;

        public int Peek()
        {
            if (Tamanho == 0)
                throw new InvalidOperationException("Heap está vazia.");

            return _itens[0];
        }

        public void Inserir(int valor)
        {
            _itens.Add(valor);
            HeapfyUp(Tamanho - 1);
        }

        public int Remover()
        {
            if (Tamanho == 0)
                throw new InvalidOperationException("Heap está vazia.");

            int topo = _itens[0];
            _itens[0] = _itens[Tamanho - 1];
            _itens.RemoveAt(Tamanho - 1);

            HeapifyDown(0);
            return topo;
        }

        private void HeapfyUp(int indice)
        {
            while (TemPai(indice) && _itens[indice] > PegarPai(indice))
            {
                int indicePai = IndicePai(indice);
                Trocar(indice, indicePai);
                indice = indicePai;
            }
        }

        private void HeapifyDown(int indice)
        {
            int maior = indice;
            int filhoEsquerdo = IndiceFilhoEsquerdo(indice);
            int filhoDireito = IndiceFilhoDireito(indice);

            if (filhoEsquerdo < Tamanho && _itens[filhoEsquerdo] > _itens[maior])
                maior = filhoEsquerdo;

            if (filhoDireito < Tamanho && _itens[filhoDireito] > _itens[maior])
                maior = filhoDireito;

            if (maior != indice)
            {
                Trocar(indice, maior);
                HeapifyDown(maior);
            }
        }

        private int IndiceFilhoEsquerdo(int i) => 2 * i + 1;
        private int IndiceFilhoDireito(int i) => 2 * i + 2;
        private int IndicePai(int i) => (i - 1) / 2;

        private bool TemPai(int i) => IndicePai(i) >= 0;

        private int PegarPai(int i) => _itens[IndicePai(i)];

        private void Trocar(int i, int j)
            => (_itens[j], _itens[i]) = (_itens[i], _itens[j]);
    }
}