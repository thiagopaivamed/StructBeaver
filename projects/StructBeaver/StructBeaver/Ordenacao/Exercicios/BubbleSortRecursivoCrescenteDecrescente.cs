namespace StructBeaver.Ordenacao.Exercicios
{
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
}