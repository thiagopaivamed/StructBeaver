using Shouldly;
using StructBeaver.Vetores.Exercicios;

namespace StructBeaver.Tests.Vetores.Exercicios
{
    public class ParesImparesTest
    {
        private ParesImpares _paresImpares;
        public ParesImparesTest()
            => _paresImpares = new();

        [Fact]
        public void Deve_Retornar_Pares_Impares()
        {
            int[] vetor = [30, 1, 5, 77, 19, 32, 97, 36, 42, 66];

            int pares;
            int impares;

            string[] quantidades = _paresImpares.ContarParesImpares(vetor).Split(" ");
            pares = int.Parse(quantidades[0]);
            impares = int.Parse(quantidades[1]);

            pares.ShouldBe(5);
            impares.ShouldBe(5);
        }
    }
}