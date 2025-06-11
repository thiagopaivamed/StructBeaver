using Shouldly;
using StructBeaver.Heap.Exercicios;
using StructBeaver.Heap;

namespace StructBeaver.Tests.Heap.Exercicios
{
    public class HeapParaArrayOrdenadoTest
    {
        private readonly HeapParaArrayOrdenado _heapParaArrayOrdenado;
        private readonly MaxHeap _maxHeap;

        public HeapParaArrayOrdenadoTest()
        {
            _maxHeap = new();
            _heapParaArrayOrdenado = new();
        }

        [Fact]
        public void Consumir_Deve_Retornar_Array_Vazio_Quando_Heap_Estiver_Vazia()
        {
            int[] resultado = _heapParaArrayOrdenado.Converter(_maxHeap);

            resultado.ShouldBeEmpty();
        }

        [Fact]
        public void Consumir_Deve_Retornar_Elementos_Em_Ordem_Decrescente()
        {
            _maxHeap.Inserir(10);
            _maxHeap.Inserir(30);
            _maxHeap.Inserir(20);
            _maxHeap.Inserir(5);

            int[] resultado = _heapParaArrayOrdenado.Converter(_maxHeap);

            resultado.ShouldBe([30, 20, 10, 5]);
        }

        [Fact]
        public void Consumir_Deve_Esvaziar_A_Heap()
        {
            _maxHeap.Inserir(15);
            _maxHeap.Inserir(25);

            _heapParaArrayOrdenado.Converter(_maxHeap);

            _maxHeap.Tamanho.ShouldBe(0);
        }

        [Fact]
        public void Consumir_Nao_Deve_Lancar_Excecao_Com_Heap_Com_Um_Elemento()
        {
            _maxHeap.Inserir(99);

            int[] resultado = _heapParaArrayOrdenado.Converter(_maxHeap);

            resultado.Length.ShouldBe(1);
            resultado[0].ShouldBe(99);
        }

        [Fact]
        public void Consumir_Deve_Funcionar_Com_Elementos_Duplicados()
        {
            _maxHeap.Inserir(10);
            _maxHeap.Inserir(10);
            _maxHeap.Inserir(5);
            _maxHeap.Inserir(5);

            int[] resultado = _heapParaArrayOrdenado.Converter(_maxHeap);

            resultado.ShouldBe([10, 10, 5, 5]);
        }
    }
}