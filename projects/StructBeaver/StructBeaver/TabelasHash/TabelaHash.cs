namespace StructBeaver.TabelasHash
{
    public class TabelaHash
    {
        private readonly int Tamanho;
        public readonly LinkedList<(int chave, int valor)>[] Tabela;

        public TabelaHash(int tamanho)
        {
            Tamanho = tamanho;
            Tabela = new LinkedList<(int, int)>[tamanho];

            for (int i = 0; i < tamanho; i++)
                Tabela[i] = new LinkedList<(int, int)>();
        }

        private int FuncaoHash(int chave)
        {
            int hash = chave % Tamanho;

            if (hash < 0)
                hash = hash + Tamanho;

            return hash;
        }

        public int Inserir(int chave, int valor)
        {
            int indice = FuncaoHash(chave);
            LinkedList<(int chave, int valor)> linhaTabelaHash = Tabela[indice];

            foreach ((int chave, int valor) par in linhaTabelaHash)
            {
                if (par.chave == chave)
                    return -1;           
            }

            linhaTabelaHash.AddLast((chave, valor));
            return indice;
        }

        public List<int> Pesquisar(int chave)
        {
            int indice = FuncaoHash(chave);
            LinkedList<(int chave, int valor)> linhaTabelaHash = Tabela[indice];

            List<int> valores = [];

            foreach ((int chaveAtual, int valor) in linhaTabelaHash)
            {
                if (chaveAtual == chave)
                    valores.Add(valor);
            }

            return valores;
        }


        public bool Remover(int chave, int valor)
        {
            int indice = FuncaoHash(chave);
            LinkedList<(int chave, int valor)> linhaTabelaHash = Tabela[indice];

            bool elementoRemovido = false;
            LinkedListNode<(int chave, int valor)>? atual = linhaTabelaHash.First;

            while (atual is not null)
            {
                LinkedListNode<(int chave, int valor)>? proximo = atual.Next;

                if (atual.Value.chave == chave && atual.Value.valor == valor)
                {
                    linhaTabelaHash.Remove(atual);
                    elementoRemovido = true;
                }

                atual = proximo;
            }

            return elementoRemovido;
        }
    }
}