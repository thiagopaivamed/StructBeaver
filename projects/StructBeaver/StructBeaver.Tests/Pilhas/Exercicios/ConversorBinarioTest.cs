using Shouldly;
using StructBeaver.Pilhas.Exercicios;

namespace StructBeaver.Tests.Pilhas.Exercicios
{
    public class ConversorBinarioTest
    {
        private ConversorBinario _conversorBinario;

        public ConversorBinarioTest()
            => _conversorBinario = new();

        [Fact]
        public void ConverterDecimalParaBinario_Deve_Retornar_Binario()
        {
            int decimalValue = 10;
            string binario = _conversorBinario.ConverterParaBinario(decimalValue);
            binario.ShouldBe("1010");
        }
    }
}