using StructBeaver.Vetores;

namespace StructBeaver.Recursividade.Exercicios
{
    public class PesquisaBinariaRecursiva
    {
        private PesquisaBinaria _pesquisaBinaria;

        public PesquisaBinariaRecursiva()
            => _pesquisaBinaria = new();

        public int ExecutarPesquisaBinariaRecursiva(int[] vetor, int elementoProcurado, int inicio, int fim)
            => _pesquisaBinaria.ExecutarPesquisaBinariaRecursiva(vetor, elementoProcurado, inicio, fim);
    }
}