using Shouldly;
using StructBeaver.Vetores.Exercicios;

namespace StructBeaver.Tests.Vetores.Exercicios
{
    public class ProcuraPalavrasTest
    {
        private readonly ProcuraPalavras _procuraPalavras;
        private const string texto = "O rato roeu a roupa do rei de Roma.";

        public ProcuraPalavrasTest()
            => _procuraPalavras = new();

        [Fact]
        public void Palavra_Esta_no_Texto()
        {
            string palavra = "roupa";

            bool palavraEstaNoTexto = _procuraPalavras.PalavraEstaNoTexto(texto, palavra);
            palavraEstaNoTexto.ShouldBeTrue();
        }

        [Fact]
        public void Palavra_Nao_Esta_no_Texto()
        {
            string palavra = "espada";

            bool palavraEstaNoTexto = _procuraPalavras.PalavraEstaNoTexto(texto, palavra);
            palavraEstaNoTexto.ShouldBeFalse();
        }
    }
}
