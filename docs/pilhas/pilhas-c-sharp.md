---

comments: true

---

# **Implementação padrão de pilhas usando C#**

A linguagem C# já fornece uma estrutura de pilha pronta por meio da classe `Stack<T>`, disponível em `System.Collections.Generic`. As principais operações são: `Push` para inserir elementos, `Pop` para remover o topo e `Peek` para visualizar o topo sem removê-lo. Para verificar o tamanho da pilha ou saber se ela está vazia, utilizamos a propriedade `Count`.

## **Implementação**

```csharp

public class PilhaCSharp
{
    private Stack<int> itens;

    public PilhaCSharp()
        => itens = new Stack<int>();

    public void Push(int item) => itens.Push(item);

    public int Pop() => itens.Pop();

    public int Peek() => itens.Peek();

    public bool IsEmpty() => itens.Count == 0;

    public int Tamanho() => itens.Count;
}

```

```csharp

PilhaCSharp pilha = new PilhaCSharp();
pilha.Push(10);
Console.WriteLine($"O elemento {pilha.Peek()} foi adicionado na pilha.");

pilha.Push(15);
Console.WriteLine($"O elemento {pilha.Peek()} foi adicionado na pilha.");

pilha.Push(20);
Console.WriteLine($"O elemento {pilha.Peek()} foi adicionado na pilha.");

Console.WriteLine($"O elemento {pilha.Pop()} foi removido da pilha.");
Console.WriteLine($"O elemento {pilha.Pop()} foi removido da pilha.");
Console.WriteLine($"O elemento {pilha.Pop()} foi removido da pilha.");

```

=== "Operações em uma pilha"

    ![](pilhas.assets/pilha01.png)