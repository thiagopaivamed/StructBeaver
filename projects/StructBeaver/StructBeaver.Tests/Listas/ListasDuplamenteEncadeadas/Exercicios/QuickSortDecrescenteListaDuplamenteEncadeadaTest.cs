using StructBeaver.Listas.ListaDuplamenteEncadeada;
using StructBeaver.Listas.ListaDuplamenteEncadeada.Exercicios;

namespace StructBeaver.Tests.Listas.ListasDuplamenteEncadeadas.Exercicios
{
    public class QuickSortDecrescenteListaDuplamenteEncadeadaTest
    {
        private QuickSortDecrescenteListaDuplamenteEncadeada _quickSortDecrescenteListaDuplamenteEncadeada;
        public QuickSortDecrescenteListaDuplamenteEncadeadaTest()
            => _quickSortDecrescenteListaDuplamenteEncadeada = new QuickSortDecrescenteListaDuplamenteEncadeada();

        [Fact]
        public void Quick_Sort_Decrescente_Lista_Deve_Retornar_Lista_Ordenada_Decrescente()
        {
            ListaDuplamenteEncadeada listaDuplamenteEncadeada = new ListaDuplamenteEncadeada();
            listaDuplamenteEncadeada.AdicionarNoFinal(1);
            listaDuplamenteEncadeada.AdicionarNoFinal(2);
            listaDuplamenteEncadeada.AdicionarNoFinal(3);
            listaDuplamenteEncadeada.AdicionarNoFinal(4);
            listaDuplamenteEncadeada.AdicionarNoFinal(5);

            ListaDuplamenteEncadeada listaOrdenada = _quickSortDecrescenteListaDuplamenteEncadeada.QuickSortDecrescente(listaDuplamenteEncadeada);
            NoDuplamenteEncadeado? primeiroNo = listaOrdenada.PegarPrimeiroNo();

            while (primeiroNo.Proximo is not null)
            {
                Assert.True(primeiroNo.Valor > primeiroNo.Proximo.Valor);
                primeiroNo = primeiroNo.Proximo;
            }
        }
    }
}