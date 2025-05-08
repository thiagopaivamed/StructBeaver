---

comments: true

---

# **Listas encadeadas e suas operações**

Uma lista encadeada é uma estrutura de dados onde os elementos, chamados de nós, são organizados de forma linear. Diferente de um array, a ordem dos elementos não depende de posições fixas na memória, mas sim de ponteiros (ou referências) que conectam um nó ao próximo.

Cada nó armazena dois dados principais:

1. O valor em si (como um número ou uma string),

2. Um ponteiro para o próximo nó da lista.

Essa estrutura é dinâmica, o que significa que ela pode crescer com novas inserções e diminuir com remoções, sem a necessidade de criar cópias ou redefinir o tamanho da lista — ao contrário do que acontece com arrays fixos.

A flexibilidade da lista encadeada a torna ideal para situações onde o número de elementos pode variar bastante durante a execução do programa.

## **Inserção de nós**

A inserção de um novo nó no início de uma lista encadeada tem complexidade `O(1)`. Isso porque basta criar um novo nó e fazer com que ele aponte para o antigo primeiro nó — um processo direto, que não depende do tamanho da lista.

Já a inserção no final de uma lista simplesmente encadeada, em geral, tem complexidade `O(n)`, pois é necessário percorrer toda a lista até encontrar o último nó. Contudo, se a lista mantiver uma referência direta para o último nó (como em uma implementação com ponteiro para o tail), essa operação pode ser otimizada para `O(1)`.

Por fim, inserir em uma posição específica exige percorrer a lista até o ponto desejado, o que resulta em complexidade `O(n)`, já que, em média, é necessário visitar metade dos elementos.

| Caso         | Complexidade |
|--------------|--------------|
| Melhor caso  | O(1)         |
| Caso médio   | O(n)         |
| Pior caso    | O(n)         |

## **Remoção de nós**

Remover um nó do início de uma lista encadeada é uma operação de complexidade `O(1)`. Isso ocorre porque basta atualizar o ponteiro do primeiro nó para apontar para o segundo — uma ação direta, independente do tamanho da lista.

Por outro lado, a remoção de um nó em uma posição específica ou no final da lista exige percorrer os elementos até o ponto desejado. Como não há acesso direto aos nós anteriores, é necessário visitar cada um sequencialmente até chegar ao nó anterior ao que será removido, apresentando complexidade `O(n)`.

| Caso         | Complexidade |
|--------------|--------------|
| Melhor caso  | O(1)         |
| Caso médio   | O(n)         |
| Pior caso    | O(n)         |

## **Pesquisa de dados**

Como os elementos de uma lista encadeada não estão armazenados de forma contígua na memória, não é possível acessar diretamente um nó específico. Para encontrar um valor, é necessário percorrer a lista a partir do primeiro nó, um a um, até localizar o dado desejado ou atingir o final da lista.

Portanto, a complexidade da operação de busca é `O(n)`, onde `n` representa o número de elementos da lista.

| Caso         | Complexidade |
|--------------|--------------|
| Melhor caso  | O(1)         |
| Caso médio   | O(n)         |
| Pior caso    | O(n)         |

!!! tip "Uso no dia-a-dia"

    Listas encadeadas são amplamente utilizadas em diversos cenários que envolvem estruturas dinâmicas, como listas de reprodução de músicas, carrinhos de compras em plataformas de e-commerce, e gerenciamento de filas de voos em aeroportos, entre outros contextos em que inserções e remoções frequentes de elementos são comuns.

## **Implementação**

Uma lista encadeada é formada por elementos chamados de nós. Por isso, o primeiro passo para sua implementação é criar a classe que representa esses nós.

```csharp

public class No
{
    public int Valor;
    public No Proximo;

    public No(int valor)
    {
        Valor = valor;
        Proximo = null;            
    }
}

```

Agora que temos a estrutura dos nós definida, podemos começar a construir a nossa lista encadeada.

```csharp

public class ListaEncadeada
{
    public No PrimeiroNo;

    public ListaEncadeada()
        => PrimeiroNo = null;

    public No PegarPrimeiroNo() => PrimeiroNo;
    public No AdicionarNoInicio(int valor)
    {
        No novoNo = new No(valor);
        novoNo.Proximo = PrimeiroNo;
        PrimeiroNo = novoNo;

        return PrimeiroNo;
    }

    public No AdicionarNoFim(int valor)
    {
        No novoNo = new No(valor);

        if (PrimeiroNo is null)
        {
            PrimeiroNo = novoNo;
            return novoNo;
        }

        No noAtual = PrimeiroNo;

        while (noAtual.Proximo is not null)
            noAtual = noAtual.Proximo;

        noAtual.Proximo = novoNo;

        return novoNo;
    }

    public No RemoverNoInicio()
    {
        if (PrimeiroNo is null)
            return null;

        No noRemovido = PrimeiroNo;
        PrimeiroNo = PrimeiroNo.Proximo;
        noRemovido.Proximo = null;
        return noRemovido;
    }

    public No RemoverNoFim()
    {
        if (PrimeiroNo is null)
            return null;

        if (PrimeiroNo.Proximo is null)
        {
            No noUnico = PrimeiroNo;
            PrimeiroNo = null;
            return noUnico;
        }

        No noAtual = PrimeiroNo;

        while (noAtual.Proximo.Proximo is not null)
            noAtual = noAtual.Proximo;

        No noRemovido = noAtual.Proximo;
        noAtual.Proximo = null;
        return noRemovido;
    }

    public No RemoverNo(int posicao)
    {
        if (posicao < 0 || PrimeiroNo is null)
            return null;

        if (posicao == 0)
            return RemoverNoInicio();

        No noAtual = PrimeiroNo;
        int indice = 0;

        while (noAtual.Proximo is not null && indice < posicao - 1)
        {
            noAtual = noAtual.Proximo;
            indice = indice + 1;
        }

        if (noAtual.Proximo is null)
            return null;

        No noRemovido = noAtual.Proximo;
        noAtual.Proximo = noRemovido.Proximo;
        noRemovido.Proximo = null;

        return noRemovido;
    }

    public No Pesquisar(int valor)
    {
        No noAtual = PrimeiroNo;

        while (noAtual is not null)
        {
            if (noAtual.Valor == valor)
                return noAtual;

            noAtual = noAtual.Proximo;
        }

        return null;
    }

    public int Size()
    {
        int quantidadeNos = 0;

        No noAtual = PrimeiroNo;

        while (noAtual is not null)
        {
            noAtual = noAtual.Proximo;
            quantidadeNos = quantidadeNos + 1;
        }

        return quantidadeNos;
    }
    public bool IsEmpty()
        => PrimeiroNo is null;
}

```

=== "Inicializando uma lista"

    ![](listas.assets/lista01.png)

=== "Inserção de nós"

    ![](listas.assets/lista02.png)

=== "Remoção de nós"

    ![](listas.assets/lista03.png)