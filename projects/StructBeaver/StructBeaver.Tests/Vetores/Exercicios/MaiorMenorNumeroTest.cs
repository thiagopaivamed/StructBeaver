using StructBeaver.Vetores.Exercicios;

namespace StructBeaver.Tests.Vetores.Exercicios
{
    public class MaiorMenorNumeroTest
    {
        private MaiorMenorNumero _maiorMenorNumero;

        public MaiorMenorNumeroTest()
            => _maiorMenorNumero = new MaiorMenorNumero();

        [Fact]
        public void Deve_Retornar_Maior_Menor_Numero()
        {
            int[] vetor = [30, 1, 5, 77, 19, 32, 97, 36, 42, 66];
            int maiorNumero;
            int menorNumero;

            string[] quantidades = _maiorMenorNumero.PegarMaiorMenor(vetor).Split(" ");
            maiorNumero = int.Parse(quantidades[0]);
            menorNumero = int.Parse(quantidades[1]);

            Assert.Equal(97, maiorNumero);
            Assert.Equal(1, menorNumero);

            Console.WriteLine($"Vetor original: {string.Join(", ", vetor)}");
            Console.WriteLine($"Maior número: {maiorNumero}");
            Console.WriteLine($"Menor número: {menorNumero}");
        }
    }
}
