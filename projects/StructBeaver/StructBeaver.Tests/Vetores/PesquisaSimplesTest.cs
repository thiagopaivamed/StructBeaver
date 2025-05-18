using Shouldly;
using StructBeaver.Vetores;

namespace StructBeaver.Tests.Vetores
{
    public class PesquisaSimplesTest
    {
        private readonly PesquisaSimples _pesquisaSimples;

        public PesquisaSimplesTest()
            => _pesquisaSimples = new();

        [Fact]
        public void PesquisaSimples_Deve_Encontrar_Elemento()
        {
            int[] vetor = [3, 1, 2, 7, 10, 4, 8, 6, 12, 15];
            int elementoProcurado = 2;

            int indiceElementoProcurado = _pesquisaSimples.ExecutarPesquisaSimples(vetor, elementoProcurado);

            indiceElementoProcurado.ShouldNotBe(-1);
        }

        [Fact]
        public void PesquisaSimples_Nao_Deve_Encontrar_Elemento()
        {
            int[] vetor = [3, 1, 2, 7, 10, 4, 8, 6, 12, 15];
            int elementoProcurado = 20;

            int indiceElementoProcurado = _pesquisaSimples.ExecutarPesquisaSimples(vetor, elementoProcurado);

            indiceElementoProcurado.ShouldBe(-1);
        }

        [Fact]
        public void PesquisaSimplesRecursiva_Deve_Encontrar_Elemento()
        {
            int[] vetor = [3, 1, 2, 7, 10, 4, 8, 6, 12, 15];
            int elementoProcurado = 2;

            int indiceElementoProcurado = _pesquisaSimples.ExecutarPesquisaSimplesRecursiva(vetor, elementoProcurado, 0);

            indiceElementoProcurado.ShouldNotBe(-1);
        }

        [Fact]
        public void PesquisaSimplesRecursiva_Nao_Deve_Encontrar_Elemento()
        {
            int[] vetor = [3, 1, 2, 7, 10, 4, 8, 6, 12, 15];
            int elementoProcurado = 20;

            int indiceElementoProcurado = _pesquisaSimples.ExecutarPesquisaSimplesRecursiva(vetor, elementoProcurado, 0);

            indiceElementoProcurado.ShouldBe(-1);
        }
    }
}