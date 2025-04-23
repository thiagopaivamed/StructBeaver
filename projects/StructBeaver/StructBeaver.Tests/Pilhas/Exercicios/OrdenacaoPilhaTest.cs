using StructBeaver.Pilhas;
using StructBeaver.Pilhas.Exercicios;

namespace StructBeaver.Tests.Pilhas.Exercicios
{
    public class OrdenacaoPilhaTest
    {
        private readonly OrdenacaoPilha _ordenacaoPilha;

        public OrdenacaoPilhaTest()
            => _ordenacaoPilha = new OrdenacaoPilha();

        [Fact]
        public void OrdenarPilha_Deve_Retornar_Pilha_Ordenada()
        {
            Pilha pilha = new Pilha();
            pilha.Push(55);
            pilha.Push(7);
            pilha.Push(9);
            pilha.Push(32);
            pilha.Push(89);

            pilha = _ordenacaoPilha.OrdenarPilha(pilha);

            Assert.Equal(7, pilha.Pop());
            Assert.Equal(9, pilha.Pop());
            Assert.Equal(32, pilha.Pop());
            Assert.Equal(55, pilha.Pop());
            Assert.Equal(89, pilha.Pop());
        }
    }
}
