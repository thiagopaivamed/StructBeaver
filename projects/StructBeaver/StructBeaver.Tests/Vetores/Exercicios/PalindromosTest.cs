using Shouldly;
using StructBeaver.Vetores.Exercicios;

namespace StructBeaver.Tests.Vetores.Exercicios
{
    public class PalindromosTest
    {
        private readonly Palindromos _palidromos;

        public PalindromosTest()
            => _palidromos = new();


        [Fact]
        public void Palavras_Sao_Palidromos()
        {
            string[] palavras = ["arara", "reviver", "osso", "mirim", "anilina", "atorrota", "oco"];

            int indice = 0;

            while(indice < palavras.Length - 1)
            {
                bool ehPalindromo = _palidromos.IsPalindromo(palavras[indice]);
                ehPalindromo.ShouldBeTrue();
                indice = indice + 1;
            }            
        }

        [Fact]
        public void Palavras_Nao_Sao_Palidromos()
        {
            string[] palavras = ["teste", "palavra", "carro", "rodovia", "aviao", "aeroporto", "torre"];

            int indice = 0;

            while (indice < palavras.Length - 1)
            {
                bool ehPalindromo = _palidromos.IsPalindromo(palavras[indice]);
                ehPalindromo.ShouldBeFalse();
                indice = indice + 1;
            }
        }
    }
}