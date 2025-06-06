---

comments: true

---

# **Ordenação usando o método da bolha (Bubble Sort)**

O método de ordenação por bolha (Bubble Sort) é um algoritmo simples que percorre um vetor, comparando pares de elementos adjacentes e trocando-os de posição sempre que estão fora de ordem. Esse processo se repete até que todos os elementos estejam organizados na ordem desejada.

## **Algoritmo**

O algoritmo Bubble Sort funciona da seguinte forma:

1. Receba o vetor (ou lista) a ser ordenado e determine seu tamanho (número de elementos).

2. Crie um laço externo que irá controlar o número de passadas pelo vetor — ele irá do primeiro elemento até o penúltimo.

3. Dentro do laço externo, crie um laço interno que percorre o vetor do início até o último elemento não ordenado (ou seja, do  início até `tamanho - i - 1`, onde `i` é o índice da iteração externa).

4. Compare os elementos adjacentes: se o elemento atual for maior que o próximo, troque suas posições.

5. Repita esse processo até que todas as passadas sejam concluídas e o vetor esteja completamente ordenado.

## **Complexidade**

Em termos de complexidade, o Bubble Sort possui desempenho quadrático, ou seja, `O(n²)` no pior e no caso médio — o que o torna ineficiente para conjuntos de dados grandes.

No entanto, em situações onde o vetor já está ordenado, ele realiza apenas uma passada sem efetuar trocas, alcançando assim um desempenho de `O(n)` no melhor caso.

| Caso         | Complexidade |
|--------------|--------------|
| Melhor caso  | O(n)         |
| Caso médio   | O(n²)        |
| Pior caso    | O(n²)        |


!!! tip "Uso no dia-a-dia"

    Ele é ineficiente para conjuntos de dados grandes devido à sua baixa eficiência em termos de tempo de execução.

## **Implementação**

```csharp

public class BubbleSort
{
    public int[] Sort(int[] vetor)
    {
        int quantidadeElementos = vetor.Length;

        for (int indiceAtual = 0; indiceAtual < quantidadeElementos - 1; indiceAtual++)
        {
            for (int proximoIndice = 0; proximoIndice < quantidadeElementos - indiceAtual - 1; proximoIndice++)
            {
                if (vetor[proximoIndice] > vetor[proximoIndice + 1])
                    Swap(vetor, proximoIndice);
            }
        }

        return vetor;
    }    

    private void Swap(int[] vetorDesordenado, int indiceAtual)
        => (vetorDesordenado[indiceAtual + 1], vetorDesordenado[indiceAtual]) = 
            (vetorDesordenado[indiceAtual], vetorDesordenado[indiceAtual + 1]);          
}

```

!!! tip "Tuplas"

    Como você deve ter percebido, estamos utilizando um novo tipo na função Swap: as tuplas. Uma tupla é uma estrutura de dados leve que permite agrupar múltiplos valores — possivelmente de tipos diferentes — em um único objeto, sem a necessidade de criar uma classe ou struct específica para isso. Isso torna o código mais simples e direto, especialmente em operações como a troca de valores, onde conseguimos fazer tudo de forma rápida e concisa com apenas uma linha.


=== "Bubble Sort 1"

    ![](ordenacao.assets/bubblesort01.png)

=== "Bubble Sort 2"

    ![](ordenacao.assets/bubblesort02.png)

=== "Bubble Sort 3"

    ![](ordenacao.assets/bubblesort03.png)

=== "Bubble Sort 4"

    ![](ordenacao.assets/bubblesort04.png)

=== "Bubble Sort 5"

    ![](ordenacao.assets/bubblesort05.png)

=== "Bubble Sort 6"

    ![](ordenacao.assets/bubblesort06.png)

=== "Bubble Sort 7"

    ![](ordenacao.assets/bubblesort07.png)
