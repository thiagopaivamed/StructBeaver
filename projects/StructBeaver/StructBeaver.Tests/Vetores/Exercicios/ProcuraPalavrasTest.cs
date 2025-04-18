using StructBeaver.Vetores.Exercicios;

namespace StructBeaver.Tests.Vetores.Exercicios
{
    public class ProcuraPalavrasTest
    {
        private ProcuraPalavras _procuraPalavras;

        public ProcuraPalavrasTest()
            => _procuraPalavras = new ProcuraPalavras();

        [Fact]
        public void Palavra_Esta_no_Texto()
        {
            string texto = "O rato roeu a roupa do rei de Roma.";
            string palavra = "roupa";

            bool palavraEstaNoTexto = _procuraPalavras.PalavraEstaNoTexto(texto, palavra);
            Assert.True(palavraEstaNoTexto);
        }

        [Fact]
        public void Palavra_Nao_Esta_no_Texto()
        {
            string texto = "O rato roeu a roupa do rei de Roma.";
            string palavra = "espada";

            bool palavraEstaNoTexto = _procuraPalavras.PalavraEstaNoTexto(texto, palavra);
            Assert.False(palavraEstaNoTexto);
        }

    }
}
