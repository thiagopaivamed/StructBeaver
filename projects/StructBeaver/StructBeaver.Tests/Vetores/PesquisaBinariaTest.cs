using Shouldly;
using StructBeaver.Vetores;

namespace StructBeaver.Tests.Vetores
{
    public class PesquisaBinariaTest
    {
        private readonly PesquisaBinaria _pesquisaBinaria;

        public PesquisaBinariaTest()
            => _pesquisaBinaria = new();

        [Fact]
        public void PesquisaBinaria_Deve_Encontrar_Elemento()
        {
            int[] vetor = [1, 3, 7, 8, 10, 14, 18, 26, 32, 45];
            int elementoProcurado = 26;

            int indiceElementoProcurado = _pesquisaBinaria.ExecutarPesquisaBinaria(vetor, elementoProcurado);

            indiceElementoProcurado.ShouldNotBe(-1);
        }

        [Fact]
        public void PesquisaBinaria_Nao_Deve_Encontrar_Elemento()
        {
            int[] vetor = [1, 3, 7, 8, 10, 14, 18, 26, 32, 45];
            int elementoProcurado = 20;

            int indiceElementoProcurado = _pesquisaBinaria.ExecutarPesquisaBinaria(vetor, elementoProcurado);

            indiceElementoProcurado.ShouldBe(-1);            
        }

        [Fact]
        public void PesquisaBinariaRecursiva_Deve_Encontrar_Elemento()
        {
            int[] vetor = [1, 3, 7, 8, 10, 14, 18, 26, 32, 45];
            int elementoProcurado = 26;
            int quantidadeElementos = vetor.Length - 1;

            int indiceElementoProcurado = _pesquisaBinaria.ExecutarPesquisaBinariaRecursiva(vetor, elementoProcurado, 0, quantidadeElementos);

            indiceElementoProcurado.ShouldNotBe(-1);
        }

        [Fact]
        public void PesquisaBinariaRecursiva_Nao_Deve_Encontrar_Elemento()
        {
            int[] vetor = [1, 3, 7, 8, 10, 14, 18, 26, 32, 45];
            int elementoProcurado = 20;
            int quantidadeElementos = vetor.Length - 1;

            int indiceElementoProcurado = _pesquisaBinaria.ExecutarPesquisaBinariaRecursiva(vetor, elementoProcurado, 0, quantidadeElementos);

            indiceElementoProcurado.ShouldBe(-1);
        }
    }
}