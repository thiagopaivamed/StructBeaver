using Shouldly;
using StructBeaver.Pilhas;
using StructBeaver.Pilhas.Exercicios;

namespace StructBeaver.Tests.Pilhas.Exercicios
{
    public class PilhaInvertidaRecursivaTest
    {
        private readonly PilhaInvertidaRecursiva _pilhaInvertidaRecursiva;

        public PilhaInvertidaRecursivaTest()
            => _pilhaInvertidaRecursiva = new();

        [Fact]
        public void InverterPilha_Deve_Retornar_Pilha_Invertida()
        {
            Pilha pilha = new();
            pilha.Push(1);
            pilha.Push(2);
            pilha.Push(3);
            pilha.Push(4);
            pilha.Push(5);

            pilha = _pilhaInvertidaRecursiva.InverterPilha(pilha);

            pilha.Pop().ShouldBe(5);
            pilha.Pop().ShouldBe(4);
            pilha.Pop().ShouldBe(3);
            pilha.Pop().ShouldBe(2);
            pilha.Pop().ShouldBe(1);
        }
    }
}
