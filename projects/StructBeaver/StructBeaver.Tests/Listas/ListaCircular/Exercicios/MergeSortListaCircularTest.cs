using StructBeaver.Listas.ListaCircular;
using StructBeaver.Listas.ListaCircular.Exercicios;

namespace StructBeaver.Tests.Listas.ListaCircular.Exercicios
{
    public class MergeSortListaCircularTest
    {
        private MergeSortListaCircular _mergeSortListaCircular;

        public MergeSortListaCircularTest()
            => _mergeSortListaCircular = new MergeSortListaCircular();

        [Fact]
        public void Merge_Sort_Lista_Circular_Deve_Retornar_Lista_Circular_Ordenada()
        {
            ListaCircularDuplamenteEncadeada listaCircular = new ListaCircularDuplamenteEncadeada();
            listaCircular.AdicionarNoFim(10);
            listaCircular.AdicionarNoFim(2);
            listaCircular.AdicionarNoFim(39);
            listaCircular.AdicionarNoFim(4);
            listaCircular.AdicionarNoFim(15);

            listaCircular = _mergeSortListaCircular.Ordenar(listaCircular);

            NoCircular noAtual = listaCircular.PegarPrimeiroNo();
            NoCircular primeiroNo = noAtual;

            while(noAtual.Proximo != primeiroNo)
            {
                Assert.True(noAtual.Valor <= noAtual.Proximo.Valor);
                noAtual = noAtual.Proximo;
            }
        }

    }
}
