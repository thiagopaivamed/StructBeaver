using StructBeaver.Pilhas;
using StructBeaver.Pilhas.Exercicios;

namespace StructBeaver.Tests.Pilhas.Exercicios
{
    public class MenorValorPilhaTest
    {
        private MenorValorPilha _menorValorPilha;

        public MenorValorPilhaTest()
            =>_menorValorPilha = new MenorValorPilha();

        [Fact]
        public void PegarMenorValor_Deve_Retornar_Menor_Valor()
        {
            Pilha pilha = new Pilha();
            pilha.Push(1);
            pilha.Push(2);
            pilha.Push(3);
            pilha.Push(4);
            pilha.Push(5);

            int menorValor = _menorValorPilha.PegarMenorValor(pilha);
            Assert.Equal(1, menorValor);
        }
    }
}
