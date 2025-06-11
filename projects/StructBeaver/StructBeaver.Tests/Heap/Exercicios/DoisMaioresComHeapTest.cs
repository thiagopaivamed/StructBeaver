using Shouldly;
using StructBeaver.Heap.Exercicios;

namespace StructBeaver.Tests.Heap.Exercicios
{
    public class DoisMaioresComHeapTest
    {
        private readonly DoisMaioresComHeap _doisMaioresComHeap;

        public DoisMaioresComHeapTest()
            => _doisMaioresComHeap = new();        

        [Fact]
        public void Array_Vazio_Deve_Retornar_Null_Null()
        {
            int[] entrada = [];
            (int? maior, int? segundoMaior) resultado = _doisMaioresComHeap.PegarDoisMaiores(entrada);

            resultado.maior.ShouldBeNull();
            resultado.segundoMaior.ShouldBeNull();
        }

        [Fact]
        public void Array_Null_Deve_Retornar_Null_Null()
        {
            int[]? entrada = null;
            (int? maior, int? segundoMaior) resultado = _doisMaioresComHeap.PegarDoisMaiores(entrada);

            resultado.maior.ShouldBeNull();
            resultado.segundoMaior.ShouldBeNull();
        }

        [Fact]
        public void Array_Com_Um_Elemento_Deve_Retornar_Maior_E_Null()
        {
            int[] entrada = [10];
            (int? maior, int? segundoMaior) resultado = _doisMaioresComHeap.PegarDoisMaiores(entrada);

            resultado.maior.ShouldBe(10);
            resultado.segundoMaior.ShouldBeNull();
        }

        [Fact]
        public void Array_Com_Dois_Elementos_Deve_Retornar_Os_Dois_Em_Ordem()
        {
            int[] entrada = [5, 20];
            (int? maior, int? segundoMaior) resultado = _doisMaioresComHeap.PegarDoisMaiores(entrada);

            resultado.maior.ShouldBe(20);
            resultado.segundoMaior.ShouldBe(5);
        }

        [Fact]
        public void Array_Com_Multiplos_Elementos_Deve_Retornar_Os_Dois_Maiores()
        {
            int[] entrada = [3, 9, 12, 7, 42, 15];
            (int? maior, int? segundoMaior) resultado = _doisMaioresComHeap.PegarDoisMaiores(entrada);

            resultado.maior.ShouldBe(42);
            resultado.segundoMaior.ShouldBe(15);
        }

        [Fact]
        public void Array_Com_Elementos_Iguais_Deve_Retornar_Mesmo_Valor_Duas_Vezes()
        {
            int[] entrada = [7, 7, 7, 7];
            (int? maior, int? segundoMaior) resultado = _doisMaioresComHeap.PegarDoisMaiores(entrada);

            resultado.maior.ShouldBe(7);
            resultado.segundoMaior.ShouldBe(7);
        }
    }
}