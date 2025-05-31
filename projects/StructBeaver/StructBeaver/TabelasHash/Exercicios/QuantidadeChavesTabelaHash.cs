namespace StructBeaver.TabelasHash.Exercicios
{
    public class QuantidadeChavesTabelaHash
    {
        public int Contar(TabelaHash tabela)
        {
            List<int> chavesUnicas = [];

            for (int i = 0; i < tabela.Tabela.Length; i++)
            {
                foreach ((int chave, int _) in tabela.Tabela[i])
                {
                    if (!chavesUnicas.Contains(chave))
                        chavesUnicas.Add(chave);
                }
            }

            return chavesUnicas.Count;
        }
    }
}