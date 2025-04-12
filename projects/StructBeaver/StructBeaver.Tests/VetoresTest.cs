using Vetores;

namespace StructBeaver.Tests
{
    public class VetoresTest
    {
        private VetoresBasico _vetoresBasico;
        public VetoresTest() =>
            _vetoresBasico = new VetoresBasico();

        [Fact]
        public void AdicionarElemento_Deve_Inserir_Elemento()
        {
            int valorAdicionado = 30;

            int[] vetor = _vetoresBasico.AdicionarElemento(valorAdicionado);

            Assert.Contains(valorAdicionado, vetor);
        }

        [Fact]
        public void PesquisaSimples_Deve_Encontrar_Elemento()
        {
            int[] vetor = [3, 1, 2, 7, 10, 4, 8, 6, 12, 15];
            int elementoProcurado = 2;

            int indiceElementoProcurado = _vetoresBasico.PesquisaSimples(vetor, elementoProcurado);

            Assert.True(indiceElementoProcurado is not -1);

            Console.WriteLine($"O elemento {elementoProcurado} foi encontrado na posicao {indiceElementoProcurado} no vetor.");
        }

        [Fact]
        public void PesquisaSimples_Nao_Deve_Encontrar_Elemento()
        {
            int[] vetor = [3, 1, 2, 7, 10, 4, 8, 6, 12, 15];
            int elementoProcurado = 20;

            int indiceElementoProcurado = _vetoresBasico.PesquisaSimples(vetor, elementoProcurado);

            Assert.False(indiceElementoProcurado is not -1);

            Console.WriteLine($"O elemento {elementoProcurado} não foi encontrado no vetor.");
        }

        [Fact]
        public void PesquisaSimplesRecursiva_Deve_Encontrar_Elemento()
        {
            int[] vetor = [3, 1, 2, 7, 10, 4, 8, 6, 12, 15];
            int elementoProcurado = 2;

            int indiceElementoProcurado = _vetoresBasico.PesquisaSimples(vetor, elementoProcurado);

            Assert.True(indiceElementoProcurado is not -1);

            Console.WriteLine($"O elemento {elementoProcurado} foi encontrado na posicao {indiceElementoProcurado} no vetor.");
        }

        [Fact]
        public void PesquisaSimplesRecursiva_Nao_Deve_Encontrar_Elemento()
        {
            int[] vetor = [3, 1, 2, 7, 10, 4, 8, 6, 12, 15];
            int elementoProcurado = 20;

            int indiceElementoProcurado = _vetoresBasico.PesquisaSimples(vetor, elementoProcurado);

            Assert.True(indiceElementoProcurado is -1);

            Console.WriteLine($"O elemento {elementoProcurado} não foi encontrado no vetor.");
        }

        [Fact]
        public void PesquisaBinaria_Deve_Encontrar_Elemento()
        {
            int[] vetor = [1, 3, 7, 8, 10, 14, 18, 26, 32, 45];
            int elementoProcurado = 26;

            int indiceElementoProcurado = _vetoresBasico.PesquisaBinaria(vetor, elementoProcurado);

            Assert.True(indiceElementoProcurado is not -1);
            Console.WriteLine($"O elemento {elementoProcurado} foi encontrado na posicao {indiceElementoProcurado} no vetor.");
        }

        [Fact]
        public void PesquisaBinaria_Nao_Deve_Encontrar_Elemento()
        {
            int[] vetor = [1, 3, 7, 8, 10, 14, 18, 26, 32, 45];
            int elementoProcurado = 20;

            int indiceElementoProcurado = _vetoresBasico.PesquisaBinaria(vetor, elementoProcurado);

            Assert.True(indiceElementoProcurado is -1);

            Console.WriteLine($"O elemento {elementoProcurado} não foi encontrado no vetor.");
        }

        [Fact]
        public void PesquisaBinariaRecursiva_Deve_Encontrar_Elemento()
        {
            int[] vetor = [1, 3, 7, 8, 10, 14, 18, 26, 32, 45];
            int elementoProcurado = 26;
            int quantidadeElementos = vetor.Length - 1;

            int indiceElementoProcurado = _vetoresBasico.PesquisaBinariaRecursiva(vetor, elementoProcurado, 0, quantidadeElementos);

            Assert.True(indiceElementoProcurado is not -1);
            Console.WriteLine($"O elemento {elementoProcurado} foi encontrado na posicao {indiceElementoProcurado} no vetor.");
        }

        [Fact]
        public void PesquisaBinariaRecursiva_Nao_Deve_Encontrar_Elemento()
        {
            int[] vetor = [1, 3, 7, 8, 10, 14, 18, 26, 32, 45];
            int elementoProcurado = 20;
            int quantidadeElementos = vetor.Length - 1;

            int indiceElementoProcurado = _vetoresBasico.PesquisaBinariaRecursiva(vetor, elementoProcurado, 0, quantidadeElementos);

            Assert.True(indiceElementoProcurado is -1);

            Console.WriteLine($"O elemento {elementoProcurado} não foi encontrado no vetor.");
        }
    }
}
