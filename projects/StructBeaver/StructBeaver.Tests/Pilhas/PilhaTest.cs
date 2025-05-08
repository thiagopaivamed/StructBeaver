using StructBeaver.Pilhas;

namespace StructBeaver.Tests.Pilhas
{
    public class PilhaTest
    {
        private Pilha pilha;
        public PilhaTest()
            => pilha = new Pilha();

        [Fact]
        public void Push_Deve_Adicionar_Elemento_Na_Pilha()
        {
            int item = 10;
            pilha.Push(item);
            Assert.Equal(item, pilha.Peek());
        }

        [Fact]
        public void Pop_Deve_Excluir_Elemento_Na_Pilha()
        {
            int item = 10;
            pilha.Push(item);
            Assert.Equal(item, pilha.Peek());

            int itemRemovido = pilha.Pop();
            Assert.Equal(item, itemRemovido);
        }

        [Fact]
        public void Pop_Deve_Disparar_Excecao_Quando_Nao_Houver_Elemento_Na_Pilha()
            => Assert.Throws<InvalidOperationException>(() => pilha.Pop());

        [Fact]
        public void Peek_Deve_Verificar_Elemento_Na_Pilha()
        {
            int item = 10;
            pilha.Push(item);
            Assert.Equal(item, pilha.Peek());
        }

        [Fact]
        public void Peek_Deve_Disparar_Excecao_Quando_Nao_Houver_Elemento_Na_Pilha()
            => Assert.Throws<InvalidOperationException>(() => pilha.Peek());


        [Fact]
        public void IsEmpty_Deve_Verificar_Pilha_Vazia()
        {
            pilha.Push(10);
            pilha.Push(20);
            pilha.Push(30);

            pilha.Pop();
            pilha.Pop();
            pilha.Pop();

            Assert.True(pilha.IsEmpty());
        }
    }
}
