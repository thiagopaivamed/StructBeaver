using Shouldly;
using StructBeaver.Heap;

namespace StructBeaver.Tests.Heap
{
    public class MaxHeapTest
    {
        private readonly MaxHeap _maxHeap;

        public MaxHeapTest()
            => _maxHeap = new MaxHeap();

        [Fact]
        public void Inserir_Deve_Manter_Maior_Elemento_Na_Raiz()
        {
            _maxHeap.Inserir(10);
            _maxHeap.Inserir(30);
            _maxHeap.Inserir(20);

            _maxHeap.Peek().ShouldBe(30);
        }

        [Fact]
        public void Remover_Deve_Retornar_Maior_Elemento()
        {
            _maxHeap.Inserir(5);
            _maxHeap.Inserir(15);
            _maxHeap.Inserir(25);

            int removido = _maxHeap.Remover();

            removido.ShouldBe(25);
            _maxHeap.Tamanho.ShouldBe(2);
            _maxHeap.Peek().ShouldBe(15);
        }

        [Fact]
        public void Peek_Em_Heap_Vazia_Deve_Lancar_Excecao()
        {
            InvalidOperationException ex = Should.Throw<InvalidOperationException>(() => _maxHeap.Peek());
            ex.Message.ShouldBe("Heap está vazia.");
        }

        [Fact]
        public void Remover_Em_Heap_Vazia_Deve_Lancar_Excecao()
        {
            InvalidOperationException ex = Should.Throw<InvalidOperationException>(() => _maxHeap.Remover());
            ex.Message.ShouldBe("Heap está vazia.");
        }

        [Fact]
        public void Inserir_Elementos_Com_Mesmo_Valor_Deve_Permitir()
        {
            _maxHeap.Inserir(10);
            _maxHeap.Inserir(10);
            _maxHeap.Inserir(10);

            _maxHeap.Peek().ShouldBe(10);
            _maxHeap.Tamanho.ShouldBe(3);
        }

        [Fact]
        public void Inserir_Em_Ordem_Decrescente_Deve_Manter_Propriedade_Heap()
        {
            _maxHeap.Inserir(30);
            _maxHeap.Inserir(20);
            _maxHeap.Inserir(10);

            _maxHeap.Peek().ShouldBe(30);
            _maxHeap.Tamanho.ShouldBe(3);
        }

        [Fact]
        public void Inserir_Em_Ordem_Crescente_Deve_Manter_Propriedade_Heap()
        {
            _maxHeap.Inserir(10);
            _maxHeap.Inserir(20);
            _maxHeap.Inserir(30);

            _maxHeap.Peek().ShouldBe(30);
            _maxHeap.Tamanho.ShouldBe(3);
        }
    }
}
