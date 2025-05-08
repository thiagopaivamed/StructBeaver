---

comments: true

---

# **Pilhas e suas operações**

Pilhas são estruturas de dados do tipo `LIFO (Last In, First Out)`, nas quais o último elemento inserido é o primeiro a ser removido. Funcionam como uma pilha de livros ou pratos, onde apenas o topo está acessível. Suas principais operações são: `push`, para inserir um novo elemento no topo; `pop`, para remover o elemento do topo; `peek` (ou `top`), para visualizar o elemento no topo sem removê-lo; e `isEmpty`, para verificar se a pilha está vazia.

## **Inserção de dados (push)**

Ao inserir dados em uma pilha, se ela estiver cheia, é necessário redimensionar seu tamanho para acomodar os novos elementos. Esse redimensionamento envolve a criação de um novo array e a cópia de todos os elementos existentes, resultando em uma complexidade de tempo `O(n)`. No entanto, quando há espaço disponível, a inserção é direta e ocorre em tempo constante, com complexidade `O(1)`.

| Caso         | Complexidade |
|--------------|--------------|
| Melhor caso  | O(1)         |
| Caso médio   | O(n)         |
| Pior caso    | O(n)         |

## **Remoção de dados (pop)**

A remoção de elementos em uma pilha ocorre sempre no topo, o que torna essa operação simples e direta, com complexidade de tempo constante, ou seja, `O(1)`.

| Caso         | Complexidade |
|--------------|--------------|
| Melhor caso  | O(1)         |
| Caso médio   | O(1)         |
| Pior caso    | O(1)         |

## **Retornando o elemento do topo (peek)**

Quando pegamos o elemento do topo da pilha, não é necessário percorrê-la, pois o elemento já está na posição correta, ou seja, no topo da estrutura. Isso resulta em uma operação de complexidade constante, `O(1)`.

| Caso         | Complexidade |
|--------------|--------------|
| Melhor caso  | O(1)         |
| Caso médio   | O(1)         |
| Pior caso    | O(1)         |

## **Verificando se a pilha está vazia**

A verificação de se a pilha está vazia é realizada por meio de uma simples comparação com o elemento do topo. Portanto, a operação possui complexidade `O(1)`.

| Caso         | Complexidade |
|--------------|--------------|
| Melhor caso  | O(1)         |
| Caso médio   | O(1)         |
| Pior caso    | O(1)         |

!!! tip "Uso no dia-a-dia"

    A estrutura de pilha é comumente utilizada para armazenar o histórico de navegação em navegadores, ações realizadas em editores de texto (como desfazer e refazer), entre outros cenários em que é necessário manter o controle da ordem reversa das operações.

## **Implementação**

```csharp

public class Pilha
{
    private int[] Itens;
    private int Topo;
    private const int Capacidade = 10;

    public Pilha()
    {
        Itens = new int[Capacidade];
        Topo = -1;
    }

    public void Push(int item)
    {
        if (Topo == Itens.Length - 1)
            Redimensionar();

        Topo = Topo + 1;
        Itens[Topo] = item;
    }

    public int Pop()
    {
        if (IsEmpty())
            throw new InvalidOperationException("A pilha está vazia.");

        int item = Itens[Topo];
        Itens[Topo] = default;
        Topo = Topo - 1;

        return item;
    }

    public int Peek()
    {
        if (IsEmpty())
            throw new InvalidOperationException("A pilha está vazia.");

        return Itens[Topo];
    }

    public bool IsEmpty() => Topo == -1;

    public int Tamanho() => Topo + 1;

    private void Redimensionar()
    {
        int novaCapacidade = Capacidade * 2;
        int[] novosItens = new int[novaCapacidade];

        for (int indice = 0; indice < Itens.Length; indice++)
            novosItens[indice] = Itens[indice];

        Itens = novosItens;
    }
}

```

=== "Operações em uma pilha"

    ![](pilhas.assets/pilha01.png)