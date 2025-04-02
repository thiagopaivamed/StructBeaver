using Vetores;

namespace StructBeaver.Tests
{
    public class VetoresTest
    {
        private VetoresBasico _vetoresBasico;
        public VetoresTest()
        {
            _vetoresBasico = new VetoresBasico();
        }

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
            int[] vetor = { 3, 1, 2, 7, 10, 4, 8, 6, 12, 15 };
            int elementoProcurado = 10;

            int indiceElementoProcurado = _vetoresBasico.PesquisaSimples(vetor, elementoProcurado);

            Assert.True(indiceElementoProcurado != -1);
        }

        [Fact]
        public void PesquisaSimples_Nao_Deve_Encontrar_Elemento()
        {
            int[] vetor = { 3, 1, 2, 7, 10, 4, 8, 6, 12, 15 };
            int elementoProcurado = 20;

            int indiceElementoProcurado = _vetoresBasico.PesquisaSimples(vetor, elementoProcurado);

            Assert.False(indiceElementoProcurado != -1);
        }
    }
}
