using StructBeaver.Recursividade.Exercicios;

namespace StructBeaver.Tests.Recursividade.Exercicios
{
    public class PalindromoRecursivoTest
    {
        private readonly PalindromoRecursivo _palindromoRecursivo;

        public PalindromoRecursivoTest()
            => _palindromoRecursivo = new PalindromoRecursivo();

        [Fact]
        public void PalindromoRecursivo_Deve_Retornar_True_Quando_Palindromo()
        {
            string palavra = "arara";

            bool ehPalindromo = _palindromoRecursivo.IsPalindromo(palavra, 0, palavra.Length - 1);

            Assert.True(ehPalindromo);
        }

        [Fact]
        public void PalindromoRecursivo_Deve_Retornar_False_Quando_Nao_For_Palindromo()
        {
            string palavra = "aviao";

            bool ehPalindromo = _palindromoRecursivo.IsPalindromo(palavra, 0, palavra.Length - 1);

            Assert.False(ehPalindromo);
        }
    }
}