---

comments: true

---

# **Implementação padrão de pilhas usando C#**

A linguagem C# já fornece uma estrutura de pilha pronta por meio da classe `Stack<T>`, disponível em `System.Collections.Generic`. As principais operações são: `Push` para inserir elementos, `Pop` para remover o topo e `Peek` para visualizar o topo sem removê-lo. Para verificar o tamanho da pilha ou saber se ela está vazia, utilizamos a propriedade `Count`.

## **Implementação**

```csharp

public class PilhaPadrao
{
    private Stack<int> Itens;

    public PilhaPadrao()
        => Itens = new Stack<int>();

    public void Push(int item) => Itens.Push(item);

    public int Pop() => Itens.Pop();

    public int Peek() => Itens.Peek();

    public bool IsEmpty() => Itens.Count == 0;

    public int Tamanho() => Itens.Count;
}

```

=== "Operações em uma pilha"

    ![](pilhas.assets/pilha01.png)