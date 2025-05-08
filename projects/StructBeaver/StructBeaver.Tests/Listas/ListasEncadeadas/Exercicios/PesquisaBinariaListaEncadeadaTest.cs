using StructBeaver.Listas.ListaEncadeada;
using StructBeaver.Listas.ListaEncadeada.Exercicios;

namespace StructBeaver.Tests.Listas.ListasEncadeadas.Exercicios
{
    public class PesquisaBinariaListaEncadeadaTest
    {
        private PesquisaBinariaListaEncadeada _pesquisaBinariaLista;
        private ListaEncadeada listaEncadeada;

        public PesquisaBinariaListaEncadeadaTest()
        {
            _pesquisaBinariaLista = new PesquisaBinariaListaEncadeada();

            listaEncadeada = new ListaEncadeada();
            listaEncadeada.AdicionarNoFim(1);
            listaEncadeada.AdicionarNoFim(2);
            listaEncadeada.AdicionarNoFim(3);
            listaEncadeada.AdicionarNoFim(4);
            listaEncadeada.AdicionarNoFim(5);
        }

        [Fact]
        public void Pesquisa_Binaria_Lista_Deve_Retornar_True_Quando_Encontrar_Valor_Pesquisado()
        {
            int valorProcurado = 3;

            bool valorFoiEncontrado = _pesquisaBinariaLista.Pesquisar(listaEncadeada, valorProcurado);

            Assert.True(valorFoiEncontrado);
        }

        [Fact]
        public void Pesquisa_Binaria_Lista_Deve_Retornar_False_Quando_Nao_Encontrar_Valor_Pesquisado()
        {
            int valorProcurado = 30;

            bool valorFoiEncontrado = _pesquisaBinariaLista.Pesquisar(listaEncadeada, valorProcurado);

            Assert.False(valorFoiEncontrado);
        }
    }
}