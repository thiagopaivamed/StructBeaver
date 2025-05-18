using Shouldly;
using StructBeaver.Listas.ListaEncadeada;
using StructBeaver.Listas.ListaEncadeada.Exercicios;

namespace StructBeaver.Tests.Listas.ListasEncadeadas.Exercicios
{
    public class InsertionSortListaEncadeadaTest
    {
        private readonly InsertionSortListaEncadeada _insertionSortListaEncadeada;

        public InsertionSortListaEncadeadaTest()
            => _insertionSortListaEncadeada = new();

        [Fact]
        public void Insertion_Sort_Lista_Deve_Retornar_Lista_Ordenada()
        {
            ListaEncadeada listaParaOrdenar = new();
            listaParaOrdenar.AdicionarNoFim(5);
            listaParaOrdenar.AdicionarNoFim(7);
            listaParaOrdenar.AdicionarNoFim(3);
            listaParaOrdenar.AdicionarNoFim(9);
            listaParaOrdenar.AdicionarNoFim(2);

            ListaEncadeada listaOrdenada = _insertionSortListaEncadeada.Ordenar(listaParaOrdenar);

            while (listaOrdenada.PrimeiroNo!.Proximo is not null)
            {
                listaOrdenada.PrimeiroNo.Valor.ShouldBeLessThan(listaOrdenada.PrimeiroNo.Proximo.Valor);
                listaOrdenada.PrimeiroNo = listaOrdenada.PrimeiroNo.Proximo;
            }
        }
    }
}
