using StructBeaver.Recursividade.Exercicios;

namespace StructBeaver.Tests.Recursividade.Exercicios
{
    public class PesquisaBinariaRecursivaTest
    {
        private PesquisaBinariaRecursiva _pesquisaBinariaRecursiva;

        public PesquisaBinariaRecursivaTest()
            => _pesquisaBinariaRecursiva = new PesquisaBinariaRecursiva();

        [Fact]
        public void PesquisaBinariaRecursiva_Deve_Encontrar_Elemento()
        {
            int[] vetor = [1, 3, 7, 8, 10, 14, 18, 26, 32, 45];
            int elementoProcurado = 26;
            int quantidadeElementos = vetor.Length - 1;

            int indiceElementoProcurado = _pesquisaBinariaRecursiva.ExecutarPesquisaBinariaRecursiva(vetor, elementoProcurado, 0, quantidadeElementos);

            Assert.True(indiceElementoProcurado is not -1);

            Console.WriteLine($"O elemento {elementoProcurado} foi encontrado na posicao {indiceElementoProcurado} no vetor.");
        }

        [Fact]
        public void PesquisaBinariaRecursiva_Nao_Deve_Encontrar_Elemento()
        {
            int[] vetor = [1, 3, 7, 8, 10, 14, 18, 26, 32, 45];
            int elementoProcurado = 20;
            int quantidadeElementos = vetor.Length - 1;

            int indiceElementoProcurado = _pesquisaBinariaRecursiva.ExecutarPesquisaBinariaRecursiva(vetor, elementoProcurado, 0, quantidadeElementos);

            Assert.True(indiceElementoProcurado is -1);

            Console.WriteLine($"O elemento {elementoProcurado} não foi encontrado no vetor.");
        }
    }
}
