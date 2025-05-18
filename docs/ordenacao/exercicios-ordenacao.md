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
            => (vetorDesordenado[indiceAtual + 1], vetorDesordenado[indiceAtual]) =
            (vetorDesordenado[indiceAtual], vetorDesordenado[indiceAtual + 1]);
    }

    ```

(2) Implemente o selection sort de forma recursiva.

??? abstract "Selection Sort recursivo"

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
            => (vetorDesordenado[direita], vetorDesordenado[esquerda]) = 
                (vetorDesordenado[esquerda], vetorDesordenado[direita]);     
    }

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
                bool precisaTrocar;

                if (ordemCrescente)                
                    precisaTrocar = vetor[i] > vetor[i + 1];

                else                
                    precisaTrocar = vetor[i] < vetor[i + 1];  
                    
                if (precisaTrocar)
                    TrocarValores(vetor, i);
            }

            return OrdenarRecursivamente(vetor, quantidadeElementos - 1, ordemCrescente);
        }

        private void TrocarValores(int[] vetor, int indice)
            => (vetor[indice + 1], vetor[indice]) = (vetor[indice], vetor[indice + 1]);
    }

    ```