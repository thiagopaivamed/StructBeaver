namespace StructBeaver.TabelasHash.Exercicios
{
    public class EstaVaziaTabelaHash
    {
        public bool Verificar(TabelaHash tabela)
        {
            for (int i = 0; i < tabela.Tabela.Length; i++)
            {
                if (tabela.Tabela[i].Count > 0)
                    return false;
            }

            return true;
        }
    }
}
