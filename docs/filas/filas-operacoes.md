---

comments: true

---

# **Filas e suas operações**

Filas são estruturas de dados do tipo `FIFO (First In, First Out)`, em que o primeiro elemento inserido é o primeiro a ser removido. Assim como em uma fila de atendimento, apenas o elemento na frente está disponível para acesso imediato. Suas operações principais incluem: `Enqueue`, para adicionar um elemento ao final; `Dequeue`, para remover e retornar o primeiro elemento; `Peek` ou `Front`, para visualizar o primeiro elemento sem removê-lo; `IsEmpty`, para verificar se a fila está vazia; e `Size`, que retorna a quantidade de elementos na fila.

## **Inserção de dados (Enqueue)**

A inserção de elementos em uma fila ocorre sempre ao final da estrutura, de forma direta, sem a necessidade de percorrê-la. Por isso, essa operação possui complexidade de tempo constante, ou seja, `O(1)`.

## **Remoção de dados (Dequeue)**

A remoção de elementos em uma fila ocorre sempre no início da estrutura, de forma direta e sem a necessidade de percorrer os dados. Por isso, essa operação também possui complexidade constante, ou seja, `O(1)`.

## **Pegando dados (Peek)**

Qualquer tentativa de acesso a um elemento em uma fila sempre retornará o primeiro item, sem a necessidade de percorrer a estrutura. Por esse motivo, a operação também apresenta complexidade constante, ou seja, `O(1)`.

## **Verificando se a fila está vazia (IsEmpty)**

Nesse caso, o que ocorre é apenas a verificação da existência de um elemento na primeira posição da fila, uma operação simples e direta, que também possui complexidade constante, ou seja, `O(1)`.

## **Verificando o tamanho da fila (Size)**

Ao manter um contador atualizado na estrutura da fila, é possível obter seu tamanho diretamente, sem percorrer os elementos. Dessa forma, a complexidade da operação permanece constante, ou seja, `O(1)`.

## **Implementação**

```csharp

public class Fila
{
    private int[] itens;
    private int inicio;
    private int fim;
    private int tamanho;
    private const int capacidade = 10;

    public Fila()
    {
        itens = new int[capacidade];
        inicio = 0;
        fim = 0;
        tamanho = 0;
    }

    public void Enqueue(int item)
    {
        if (tamanho == capacidade)
            throw new InvalidOperationException("Fila cheia.");

        itens[fim] = item;
        fim = fim + 1;
        tamanho = tamanho + 1;
    }

    public int Dequeue()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Fila vazia.");

        int item = itens[inicio];
        inicio = inicio + 1;
        tamanho = tamanho - 1;
        return item;
    }

    public int Peek()
    {
        if (IsEmpty())
            throw new InvalidOperationException("Fila vazia.");

        return itens[inicio];
    }

    public bool IsEmpty() => tamanho == 0;

    public int Size() => tamanho;
}

```

```csharp

Fila fila = new Fila();

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