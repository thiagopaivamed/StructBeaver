namespace StructBeaver.Filas.Exercicios
{
    public class OrdenacaoFila
    {
        public Fila Ordenar(Fila fila)
        {
            int quantidadeElementos = fila.Size();
            int[] elementosFila = new int[quantidadeElementos];

            for (int i = 0; i < quantidadeElementos; i++)
                elementosFila[i] = fila.Dequeue();

            int[] elementosOrdenados = Sort(elementosFila);

            for (int i = 0; i < quantidadeElementos; i++)
                fila.Enqueue(elementosOrdenados[i]);

            return fila;
        }

        private int[] Sort(int[] vetor)
        {
            int quantidadeElementos = vetor.Length;
            
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