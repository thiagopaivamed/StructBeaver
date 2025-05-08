using StructBeaver.Vetores.Exercicios;

namespace StructBeaver.Tests.Vetores.Exercicios
{
    public class InverteVetorTest
    {
        private InverteVetor _inverteVetor;

        public InverteVetorTest()
            => _inverteVetor = new InverteVetor();

        [Fact]
        public void Inverter_Deve_Retornar_Vetor_Invertido()
        {
            int[] vetor = [30, 1, 5, 77, 19, 32, 97, 36, 42, 66];

            int[] vetorInvertido = _inverteVetor.Inverter(vetor);

            Assert.Equal([66, 42, 36, 97, 32, 19, 77, 5, 1, 30], vetorInvertido);
        }
    }
}
