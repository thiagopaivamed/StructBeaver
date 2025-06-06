---

comments: true

---

# **Implementação padrão de heaps em C#**

Na linguagem C#, a estrutura de heap já está implementada nativamente na forma de uma fila de prioridade mínima (Min-Heap), por meio da classe `PriorityQueue<TElement, TPriority>`, disponível no namespace `System.Collections.Generic`.

Essa classe organiza automaticamente os elementos com base em sua prioridade, onde os elementos com menor valor de prioridade são sempre posicionados no topo da fila.

- Para inserir um elemento, utilizamos o método `Enqueue`.

- Para remover o elemento com maior prioridade (menor valor), usamos o método `Dequeue`.

- Para visualizar o elemento no topo sem removê-lo, usamos o método `Peek`.

Essa estrutura é bastante eficiente para cenários que exigem acesso frequente ao menor elemento, como algoritmos de caminho mínimo, agendadores e filas de tarefas priorizadas.

## **Implementação**

```csharp

public class MinHeap
{
    private PriorityQueue<int, int> _fila = new();

    public int Tamanho => _fila.Count;

    public void Inserir(int valor)
        => _fila.Enqueue(valor, valor); 

    public int Remover()
    {
        if (_fila.Count == 0)
            throw new InvalidOperationException("Heap está vazia.");

        return _fila.Dequeue(); 
    }

    public int Peek()
    {
        if (_fila.Count == 0)
            throw new InvalidOperationException("Heap está vazia.");

        return _fila.Peek();
    }
}

```