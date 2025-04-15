namespace StructBeaver.Vetores
{
    public class PesquisaSimples
    {
        public int ExecutarPesquisaSimples(int[] vetor, int elementoProcurado)
        {
            for (int indice = 0; indice < vetor.Length - 1; indice = indice + 1)
            {
                if (vetor[indice] == elementoProcurado)
                    return indice;
            }

            return -1;
        }

        public int ExecutarPesquisaSimplesRecursiva(int[] vetor, int elementoProcurado, int indice)
        {
            if (indice >= vetor.Length)
                return -1;

            if (vetor[indice] == elementoProcurado)
                return indice;

            return ExecutarPesquisaSimplesRecursiva(vetor, elementoProcurado, indice + 1);
        }
    }
}
