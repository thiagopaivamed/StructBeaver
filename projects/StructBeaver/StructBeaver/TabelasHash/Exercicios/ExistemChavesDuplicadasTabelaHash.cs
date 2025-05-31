namespace StructBeaver.TabelasHash.Exercicios
{
    public class ExistemChavesDuplicadasTabelaHash
    {
        public bool Verificar(TabelaHash tabelaHash)
        {
            List<int> chavesEncontradas = [];

            foreach (LinkedList<(int, int)> linhaTabelaHash in tabelaHash.Tabela)
            {
                foreach ((int chave, int valor) in linhaTabelaHash)
                {
                    if (chavesEncontradas.Contains(chave))
                        return true;

                    chavesEncontradas.Add(chave);
                }
            }

            return false;
        }
    }
}