---

comments: true

---

# **Exercícios ordenação**

(1) Implemente o bubble sort de forma recursiva.

??? abstract "Bubble Sort recursivo"

    ```csharp

    public class BubbleSortRecursivo
    {
        public int[] RecursiveSort(int[] vetor, int quantidadeElementos)
        {
            if (quantidadeElementos == 1)
                return vetor;

            for (int indice = 0; indice < quantidadeElementos - 1; indice++)
            {
                if (vetor[indice] > vetor[indice + 1])
                    Swap(vetor, indice);
            }

            return RecursiveSort(vetor, quantidadeElementos - 1);
        }

        private void Swap(int[] vetorDesordenado, int indiceAtual)
        {
            int valorTemporario = vetorDesordenado[indiceAtual];
            vetorDesordenado[indiceAtual] = vetorDesordenado[indiceAtual + 1];
            vetorDesordenado[indiceAtual + 1] = valorTemporario;
        }
    }

    ```

    ```csharp

    int[] vetorDesordenado = [3, 7, 5, 9, 4, 1];

    int[] vetorOrdenado = _bubbleSortRecursivo.OrdenarRecursivamente(vetorDesordenado);

    Console.WriteLine($"O vetor ordenado é: {string.Join(", ", vetorOrdenado)}.");

    ```

(2) Implemente o selection sort de forma recursiva.

??? abstract "Bubble Sort recursivo"

    ```csharp

    public class SelectionSortRecursivo
    {
        public int[] RecursiveSort(int[] vetor, int quantidadeElementos, int indice = 0)
        {
            if (indice >= quantidadeElementos - 1)
                return vetor;

            int indiceMenorValor = indice;

            for (int proximoIndice = indice + 1; proximoIndice < quantidadeElementos; proximoIndice++)
            {
                if (vetor[proximoIndice] < vetor[indiceMenorValor])
                    indiceMenorValor = proximoIndice;
            }

            if (vetor[indice] != vetor[indiceMenorValor])
                Swap(vetor, indice, indiceMenorValor);

            return RecursiveSort(vetor, quantidadeElementos, indice + 1);
        }
    }

    ```

    ```csharp

    int[] vetorDesordenado = [3, 7, 5, 9, 4, 1];

    SelectionSortRecursivo selectionSortRecursivo = new SelectionSortRecursivo();
    int[] vetorOrdenado = selectionSortRecursivo.RecursiveSort(vetorDesordenado);

    Console.WriteLine($"O vetor ordenado é: {string.Join(", ", vetorOrdenado)}.");

    ```

(3) Implemente o insertion sort de forma recursiva.

??? abstract "Insertion Sort recursivo"

    ```csharp

    public class InsertionSortRecursivo
    {
        public int[] RecursiveSort(int[] vetor, int quantidadeElementos)
        {
            if(quantidadeElementos <= 1)
                return vetor;

            RecursiveSort(vetor, quantidadeElementos - 1);

            for (int indiceAtual = 1; indiceAtual < quantidadeElementos; indiceAtual++)
            {
                int valorTemporario = vetor[indiceAtual];
                int indiceAuxiliar = indiceAtual - 1;

                while (indiceAuxiliar >= 0 && vetor[indiceAuxiliar] > valorTemporario)
                {
                    vetor[indiceAuxiliar + 1] = vetor[indiceAuxiliar];
                    indiceAuxiliar = indiceAuxiliar - 1;
                }

                vetor[indiceAuxiliar + 1] = valorTemporario;
            }

            return vetor;
        }
    }
    ```

    ```csharp

    int[] vetorDesordenado = [3, 7, 5, 9, 4, 1];

    InsertionSortRecursivo insertionSortRecursivo = new InsertionSortRecursivo();
    int[] vetorOrdenado = insertionSortRecursivo.RecursiveSort(vetorDesordenado);

    Console.WriteLine($"O vetor ordenado é: {string.Join(", ", vetorOrdenado)}.");

    ```



(4) Implemente o quick sort para ordenar um vetor de forma decrescente.

??? abstract "Quick Sort decrescente"

    ```csharp

    public class QuickSortDecrescente
    {
        public int[] Ordenar(int[] vetor, int esquerda, int direita)
        {
            if (esquerda < direita)
            {
                int pivo = Particionemento(vetor, esquerda, direita);
                Ordenar(vetor, esquerda, pivo - 1);
                Ordenar(vetor, pivo + 1, direita);
            }

            return vetor;
        }

        private int Particionemento(int[] vetor, int esquerda, int direita)
        {
            int pivo = vetor[esquerda];
            int indicePivo = esquerda;

            for (int i = esquerda + 1; i <= direita; i++)
            {
                if (vetor[i] > pivo)
                {
                    indicePivo = indicePivo + 1;
                    Swap(vetor, i, indicePivo);
                }
            }

            Swap(vetor, esquerda, indicePivo);

            return indicePivo;
        }

        private void Swap(int[] vetorDesordenado, int esquerda, int direita)
        {
            int temp = vetorDesordenado[esquerda];
            vetorDesordenado[esquerda] = vetorDesordenado[direita];
            vetorDesordenado[direita] = temp;
        }
    }

    ```

    ```csharp

        int[] vetorDesordenado = [3, 7, 5, 9, 4, 1];

        int[] vetorOrdenadoDecrescente = _quickSortDecrescente.Ordenar(vetorDesordenado, 0, vetorDesordenado.Length -1);

        Console.WriteLine($"O vetor ordenado é: {string.Join(", ", vetorOrdenadoDecrescente)}.");

    ```

(5) Implemente o bubble sort de forma recursiva para ordenar um vetor. Deve ser possível escolher se a ordenação será em forma crescente ou decrescente.

??? abstract "Bubble Sort recursivo crescente e decrescente"

    ```csharp

    public class BubbleSortRecursivoCrescenteDecrescente
    {
        public int[] OrdenarRecursivamente(int[] vetor, int quantidadeElementos, bool ordemCrescente = true)
        {
            if (quantidadeElementos == 1)
                return vetor;

            for (int i = 0; i < quantidadeElementos - 1; i++)
            {
                bool precisaTrocar = ordemCrescente
                    ? vetor[i] > vetor[i + 1]
                    : vetor[i] < vetor[i + 1];

                if (precisaTrocar)
                    TrocarValores(vetor, i);
            }

            return OrdenarRecursivamente(vetor, quantidadeElementos - 1, ordemCrescente);
        }

        private void TrocarValores(int[] vetor, int indice)
        {
            int valorTemporario = vetor[indice];
            vetor[indice] = vetor[indice + 1];
            vetor[indice + 1] = valorTemporario;
        }
    }

    ```

    ```csharp

    int[] vetorDesordenado = [3, 7, 5, 9, 4, 1];
    int quantidadeElementos = vetorDesordenado.Length;
    bool ordemCrescente = true;

    int[] vetorOrdenado = _bubbleSortRecursivoCrescenteDecrescente.OrdenarRecursivamente(vetorDesordenado, quantidadeElementos, ordemCrescente);

    Console.WriteLine($"O vetor ordenado em ordem crescente é: {string.Join(", ", vetorOrdenado)}.");

    ```