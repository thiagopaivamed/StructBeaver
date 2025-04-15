using StructBeaver.Vetores;

namespace StructBeaver.Tests.Vetores
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
    }
}
