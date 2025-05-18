using Shouldly;
using StructBeaver.Pilhas;
using StructBeaver.Pilhas.Exercicios;

namespace StructBeaver.Tests.Pilhas.Exercicios
{
    public class CopiaPilhaTest
    {
        private readonly CopiaPilha _copiaPilha;

        public CopiaPilhaTest()
            => _copiaPilha = new();

        [Fact]
        public void PegarPilhaCopiada_Deve_Retornar_Pilha_Copiada()
        {
            Pilha pilhaOriginal = new();
            pilhaOriginal.Push(1);
            pilhaOriginal.Push(2);
            pilhaOriginal.Push(3);
            pilhaOriginal.Push(4);
            pilhaOriginal.Push(5);

            Pilha pilhaCopiada = _copiaPilha.PegarPilhaCopiada(pilhaOriginal);

            pilhaCopiada.Pop().ShouldBe(1);
            pilhaCopiada.Pop().ShouldBe(2);
            pilhaCopiada.Pop().ShouldBe(3);
            pilhaCopiada.Pop().ShouldBe(4);
            pilhaCopiada.Pop().ShouldBe(5);
        }
    }
}