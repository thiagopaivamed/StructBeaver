using StructBeaver.Vetores;

namespace StructBeaver.Tests.Vetores
{
    public class PesquisaSimplesTest
    {
        private readonly PesquisaSimples _pesquisaSimples;

        public PesquisaSimplesTest()
            => _pesquisaSimples = new PesquisaSimples();

        [Fact]
        public void PesquisaSimples_Deve_Encontrar_Elemento()
        {
            int[] vetor = [3, 1, 2, 7, 10, 4, 8, 6, 12, 15];
            int elementoProcurado = 2;

            int indiceElementoProcurado = _pesquisaSimples.ExecutarPesquisaSimples(vetor, elementoProcurado);

            Assert.True(indiceElementoProcurado is not -1);

            Console.WriteLine($"O elemento {elementoProcurado} foi encontrado na posicao {indiceElementoProcurado} no vetor.");
        }

        [Fact]
        public void PesquisaSimples_Nao_Deve_Encontrar_Elemento()
        {
            int[] vetor = [3, 1, 2, 7, 10, 4, 8, 6, 12, 15];
            int elementoProcurado = 20;

            int indiceElementoProcurado = _pesquisaSimples.ExecutarPesquisaSimples(vetor, elementoProcurado);

            Assert.False(indiceElementoProcurado is not -1);

            Console.WriteLine($"O elemento {elementoProcurado} não foi encontrado no vetor.");
        }

        [Fact]
        public void PesquisaSimplesRecursiva_Deve_Encontrar_Elemento()
        {
            int[] vetor = [3, 1, 2, 7, 10, 4, 8, 6, 12, 15];
            int elementoProcurado = 2;

            int indiceElementoProcurado = _pesquisaSimples.ExecutarPesquisaSimplesRecursiva(vetor, elementoProcurado, 0);

            Assert.True(indiceElementoProcurado is not -1);

            Console.WriteLine($"O elemento {elementoProcurado} foi encontrado na posicao {indiceElementoProcurado} no vetor.");
        }

        [Fact]
        public void PesquisaSimplesRecursiva_Nao_Deve_Encontrar_Elemento()
        {
            int[] vetor = [3, 1, 2, 7, 10, 4, 8, 6, 12, 15];
            int elementoProcurado = 20;

            int indiceElementoProcurado = _pesquisaSimples.ExecutarPesquisaSimplesRecursiva(vetor, elementoProcurado, 0);

            Assert.True(indiceElementoProcurado is -1);

            Console.WriteLine($"O elemento {elementoProcurado} não foi encontrado no vetor.");
        }

    }
}
