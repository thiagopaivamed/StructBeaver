using StructBeaver.Listas.ListaDuplamenteEncadeada;
using StructBeaver.Listas.ListaDuplamenteEncadeada.Exercicios;

namespace StructBeaver.Tests.Listas.ListasDuplamenteEncadeadas.Exercicios
{
    public class PesquisaBinariaListaDuplamenteEncadeadaTest
    {
        private PesquisaBinariaListaDuplamenteEncadeada _pesquisaBinariaListaDuplamenteEncadeada;
        private ListaDuplamenteEncadeada _listaDuplamenteEncadeada;

        public PesquisaBinariaListaDuplamenteEncadeadaTest()
        {
            _pesquisaBinariaListaDuplamenteEncadeada = new PesquisaBinariaListaDuplamenteEncadeada();
            _listaDuplamenteEncadeada = new ListaDuplamenteEncadeada();
            _listaDuplamenteEncadeada.AdicionarNoFinal(1);
            _listaDuplamenteEncadeada.AdicionarNoFinal(2);
            _listaDuplamenteEncadeada.AdicionarNoFinal(3);
            _listaDuplamenteEncadeada.AdicionarNoFinal(4);
            _listaDuplamenteEncadeada.AdicionarNoFinal(5);
        }

        [Fact]
        public void Pesquisa_Binaria_Lista_Duplamente_Encadeada_Deve_Retornar_True_Quando_Encontrar_Valor_Pesquisado()
        {
            int valorProcurado = 3;

            bool valorFoiEncontrado = _pesquisaBinariaListaDuplamenteEncadeada.Pesquisar(_listaDuplamenteEncadeada, valorProcurado);

            Assert.True(valorFoiEncontrado);
        }

        [Fact]
        public void Pesquisa_Binaria_Lista_Duplamente_Encadeada_Deve_Retornar_False_Quando_Nao_Encontrar_Valor_Pesquisado()
        {
            int valorProcurado = 30;

            bool valorFoiEncontrado = _pesquisaBinariaListaDuplamenteEncadeada.Pesquisar(_listaDuplamenteEncadeada, valorProcurado);

            Assert.False(valorFoiEncontrado);
        }
    }
}