using Shouldly;
using StructBeaver.Recursividade.Exercicios;

namespace StructBeaver.Tests.Recursividade.Exercicios
{
    public class DigitosRecursivoTest
    {
        private readonly DigitosRecursivo _digitosRecursivo;

        public DigitosRecursivoTest()
            => _digitosRecursivo = new();

        [Fact]
        public void DigitosRecursivo_Deve_Retornar_Quantidade_De_Digitos_Quando_Numero_For_Maior_Que_10()
        {
            int numero = 789;

            int quantidadeDigitos = _digitosRecursivo.PegarQuantidadeDigitos(numero);

            quantidadeDigitos.ShouldBe(3);
        }

        [Fact]
        public void DigitosRecursivo_Deve_Retornar_1_Quando_Numero_For_Menor_Que_10()
        {
            int numero = 9;

            int quantidadeDigitos = _digitosRecursivo.PegarQuantidadeDigitos(numero);

            quantidadeDigitos.ShouldBe(1);
        }
    }
}