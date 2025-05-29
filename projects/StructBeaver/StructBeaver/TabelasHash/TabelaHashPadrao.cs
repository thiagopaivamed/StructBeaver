namespace StructBeaver.TabelasHash
{
    public class TabelaHashPadrao
    {
        private readonly Dictionary<int, int> _tabela;

        public TabelaHashPadrao()
            => _tabela = [];

        public bool Inserir(int chave, int valor)
        {
            if (_tabela.ContainsKey(chave))
                return false;

            _tabela[chave] = valor;
            return true;
        }

        public int? Pesquisar(int chave)
        {
            if (_tabela.TryGetValue(chave, out int valor))
                return valor;

            return null;
        }

        public bool Remover(int chave)
            => _tabela.Remove(chave);
    }
}