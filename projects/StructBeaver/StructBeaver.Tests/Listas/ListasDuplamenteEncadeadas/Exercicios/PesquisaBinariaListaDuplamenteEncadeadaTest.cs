using Shouldly;
using StructBeaver.Listas.ListaDuplamenteEncadeada;
using StructBeaver.Listas.ListaDuplamenteEncadeada.Exercicios;

namespace StructBeaver.Tests.Listas.ListasDuplamenteEncadeadas.Exercicios
{
    public class PesquisaBinariaListaDuplamenteEncadeadaTest
    {
        private readonly PesquisaBinariaListaDuplamenteEncadeada _pesquisaBinariaListaDuplamenteEncadeada;
        private readonly ListaDuplamenteEncadeada _listaDuplamenteEncadeada;

        public PesquisaBinariaListaDuplamenteEncadeadaTest()
        {
            _pesquisaBinariaListaDuplamenteEncadeada = new();
            _listaDuplamenteEncadeada = new();
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

            valorFoiEncontrado.ShouldBeTrue();
        }

        [Fact]
        public void Pesquisa_Binaria_Lista_Duplamente_Encadeada_Deve_Retornar_False_Quando_Nao_Encontrar_Valor_Pesquisado()
        {
            int valorProcurado = 30;

            bool valorFoiEncontrado = _pesquisaBinariaListaDuplamenteEncadeada.Pesquisar(_listaDuplamenteEncadeada, valorProcurado);

            valorFoiEncontrado.ShouldBeFalse();
        }
    }
}