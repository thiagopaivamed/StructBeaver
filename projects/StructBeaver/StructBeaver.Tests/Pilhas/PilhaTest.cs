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
            Console.WriteLine($"O elemento {item} foi adicionado na pilha.");
        }

        [Fact]
        public void Pop_Deve_Excluir_Elemento_Na_Pilha()
        {
            int item = 10;
            pilha.Push(item);
            Assert.Equal(item, pilha.Peek());

            int itemRemovido = pilha.Pop();
            Assert.Equal(item, itemRemovido);
            Console.WriteLine($"O elemento {item} foi removido da pilha.");
        }

        [Fact]
        public void Pop_Deve_Disparar_Excecao_Quando_Nao_Houver_Elemento_Na_Pilha()
        {
            Assert.Throws<InvalidOperationException>(() => pilha.Pop());
            Console.WriteLine($"A pilha está vazia. Não há elementos para serem removidos.");
        }

        [Fact]
        public void Peek_Deve_Verificar_Elemento_Na_Pilha()
        {
            int item = 10;
            pilha.Push(item);
            Assert.Equal(item, pilha.Peek());
            Console.WriteLine($"O elemento {item} está na pilha.");
        }

        [Fact]
        public void Peek_Deve_Disparar_Excecao_Quando_Nao_Houver_Elemento_Na_Pilha()
        {
            Assert.Throws<InvalidOperationException>(() => pilha.Peek());
            Console.WriteLine($"A pilha está vazia. Não há elementos no topo.");
        }

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
            Console.WriteLine("A pilha está vazia.");
        }
    }
}
