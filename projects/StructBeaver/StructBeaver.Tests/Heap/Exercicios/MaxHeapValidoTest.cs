using Shouldly;
using StructBeaver.Heap.Exercicios;
using StructBeaver.Heap;

namespace StructBeaver.Tests.Heap.Exercicios
{
    public class MaxHeapValidoTest
    {
        private readonly MaxHeapValido _maxHeapValido;
        private readonly MaxHeap _maxHeap;

        public MaxHeapValidoTest()
        {
            _maxHeapValido = new();
            _maxHeap = new();
        }

        [Fact]
        public void Validar_Heap_Vazio_Deve_Retornar_True()
        {
            bool resultado = _maxHeapValido.Validar(_maxHeap);

            resultado.ShouldBeTrue();
            _maxHeap.Tamanho.ShouldBe(0);
        }

        [Fact]
        public void Validar_Heap_Com_Um_Elemento_Deve_Retornar_True()
        {
            _maxHeap.Inserir(10);

            bool resultado = _maxHeapValido.Validar(_maxHeap);

            resultado.ShouldBeTrue();
            _maxHeap.Tamanho.ShouldBe(1);
            _maxHeap.Peek().ShouldBe(10);
        }

        [Fact]
        public void Validar_Heap_Com_Multiplos_Elementos_Ordenados_Deve_Retornar_True()
        {
            _maxHeap.Inserir(50);
            _maxHeap.Inserir(30);
            _maxHeap.Inserir(40);
            _maxHeap.Inserir(20);
            _maxHeap.Inserir(10);

            bool resultado = _maxHeapValido.Validar(_maxHeap);

            resultado.ShouldBeTrue();
            _maxHeap.Tamanho.ShouldBe(5);
            _maxHeap.Peek().ShouldBe(50);
        }

        [Fact]
        public void Validar_Heap_Apos_Remocoes_Deve_Retornar_True()
        {
            _maxHeap.Inserir(60);
            _maxHeap.Inserir(40);
            _maxHeap.Inserir(50);

            _maxHeap.Remover();

            bool resultado = _maxHeapValido.Validar(_maxHeap);

            resultado.ShouldBeTrue();
            _maxHeap.Tamanho.ShouldBe(2);
            _maxHeap.Peek().ShouldBe(50);
        }

        [Fact]
        public void Validar_Heap_Invalido_Deve_Retornar_False()
        {
            _maxHeap.Inserir(50);
            _maxHeap.Inserir(40);
            _maxHeap.Inserir(60);

            bool resultado = _maxHeapValido.Validar(_maxHeap);
            resultado.ShouldBeTrue();
        }
    }
}
