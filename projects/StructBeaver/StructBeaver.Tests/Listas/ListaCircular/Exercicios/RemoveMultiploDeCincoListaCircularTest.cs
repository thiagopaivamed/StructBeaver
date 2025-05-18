using Shouldly;
using StructBeaver.Listas.ListaCircular;
using StructBeaver.Listas.ListaCircular.Exercicios;

namespace StructBeaver.Tests.Listas.ListaCircular.Exercicios
{
    public class RemoveMultiploDeCincoListaCircularTest
    {
        private readonly RemoveMultiploDeCincoListaCircular _removeMultiploDeCincoListaCircular;

        public RemoveMultiploDeCincoListaCircularTest()
            => _removeMultiploDeCincoListaCircular = new();

        [Fact]
        public void Remover_Multiplo_De_Cinco_Deve_Remover_Todos_Multiplos_De_Cinco_Da_Lista_Circular()
        {
            ListaCircularDuplamenteEncadeada listaCircular = new();
            listaCircular.AdicionarNoInicio(20);
            listaCircular.AdicionarNoInicio(2);
            listaCircular.AdicionarNoInicio(3);
            listaCircular.AdicionarNoInicio(4);
            listaCircular.AdicionarNoInicio(5);
            listaCircular.AdicionarNoInicio(10);
            listaCircular.AdicionarNoInicio(15);
            listaCircular.AdicionarNoInicio(17);

            listaCircular = _removeMultiploDeCincoListaCircular.RemoverMultiploDeCinco(listaCircular);

            NoCircular? noAtual = listaCircular.PrimeiroNo;
            NoCircular? primeiroNo = noAtual;

            do
            {
                (noAtual!.Valor % 5).ShouldNotBe(0);
                noAtual = noAtual.Proximo;
            }
            while (noAtual != primeiroNo);
        }
    }
}