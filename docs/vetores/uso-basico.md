---
date:
    created: 03-30-2025
draft: true
readtime: 5
---

# **Uso básico de vetores (Array)**

Vetores são estruturas de dados que armazenam uma sequência de elementos, todos do mesmo tipo. Esses elementos podem ser números, strings, objetos, ou até mesmo outros vetores.


Em programação, os vetores são frequentemente chamados de arrays (ou listas, dependendo da linguagem). Eles são uma forma eficaz de organizar dados para facilitar o acesso, manipulação e processamento.

![Vetores](vetores.assets/vetores.png)

```csharp

int[] vetor = { 9, 2, 5, 1, 0, 7, 10, 3, 8, 7 };

```

## **Operações em vetores**

Para realizar operações em vetores, é necessário acessarmos seus índices. Vamos ver como isso funciona na prática.

### **Acessando seus elementos**

Para o acesso de valores, é necessário utilizar os índices dos vetores. O índice vai de 0 até o tamanho total do vetor -1 (n - 1). Se tentarmos acessar a posição 20 por exemplo, teremos a exceção **IndexOutOfRangeException**.

```csharp

 int[] vetor = { 9, 2, 5, 1, 0, 7, 10, 3, 8, 7 }; 
 
 Console.Writeline(vetor[2]); // 3     

 Console.Writeline(vetor[20]); // Index out of range 

```

!!! note "Adição de elementos"

    Não é possível adicionar elementos em um vetor de tamanho fixo. Seria necessário cria outro vetor, copiar os elementos do primeiro para o segundo e então adicionar os novos elementos.

### **Adição de elementos**

Para a adição de elementos, vamos criar um novo vetor. A quantidade de elementos desse novo vetor será o tamanho do vetor anterior mais a quantidade de novo elementos.

```csharp

int[] vetorAnterior = { 9, 2, 5, 1, 0, 7, 10, 3, 8, 7 }; 
int novoElemento = 15;

int[] vetorNovo = new int[vetorAnterior.Length + 1];

```

Após criarmos o novo vetor com o tamanho extra, basta inserir os elementos lá e depois atualizar o vetor anterior.

```csharp

Array.Copy(vetorAnterior, vetorNovo, vetorAnterior.Length);

vetorNovo[vetorNovo.Length - 1] = novoElemento;

vetorAnterior = vetorNovo;

```


!!! warning "Cuidado com o índice"

    Cuidado para não acessar um posição além do tamanho do vetor e causar a exceção **IndexOufOfRange**.
