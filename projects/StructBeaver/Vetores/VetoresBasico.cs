namespace Vetores
{
    public class VetoresBasico
    {
        public int[] AdicionarElemento(int valorAdicionado)
        {
            int[] vetorAnterior = { 9, 2, 5, 1, 0, 7, 10, 3, 8, 7 };

            int[] vetorNovo = new int[vetorAnterior.Length + 1];

            Array.Copy(vetorAnterior, vetorNovo, vetorAnterior.Length);

            vetorNovo[vetorNovo.Length - 1] = valorAdicionado;

            vetorAnterior = vetorNovo;

            return vetorAnterior;
        }

        public int PesquisaSimples(int[] vetor, int elementoProcurado)
        {
            for (int indice = 0; indice < vetor.Length - 1; indice = indice + 1)
            {
                if (vetor[indice] == elementoProcurado)
                    return indice;
            }

            return -1;
        }

        public int PesquisaSimplesRecursiva(int[] vetor, int elementoProcurado, int indice)
        {
            if (indice >= vetor.Length)
                return -1;

            if (vetor[indice] == elementoProcurado)
                return indice;

            return PesquisaSimplesRecursiva(vetor, elementoProcurado, indice + 1);
        }

        public int PesquisaBinaria(int[] vetor, int elementoProcurado)
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

        public int PesquisaBinariaRecursiva(int[] vetor, int elementoProcurado, int inicio, int fim)
        {          

            if (inicio > fim)
                return -1;

            int meio = (inicio + fim) / 2;

            if (vetor[meio] == elementoProcurado)
                return meio;

            if (vetor[meio] < elementoProcurado)
                return PesquisaBinariaRecursiva(vetor, elementoProcurado, meio + 1, fim);

            return PesquisaBinariaRecursiva(vetor, elementoProcurado, inicio, meio - 1);
        }
    }
}
