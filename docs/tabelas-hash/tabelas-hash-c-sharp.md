---

comments: true

---

# **Implementação padrão da tabela Hash usando C#**

A linguagem C# já oferece uma implementação moderna de tabela hash por meio da classe `Dictionary<TKey, TValue>`, localizada no namespace `System.Collections.Generic`. Essa estrutura é genérica, segura quanto a tipos e otimizada para desempenho. Ela substitui a antiga classe `Hashtable`, presente no namespace `System.Collections`, que é considerada legada e cujo uso não é mais recomendado em novos projetos.

## **Implementação**

```csharp

public class TabelaHashPadrao
{
    public readonly Dictionary<int, int> _tabela;

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

```