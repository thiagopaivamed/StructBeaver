namespace StructBeaver.Pilhas.Exercicios
{
    public class OrdenacaoPilha
    {
        public Pilha OrdenarPilha(Pilha pilha)
        {
            int quantidadeElementos = pilha.Tamanho();

            int[] elementos = new int[quantidadeElementos];

            for(int i = 0; i < quantidadeElementos; i++)
                elementos[i] = pilha.Pop();

            int[] elementosOrdenados = RecursiveInsertionSort(elementos, quantidadeElementos);            

            InserirRecursivo(pilha, elementosOrdenados, 0);

            return pilha;
        }

        private int[] RecursiveInsertionSort(int[] vetor, int quantidadeElementos)
        {
            if (quantidadeElementos <= 1)
                return vetor;

            RecursiveInsertionSort(vetor, quantidadeElementos - 1);

            for (int indiceAtual = 1; indiceAtual < quantidadeElementos; indiceAtual++)
            {
                int valorTemporario = vetor[indiceAtual];
                int indiceAuxiliar = indiceAtual - 1;

                while (indiceAuxiliar >= 0 && vetor[indiceAuxiliar] < valorTemporario)
                {
                    vetor[indiceAuxiliar + 1] = vetor[indiceAuxiliar];
                    indiceAuxiliar = indiceAuxiliar - 1;
                }

                vetor[indiceAuxiliar + 1] = valorTemporario;
            }

            return vetor;
        }

        private void InserirRecursivo(Pilha pilha, int[] elementos, int indice)
        {
            if (indice >= elementos.Length)
                return;

            pilha.Push(elementos[indice]);
            InserirRecursivo(pilha, elementos, indice + 1);
        }
    }
}
