using Ordenacao;

namespace StructBeaver.Tests
{
    public class MetodosOrdenacaoTest
    {
        private MetodosOrdenacao _metodosOrdenacao;

        public MetodosOrdenacaoTest()
            => _metodosOrdenacao = new MetodosOrdenacao();

        [Fact]  
        public void BubbleSort_Deve_Retornar_Vetor_Ordenado()
        {
            int[] vetorDesordenado = [ 3, 7, 5, 9, 4, 1 ];

            int[] vetorOrdenado = _metodosOrdenacao.BubbleSort(vetorDesordenado);
            
            for(int indice = 0; indice < vetorOrdenado.Length - 1; indice++)            
                Assert.True(vetorOrdenado[indice] <= vetorOrdenado[indice + 1]);
            
            Console.WriteLine($"O vetor ordenado é: {string.Join(", ", vetorOrdenado)}.");
        }

    }
}
