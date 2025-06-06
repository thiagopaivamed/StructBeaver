using Shouldly;
using StructBeaver.Heap;

namespace StructBeaver.Tests.Heap
{
    public class MinHeapTest
    {
        private readonly MinHeap _minHeap;

        public MinHeapTest()
            => _minHeap = new();

        [Fact]
        public void Inserir_Deve_Adicionar_Um_Elemento_Na_Heap()
        {
            _minHeap.Inserir(10);

            _minHeap.Tamanho.ShouldBe(1);
            _minHeap.Peek().ShouldBe(10);
        }

        [Fact]
        public void Inserir_Multiplos_Elementos_Deve_Manter_O_Menor_No_Topo()
        {
            _minHeap.Inserir(20);
            _minHeap.Inserir(5);
            _minHeap.Inserir(15);

            _minHeap.Tamanho.ShouldBe(3);
            _minHeap.Peek().ShouldBe(5);
        }

        [Fact]
        public void Remover_Deve_Retirar_O_Menor_Elemento_Da_Heap()
        {
            _minHeap.Inserir(30);
            _minHeap.Inserir(10);
            _minHeap.Inserir(20);

            int removido = _minHeap.Remover();

            removido.ShouldBe(10);
            _minHeap.Tamanho.ShouldBe(2);
            _minHeap.Peek().ShouldBe(20);
        }

        [Fact]
        public void Peek_Em_Heap_Vazia_Deve_Lancar_Excecao()
            => Should.Throw<InvalidOperationException>(() => _minHeap.Peek())
                  .Message.ShouldBe("Heap está vazia.");

        [Fact]
        public void Remover_Em_Heap_Vazia_Deve_Lancar_Excecao()
            => Should.Throw<InvalidOperationException>(() => _minHeap.Remover())
                  .Message.ShouldBe("Heap está vazia.");

        [Fact]
        public void Inserir_Valores_Negativos_Deve_Funcionar_Corretamente()
        {
            _minHeap.Inserir(-5);
            _minHeap.Inserir(-10);
            _minHeap.Inserir(0);

            _minHeap.Peek().ShouldBe(-10);
            _minHeap.Remover().ShouldBe(-10);
            _minHeap.Remover().ShouldBe(-5);
            _minHeap.Remover().ShouldBe(0);
        }
    }
}