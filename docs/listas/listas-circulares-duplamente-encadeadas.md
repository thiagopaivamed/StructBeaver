---

comments: true

---

# **Listas circulares duplamente encadeadas**

Uma lista circular duplamente encadeada é semelhante a uma lista duplamente encadeada, com a diferença de que a referência que aponta para o elemento anterior do primeiro nó passa a apontar para o último nó, e a referência que aponta para o próximo nó do último nó passa a apontar para o primeiro nó da lista. Com essa estrutura circular, não é necessário manter uma variável separada para o último nó.

## **Implementação**

Observe que, ao inicializar um nó, ele é configurado para apontar para si mesmo, tanto no ponteiro `Proximo` quanto no ponteiro `Anterior`, garantindo a circularidade da lista desde o início.

```csharp

public class ListaCircularDuplamenteEncadeada
{
    public class No
    {
        public int Valor;
        public No Proximo;
        public No Anterior;

        public No(int valor)
        {
            Valor = valor;
            Proximo = this;
            Anterior = this;
        }
    }

    public No? primeiroNo;

    public No? AdicionarNoInicio(int valor)
    {
        No novoNo = new No(valor);

        if (primeiroNo == null)            
            primeiroNo = novoNo;
        
        else
        {
            No ultimoNo = primeiroNo.Anterior;

            novoNo.Proximo = primeiroNo;
            novoNo.Anterior = ultimoNo;

            primeiroNo.Anterior = novoNo;
            ultimoNo.Proximo = novoNo;

            primeiroNo = novoNo;
        }

        return novoNo;  
    }

    public No? AdicionarNoFim(int valor)
    {
        No novoNo = new No(valor);

        if (primeiroNo == null)            
            primeiroNo = novoNo;
        
        else
        {
            No ultimoNo = primeiroNo.Anterior;

            novoNo.Proximo = primeiroNo;
            novoNo.Anterior = ultimoNo;

            ultimoNo.Proximo = novoNo;
            primeiroNo.Anterior = novoNo;
        }

        return novoNo;  
    }

    public No? Remover(int valor)
    {
        if (primeiroNo == null)
            return null;

        No noAtual = primeiroNo;

        do
        {
            if (noAtual.Valor == valor)
            {
                if (noAtual.Proximo == noAtual)                    
                    primeiroNo = null;
                
                else
                {
                    noAtual.Anterior.Proximo = noAtual.Proximo;
                    noAtual.Proximo.Anterior = noAtual.Anterior;

                    if (noAtual == primeiroNo)
                        primeiroNo = noAtual.Proximo;
                }

                noAtual.Proximo = null;
                noAtual.Anterior = null;

                return noAtual; 
            }

            noAtual = noAtual.Proximo;
        } while (noAtual != primeiroNo);

        return null;  
    }
}

```

=== "Lista circular duplamente encadeada"

    ![](listas.assets/listacircularduplamenteencadeada01.png)
