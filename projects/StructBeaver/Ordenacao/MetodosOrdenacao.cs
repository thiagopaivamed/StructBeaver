namespace Ordenacao
{
    public class MetodosOrdenacao
    {
        public int[] BubbleSort(int[] vetor)
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

        public int[] BubbleSortRecursivo(int[] vetor, int quantidadeElementos)
        {
            if (quantidadeElementos == 1)
                return vetor;

            for (int indice = 0; indice < quantidadeElementos - 1; indice++)
            {
                if (vetor[indice] > vetor[indice + 1])
                    Swap(vetor, indice);
            }

            return BubbleSortRecursivo(vetor, quantidadeElementos - 1);
        }

        private void Swap(int[] vetorDesordenado, int indiceAtual)
        {
            int valorTemporario = vetorDesordenado[indiceAtual];
            vetorDesordenado[indiceAtual] = vetorDesordenado[indiceAtual + 1];
            vetorDesordenado[indiceAtual + 1] = valorTemporario;
        }

        public int[] SelectionSort(int[] vetor)
        {
            int indiceMenorValor;
            int quantidadeElementos = vetor.Length;

            for (int indiceAtual = 0; indiceAtual < quantidadeElementos - 1; indiceAtual++)
            {
                indiceMenorValor = indiceAtual;

                for (int proximoIndice = indiceAtual + 1; proximoIndice < quantidadeElementos; proximoIndice++)
                {
                    if (vetor[proximoIndice] < vetor[indiceMenorValor])
                        indiceMenorValor = proximoIndice;
                }

                if (vetor[indiceAtual] != vetor[indiceMenorValor])
                    Swap(vetor, indiceAtual, indiceMenorValor);
            }

            return vetor;
        }

        public int[] SelectionSortRecursivo(int[] vetor, int quantidadeElementos, int indice = 0)
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

            return SelectionSortRecursivo(vetor, quantidadeElementos, indice + 1);
        }

        private void Swap(int[] vetorDesordenado, int indiceAtual, int indiceMenorValor)
        {
            int valorTemporario = vetorDesordenado[indiceAtual];
            vetorDesordenado[indiceAtual] = vetorDesordenado[indiceMenorValor];
            vetorDesordenado[indiceMenorValor] = valorTemporario;
        }

        public int[] InsertionSort(int[] vetor)
        {
            int quantidadeElementos = vetor.Length;

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

        public int[] QuickSort(int[] vetor, int esquerda, int direita)
        {
            if (esquerda < direita)
            {
                int pivo = Particionemento(vetor, esquerda, direita);
                QuickSort(vetor, esquerda, pivo - 1);
                QuickSort(vetor, pivo + 1, direita);
            }

            return vetor;
        }

        private int Particionemento(int[] vetor, int esquerda, int direita)
        {
            int pivo = vetor[esquerda];
            int indicePivo = esquerda;

            for (int i = esquerda + 1; i <= direita; i++)
            {
                if (vetor[i] < pivo)
                {
                    indicePivo++;
                    SwapQuickSort(vetor, i, indicePivo);
                }
            }

            SwapQuickSort(vetor, esquerda, indicePivo); 

            return indicePivo;
        }

        private void SwapQuickSort(int[] vetorDesordenado, int esquerda, int direita)
        {
            int temp = vetorDesordenado[esquerda];
            vetorDesordenado[esquerda] = vetorDesordenado[direita];
            vetorDesordenado[direita] = temp;
        }

        public int[] MergeSort(int[] vetor)
        {
            int quantidadeElementos = vetor.Length;

            // Caso base
            // Se o vetor tiver apenas um elemento, ele já está ordenado
            if (quantidadeElementos <= 1)
                return vetor;

            int meio = quantidadeElementos / 2;
            int[] vetorEsquerdo = new int[meio];
            int[] vetorDireito = new int[quantidadeElementos - meio];

            int indiceVetorEsquerdo = 0;
            int indiceVetorDireito = 0;

            for (; indiceVetorEsquerdo < quantidadeElementos; indiceVetorEsquerdo++)
            {
                if (indiceVetorEsquerdo < meio)
                    vetorEsquerdo[indiceVetorEsquerdo] = vetor[indiceVetorEsquerdo];
                else
                {
                    vetorDireito[indiceVetorDireito] = vetor[indiceVetorEsquerdo];
                    indiceVetorDireito = indiceVetorDireito + 1;
                }
            }

            vetorEsquerdo = MergeSort(vetorEsquerdo);
            vetorDireito = MergeSort(vetorDireito);
            Merge(vetor, vetorEsquerdo, vetorDireito);

            return vetor;
        }

        private void Merge(int[] vetor, int[] vetorEsquerdo, int[] vetorDireito)
        {
            int quantidadeElementosVetorEsquerdo = vetorEsquerdo.Length;
            int quantidadeElementosVetorDireito = vetorDireito.Length;
            int indiceVetor = 0;
            int indiceVetorEsquerdo = 0;
            int indiceVetorDireito = 0;

            // Aqui começa a mágica, ou o merge
            while (indiceVetorEsquerdo < quantidadeElementosVetorEsquerdo && indiceVetorDireito < quantidadeElementosVetorDireito)
            {
                if (vetorEsquerdo[indiceVetorEsquerdo] < vetorDireito[indiceVetorDireito])
                {
                    vetor[indiceVetor] = vetorEsquerdo[indiceVetorEsquerdo];
                    indiceVetor = indiceVetor + 1;
                    indiceVetorEsquerdo = indiceVetorEsquerdo + 1;
                }
                else
                {
                    vetor[indiceVetor] = vetorDireito[indiceVetorDireito];
                    indiceVetor = indiceVetor + 1;
                    indiceVetorDireito = indiceVetorDireito + 1;
                }
            }

            while (indiceVetorEsquerdo < quantidadeElementosVetorEsquerdo)
            {
                vetor[indiceVetor] = vetorEsquerdo[indiceVetorEsquerdo];
                indiceVetor = indiceVetor + 1;
                indiceVetorEsquerdo = indiceVetorEsquerdo + 1;
            }

            while (indiceVetorDireito < quantidadeElementosVetorDireito)
            {
                vetor[indiceVetor] = vetorDireito[indiceVetorDireito];
                indiceVetor = indiceVetor + 1;
                indiceVetorDireito = indiceVetorDireito + 1;
            }
        }
    }
}
