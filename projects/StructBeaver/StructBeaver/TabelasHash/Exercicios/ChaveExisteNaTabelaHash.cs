namespace StructBeaver.TabelasHash.Exercicios
{
    public class ChaveExisteNaTabelaHash
    {
        public bool Pesquisar(TabelaHash tabela, int chave)
        {
            for (int i = 0; i < tabela.Tabela.Length; i++)
            {
                foreach ((int chaveAtual, int valorAtual) in tabela.Tabela[i])
                {
                    if (chaveAtual == chave)
                        return true;
                }
            }

            return false;
        }
    }
}