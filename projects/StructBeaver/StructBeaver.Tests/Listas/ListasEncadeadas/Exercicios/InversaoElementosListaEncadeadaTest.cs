using StructBeaver.Listas.ListaEncadeada;
using StructBeaver.Listas.ListaEncadeada.Exercicios;

namespace StructBeaver.Tests.Listas.ListasEncadeadas.Exercicios
{
    public class InversaoElementosListaEncadeadaTest
    {
        private InversaoElementosListaEncadeada _inversaoElementosListaEncadeada;

        public InversaoElementosListaEncadeadaTest()
            => _inversaoElementosListaEncadeada = new InversaoElementosListaEncadeada();

        [Fact]
        public void Inverter_Deve_Retornar_Lista_Invertida()
        {
            ListaEncadeada listaParaInversao = new ListaEncadeada();
            listaParaInversao.AdicionarNoFim(1);
            listaParaInversao.AdicionarNoFim(2);
            listaParaInversao.AdicionarNoFim(3);
            listaParaInversao.AdicionarNoFim(4);
            listaParaInversao.AdicionarNoFim(5);

            ListaEncadeada listaInvertida = _inversaoElementosListaEncadeada.Inverter(listaParaInversao);

            Assert.Equal(5, listaInvertida.RemoverNoInicio().Valor);
            Assert.Equal(4, listaInvertida.RemoverNoInicio().Valor);
            Assert.Equal(3, listaInvertida.RemoverNoInicio().Valor);
            Assert.Equal(2, listaInvertida.RemoverNoInicio().Valor);
            Assert.Equal(1, listaInvertida.RemoverNoInicio().Valor);
        }
    }
}