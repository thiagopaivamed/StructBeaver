namespace StructBeaver.TabelasHash.Exercicios
{
    public class ChavesComNumerosPrimosTabelaHash
    {
        public List<int> PegarChavesComNumerosPrimos(TabelaHash tabela)
        {
            List<int> chavesComPrimos = [];

            foreach (var lista in tabela.Tabela)
            {
                foreach (var (chave, valor) in lista)
                {
                    if (EhPrimo(valor))
                        chavesComPrimos.Add(chave);
                }
            }

            return chavesComPrimos;
        }

        private bool EhPrimo(int numero)
        {
            if (numero <= 1) return false;
            if (numero == 2) return true;
            if (numero % 2 == 0) return false;

            int limite = (int)Math.Sqrt(numero);
            for (int i = 3; i <= limite; i += 2)
            {
                if (numero % i == 0)
                    return false;
            }

            return true;
        }
    }
}