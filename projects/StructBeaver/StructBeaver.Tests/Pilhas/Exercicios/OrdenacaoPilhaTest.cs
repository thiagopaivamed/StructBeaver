using Shouldly;
using StructBeaver.Pilhas;
using StructBeaver.Pilhas.Exercicios;

namespace StructBeaver.Tests.Pilhas.Exercicios
{
    public class OrdenacaoPilhaTest
    {
        private readonly OrdenacaoPilha _ordenacaoPilha;

        public OrdenacaoPilhaTest()
            => _ordenacaoPilha = new();

        [Fact]
        public void OrdenarPilha_Deve_Retornar_Pilha_Ordenada()
        {
            Pilha pilha = new();
            pilha.Push(55);
            pilha.Push(7);
            pilha.Push(9);
            pilha.Push(32);
            pilha.Push(89);

            pilha = _ordenacaoPilha.OrdenarPilha(pilha);

            pilha.Pop().ShouldBe(7);
            pilha.Pop().ShouldBe(9);
            pilha.Pop().ShouldBe(32);
            pilha.Pop().ShouldBe(55);
            pilha.Pop().ShouldBe(89);
        }
    }
}