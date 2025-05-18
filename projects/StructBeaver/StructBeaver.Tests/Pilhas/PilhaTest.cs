using Shouldly;
using StructBeaver.Pilhas;

namespace StructBeaver.Tests.Pilhas
{
    public class PilhaTest
    {
        private readonly Pilha _pilha;
        public PilhaTest()
            => _pilha = new();

        [Fact]
        public void Push_Deve_Adicionar_Elemento_Na_Pilha()
        {
            int item = 10;
            _pilha.Push(item);
            _pilha.Peek().ShouldBe(item);
        }

        [Fact]
        public void Pop_Deve_Excluir_Elemento_Na_Pilha()
        {
            int item = 10;
            _pilha.Push(item);
            _pilha.Peek().ShouldBe(item);

            int itemRemovido = _pilha.Pop();
            itemRemovido.ShouldBe(item);
        }

        [Fact]
        public void Pop_Deve_Disparar_Excecao_Quando_Nao_Houver_Elemento_Na_Pilha()
            => Assert.Throws<InvalidOperationException>(() => _pilha.Pop());

        [Fact]
        public void Peek_Deve_Verificar_Elemento_Na_Pilha()
        {
            int item = 10;
            _pilha.Push(item);
            _pilha.Peek().ShouldBe(item);
        }

        [Fact]
        public void Peek_Deve_Disparar_Excecao_Quando_Nao_Houver_Elemento_Na_Pilha()
            => Assert.Throws<InvalidOperationException>(() => _pilha.Peek());


        [Fact]
        public void IsEmpty_Deve_Verificar_Pilha_Vazia()
        {
            _pilha.Push(10);
            _pilha.Push(20);
            _pilha.Push(30);

            _pilha.Pop();
            _pilha.Pop();
            _pilha.Pop();

            _pilha.IsEmpty().ShouldBeTrue();
        }
    }
}