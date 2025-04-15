namespace StructBeaver.Ordenacao
{
    public class QuickSort
    {
        public int[] Sort(int[] vetor, int esquerda, int direita)
        {
            if (esquerda < direita)
            {
                int pivo = Particionemento(vetor, esquerda, direita);
                Sort(vetor, esquerda, pivo - 1);
                Sort(vetor, pivo + 1, direita);
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
}
