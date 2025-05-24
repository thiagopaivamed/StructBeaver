namespace StructBeaver.TabelasHash
{
    public class TabelaHash
    {
        private readonly int Tamanho;
        private readonly LinkedList<(int chave, int valor)>[] Tabela;

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
                    return -1; // chave já existe                
            }

            linhaTabelaHash.AddLast((chave, valor));
            return indice;
        }

        public int Buscar(int chave)
        {
            int indice = FuncaoHash(chave);
            LinkedList<(int chave, int valor)> linhaTabelaHash = Tabela[indice];

            foreach ((int chave, int valor) par in linhaTabelaHash)
            {
                if (par.chave == chave)
                    return indice;
            }

            return -1;
        }

        public bool Remover(int chave)
        {
            int indice = FuncaoHash(chave);
            LinkedList<(int chave, int valor)> linhaTabelaHash = Tabela[indice];

            LinkedListNode<(int chave, int valor)>? atual = linhaTabelaHash.First;

            while (atual is not null)
            {
                if (atual.Value.chave == chave)
                {
                    linhaTabelaHash.Remove(atual);
                    return true;
                }

                atual = atual.Next;
            }

            return false;
        }
    }
}