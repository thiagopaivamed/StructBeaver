using StructBeaver.Recursividade.Exercicios;

namespace StructBeaver.Tests.Recursividade.Exercicios
{
    public class DigitosRecursivoTest
    {
        private DigitosRecursivo _digitosRecursivo;

        public DigitosRecursivoTest()
            => _digitosRecursivo = new DigitosRecursivo();

        [Fact]
        public void DigitosRecursivo_Deve_Retornar_Quantidade_De_Digitos_Quando_Numero_For_Maior_Que_10()
        {
            int numero = 789;

            int quantidadeDigitos = _digitosRecursivo.PegarQuantidadeDigitos(numero);

            Assert.Equal(3, quantidadeDigitos);

            Console.WriteLine($"O numero {numero} possui {quantidadeDigitos} digitos.");
        }

        [Fact]
        public void DigitosRecursivo_Deve_Retornar_1_Quando_Numero_For_Menor_Que_10()
        {
            int numero = 9;

            int quantidadeDigitos = _digitosRecursivo.PegarQuantidadeDigitos(numero);

            Assert.Equal(1, quantidadeDigitos);

            Console.WriteLine($"O numero {numero} possui {quantidadeDigitos} digitos.");
        }
    }
}
