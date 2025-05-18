using Shouldly;
using StructBeaver.Listas.ListaCircular;
using StructBeaver.Listas.ListaCircular.Exercicios;

namespace StructBeaver.Tests.Listas.ListaCircular.Exercicios
{
    public class QuantidadeNosListaCircularTest
    {
        private readonly QuantidadeNosListaCircular _quantidadeNosListaCircular;

        public QuantidadeNosListaCircularTest()
            => _quantidadeNosListaCircular = new();

        [Fact]
        public void Quantidade_Nos_Lista_Circular_Deve_Retornar_Quantidade_De_Nos_Na_Lista_Circular()
        {
            ListaCircularDuplamenteEncadeada listaCircular = new();
            listaCircular.AdicionarNoInicio(1);
            listaCircular.AdicionarNoInicio(2);
            listaCircular.AdicionarNoInicio(3);
            listaCircular.AdicionarNoInicio(4);
            listaCircular.AdicionarNoInicio(5);

            int quantidadeNos = _quantidadeNosListaCircular.ContarQuantidadeNos(listaCircular);

            quantidadeNos.ShouldBe(5);
        }
    }
}