using StructBeaver.Vetores;

namespace StructBeaver.Recursividade.Exercicios
{
    public class PesquisaSimplesRecursiva
    {
        private PesquisaSimples _pesquisaSimples;

        public PesquisaSimplesRecursiva() =>
            _pesquisaSimples = new();

        public int ExecutarPesquisaSimplesRecursiva(int[] vetor, int elementoProcurado, int indice)
            => _pesquisaSimples.ExecutarPesquisaSimplesRecursiva(vetor, elementoProcurado, indice);
    }
}