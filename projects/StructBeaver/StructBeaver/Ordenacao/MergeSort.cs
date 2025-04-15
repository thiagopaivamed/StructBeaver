namespace StructBeaver.Ordenacao
{
    public class MergeSort
    {
        public int[] Sort(int[] vetor)
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

            vetorEsquerdo = Sort(vetorEsquerdo);
            vetorDireito = Sort(vetorDireito);
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
