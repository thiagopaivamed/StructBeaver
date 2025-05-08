using StructBeaver.Vetores.Exercicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructBeaver.Tests.Vetores.Exercicios
{
    public class PalindromosTest
    {
        private Palindromos _palidromos;

        public PalindromosTest()
            => _palidromos = new Palindromos();


        [Fact]
        public void Palavras_Sao_Palidromos()
        {
            string[] palavras = ["arara", "reviver", "osso", "mirim", "anilina", "atorrota", "oco"];

            int indice = 0;

            while(indice < palavras.Length - 1)
            {
                bool ehPalindromo = _palidromos.IsPalindromo(palavras[indice]);
                Assert.True(ehPalindromo);
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
                Assert.False(ehPalindromo);
                indice = indice + 1;
            }
        }
    }
}
