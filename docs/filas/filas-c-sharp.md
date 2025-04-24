---

comments: true

---

# **Implementação padrão de filas usando C#**

A linguagem C# já fornece uma estrutura de fila pronta por meio da classe `Queue<T>`, disponível em `System.Collections.Generic`. As principais operações são: `Enqueue` para inserir elementos, `Dequeue` para remover o topo e `Peek` para visualizar o topo sem removê-lo. Para verificar o tamanho da pilha ou saber se ela está vazia, utilizamos a propriedade `Count`.

## **Implementação**

```csharp

    public class FilaCSharp
    {
        private Queue<int> itens;

        public FilaCSharp()
            => itens = new Queue<int>();

        public void Enqueue(int item)
            => itens.Enqueue(item);

        public int Dequeue()
            => itens.Dequeue();

        public int Peek()
            => itens.Peek();

        public bool IsEmpty() => itens.Count == 0;

        public int Size() => itens.Count;
    }

```

```csharp

    FilaCSharp fila = new FilaCSharp();

    fila.Enqueue(10);
    Console.WriteLine($"O valor {fila.Peek()} foi adicionado na fila.");

    fila.Enqueue(20);
    Console.WriteLine($"O valor {fila.Peek()} foi adicionado na fila.");

    fila.Enqueue(30);
    Console.WriteLine($"O valor {fila.Peek()} foi adicionado na fila.");


    Console.WriteLine($"O valor {fila.Dequeue()} foi removido da fila.");
    Console.WriteLine($"O valor {fila.Dequeue()} foi removido da fila.");
    Console.WriteLine($"O valor {fila.Dequeue()} foi removido da fila.");

```

=== "Operações em uma fila"

    ![](filas.assets/fila01.png)