using Shouldly;
using StructBeaver.Vetores;

namespace StructBeaver.Tests.Vetores
{
    public class VetoresTest
    {
        private readonly VetoresBasico _vetoresBasico;
        public VetoresTest() =>
            _vetoresBasico = new();

        [Fact]
        public void AdicionarElemento_Deve_Inserir_Elemento()
        {
            int valorAdicionado = 30;

            int[] vetor = _vetoresBasico.AdicionarElemento(valorAdicionado);

            vetor.ShouldContain(valorAdicionado);
        }
    }
}
