---

comments: true

---

# **Exercícios de tabelas Hash**

(1) Dada uma tabela hash, implemente uma função que verifique se existem chaves duplicadas.

??? abstract "Existem chaves duplicadas"

    ```csharp
    
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
    
    ```

(2) Dada uma tabela hash, crie uma função para retornar chaves que possuem números primos associados à elas.

??? abstract "Chaves com números primos"

    ```csharp

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

    ```

(3) Dada uma tabela hash, crie uma função para verificar se determinada chave já existe na tabela.

??? abstract "Chave já existe"

    ```csharp

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

    ```

(4) Dada uma tabela hash, crie uma função para verificar se a tabela está vazia.

??? abstract "Tabela está vazia"

    ```csharp

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

    ```

(5) Dada uma tabela hash, crie uma função para retornar a quantidade de chaves.

??? abstract "Quantidade de chaves"

    ```csharp

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

    ```