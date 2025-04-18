using StructBeaver.Vetores.Exercicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructBeaver.Tests.Vetores.Exercicios
{
    public class ParesImparesTest
    {
        private ParesImpares _paresImpares;
        public ParesImparesTest()
            => _paresImpares = new ParesImpares();

        [Fact]
        public void Deve_Retornar_Pares_Impares()
        {
            int[] vetor = [30, 1, 5, 77, 19, 32, 97, 36, 42, 66];

            int pares;
            int impares;

            string[] quantidades = _paresImpares.ContarParesImpares(vetor).Split(" ");
            pares = int.Parse(quantidades[0]);
            impares = int.Parse(quantidades[1]);

            Assert.Equal(5, pares);
            Assert.Equal(5, impares);

            Console.WriteLine($"Vetor original: {string.Join(", ", vetor)}");
            Console.WriteLine($"Quantidade de pares: {pares}");
            Console.WriteLine($"Quantidade de impares: {impares}");
        }
    }
}
