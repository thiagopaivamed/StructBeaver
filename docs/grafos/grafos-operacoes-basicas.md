---

comments: true

---

# **Operações básicas em grafos**

As operações em grafos podem ser classificadas em dois tipos principais: aquelas que envolvem vértices e aquelas que envolvem arestas. A forma de implementá-las varia de acordo com a representação escolhida — seja por matriz de adjacência ou por lista de adjacência.

## **Operações usando matriz de adjacência**

Usando um grafo não direcionado como exemplo, podemos considerar as seguintes operações na representação por matriz de adjacência:

- Adição ou remoção de arestas: a modificação é feita diretamente na matriz, acessando a posição correspondente em tempo `O(1)`. No caso de grafos não direcionados, é necessário atualizar as duas posições simétricas da matriz.

- Adição de vértices: requer adicionar uma nova linha e uma nova coluna à matriz, inicializando seus valores com 0. Essa operação tem complexidade `O(n)`.

- Remoção de vértices: envolve a exclusão da linha e da coluna correspondentes ao vértice. No pior caso (remoção da primeira linha e coluna), é preciso deslocar `(n − 1)²` elementos, resultando em complexidade `O(n²)`.

- Inicialização: para criar a matriz de adjacência, é necessário inicializar `n × n` posições com valor 0, o que possui complexidade `O(n²)`.

=== "Inicializando a matriz de adjacência"

    ![](grafos.assets/grafo-matriz-adjacencia.png)

=== "Adição de arestas"

    ![](grafos.assets/grafo-matriz-adjacencia-adicao-aresta.png)

=== "Exclusão de arestas"

    ![](grafos.assets/grafo-matriz-adjacencia-exclusao-aresta.png)

=== "Adição de vértices"

    ![](grafos.assets/grafo-matriz-adjacencia-adicao-vertice.png)

=== "Exclusão de vértices"

    ![](grafos.assets/grafo-matriz-adjacencia-exclusao-vertice.png)

## **Implementação**

Agora vamos implementar a matriz de adjacência do nosso grafo, considerando que ele pode ser direcionado ou não.

```csharp

public class GrafoMatrizAdjacencia
{
    private int[,] matrizAdjacencia;
    private int quantidadeVertices;
    private bool grafoDirecionado;

    public GrafoMatrizAdjacencia(int numVertices, bool direcionado = false)
    {
        if (numVertices <= 0)
            throw new ArgumentException("Número de vértices deve ser maior que zero.", nameof(numVertices));

        quantidadeVertices = numVertices;
        matrizAdjacencia = new int[numVertices, numVertices];
        grafoDirecionado = direcionado;
    }

    public bool AdicionarAresta(int origem, int destino, int peso = 1)
    {
        if (!VerticesSaoValidos(origem, destino))
            return false;

        matrizAdjacencia[origem, destino] = peso;

        if (!grafoDirecionado)
            matrizAdjacencia[destino, origem] = peso;

        return true;
    }

    public bool RemoverAresta(int origem, int destino)
    {
        if (!VerticesSaoValidos(origem, destino))
            return false;

        matrizAdjacencia[origem, destino] = 0;

        if (!grafoDirecionado)
            matrizAdjacencia[destino, origem] = 0;

        return true;
    }

    public bool ExisteAresta(int origem, int destino)
        => VerticesSaoValidos(origem, destino) && matrizAdjacencia[origem, destino] != 0;

    private bool VerticesSaoValidos(int origem, int destino)
        => origem >= 0 && origem < quantidadeVertices &&
        destino >= 0 && destino < quantidadeVertices;
}

```

!!! tip "Grafo não direcionado"
    Em um grafo não direcionado, a aresta possui o mesmo peso em ambas as direções. Por isso, usamos um `if` para garantir que a matriz seja atualizada em ambos os sentidos.


## **Operações usando lista de adjacência**

Usando um grafo não direcionado com `n` vértices e `m` arestas como exemplo, podemos analisar as principais operações em uma lista de adjacência:

- Adição de arestas: insere-se a aresta ao final da lista encadeada correspondente ao vértice, com tempo de execução `O(1)`. Em um grafo direcionado, a inserção ocorre apenas em uma direção; já em um grafo não direcionado, é necessário adicionar a aresta em ambas as direções.

- Remoção de arestas: consiste em localizar e excluir a aresta dentro da lista encadeada de um vértice, com tempo `O(n)` no pior caso. Em grafos não direcionados, a remoção deve ser feita em ambas as listas envolvidas.

- Adição de vértices: adiciona-se uma nova lista encadeada à lista de adjacência, representando o novo vértice, com tempo `O(1)`.

- Remoção de vértices: é necessário percorrer toda a estrutura para remover o vértice e todas as arestas associadas a ele, resultando em tempo `O(n + m)`.

- Inicialização: envolve a criação dos `n` vértices e das `m` arestas, com tempo total `O(n + m)`.

=== "Inicializando a lista de adjacência"

    ![](grafos.assets/grafo-inicializando-lista-adjacencia.png)

=== "Adição de arestas"

    ![](grafos.assets/grafo-lista-adjacencia-adicao-arestas.png)

=== "Exclusão de arestas"

    ![](grafos.assets/grafo-lista-adjacencia-remocao-arestas.png)

=== "Adição de vértices"

    ![](grafos.assets/grafo-lista-adjacencia-adicao-vertices.png)

=== "Exclusão de vértices"

    ![](grafos.assets/grafo-lista-adjacencia-remocao-vertices.png)

## **Implementação**

Agora vamos implementar a lista de adjacência do nosso grafo, considerando que ele pode ser direcionado ou não.

```csharp

public class GrafoListaAdjacencia
{
    private List<List<int>> adjacencias;
    private bool grafoDirecionado;
    public int numeroDeVertices => adjacencias.Count;

    public GrafoListaAdjacencia(int numeroVertices, bool direcionado = false)
    {
        adjacencias = new List<List<int>>(numeroVertices);
        grafoDirecionado = direcionado;

        for (int i = 0; i < numeroVertices; i++)
            adjacencias.Add(new List<int>());
    }

    public void AdicionarAresta(int origem, int destino)
    {
        adjacencias[origem].Add(destino);

        if (!grafoDirecionado)
            adjacencias[destino].Add(origem);
    }

    public void RemoverAresta(int origem, int destino)
    {
        adjacencias[origem].Remove(destino);

        if (!grafoDirecionado)
            adjacencias[destino].Remove(origem);
    }

    public void AdicionarVertice()
        => adjacencias.Add(new List<int>());

    public void RemoverVertice(int vertice)
    {
        adjacencias.RemoveAt(vertice);

        foreach (List<int> lista in adjacencias)
            lista.Remove(vertice);

        for (int i = 0; i < adjacencias.Count; i++)
        {
            for (int j = 0; j < adjacencias[i].Count; j++)
            {
                int verticeAtual = adjacencias[i][j];

                if (verticeAtual > vertice)
                    adjacencias[i][j] = verticeAtual - 1;
            }
        }
    }        

    public List<int> ObterAdjacencias(int vertice)
    {
        if (vertice < 0 || vertice >= adjacencias.Count)
            throw new ArgumentOutOfRangeException(nameof(vertice));

        return adjacencias[vertice];
    }

    public bool TemAresta(int origem, int destino)
    {
        if (origem < 0 || origem >= adjacencias.Count)
            throw new ArgumentOutOfRangeException(nameof(origem));
        if (destino < 0 || destino >= adjacencias.Count)
            throw new ArgumentOutOfRangeException(nameof(destino));
        return adjacencias[origem].Contains(destino);
    }
}

```
