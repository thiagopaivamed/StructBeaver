namespace StructBeaver.Vetores
{
    public class PesquisaBinaria
    {
        public int ExecutarPesquisaBinaria(int[] vetor, int elementoProcurado)
        {
            int inicio = 0;
            int fim = vetor.Length - 1;
            int meio = 0;

            while (inicio <= fim)
            {
                meio = (inicio + fim) / 2;

                if (vetor[meio] == elementoProcurado)
                    return meio;

                else if (vetor[meio] < elementoProcurado)
                    inicio = meio + 1;
                else
                    fim = meio - 1;
            }

            return -1;
        }

        public int ExecutarPesquisaBinariaRecursiva(int[] vetor, int elementoProcurado, int inicio, int fim)
        {
            if (inicio > fim)
                return -1;

            int meio = (inicio + fim) / 2;

            if (vetor[meio] == elementoProcurado)
                return meio;

            if (vetor[meio] < elementoProcurado)
                return ExecutarPesquisaBinariaRecursiva(vetor, elementoProcurado, meio + 1, fim);

            return ExecutarPesquisaBinariaRecursiva(vetor, elementoProcurado, inicio, meio - 1);
        }
    }
}