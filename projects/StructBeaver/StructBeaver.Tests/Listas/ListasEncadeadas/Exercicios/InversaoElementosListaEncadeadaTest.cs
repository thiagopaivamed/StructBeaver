using Shouldly;
using StructBeaver.Listas.ListaEncadeada;
using StructBeaver.Listas.ListaEncadeada.Exercicios;

namespace StructBeaver.Tests.Listas.ListasEncadeadas.Exercicios
{
    public class InversaoElementosListaEncadeadaTest
    {
        private readonly InversaoElementosListaEncadeada _inversaoElementosListaEncadeada;

        public InversaoElementosListaEncadeadaTest()
            => _inversaoElementosListaEncadeada = new();

        [Fact]
        public void Inverter_Deve_Retornar_Lista_Invertida()
        {
            ListaEncadeada listaParaInversao = new();
            listaParaInversao.AdicionarNoFim(1);
            listaParaInversao.AdicionarNoFim(2);
            listaParaInversao.AdicionarNoFim(3);
            listaParaInversao.AdicionarNoFim(4);
            listaParaInversao.AdicionarNoFim(5);

            ListaEncadeada listaInvertida = _inversaoElementosListaEncadeada.Inverter(listaParaInversao);

            listaInvertida.RemoverNoInicio()!.Valor.ShouldBe(5);
            listaInvertida.RemoverNoInicio()!.Valor.ShouldBe(4);
            listaInvertida.RemoverNoInicio()!.Valor.ShouldBe(3);
            listaInvertida.RemoverNoInicio()!.Valor.ShouldBe(2);
            listaInvertida.RemoverNoInicio()!.Valor.ShouldBe(1);
        }
    }
}