using StructBeaver.Listas.ListaCircular;
using StructBeaver.Listas.ListaCircular.Exercicios;

namespace StructBeaver.Tests.Listas.ListaCircular.Exercicios
{
    public class PesquisaRecursivaListaCircularTest
    {
        private PesquisaRecursivaListaCircular _pesquisaRecursivaListaCircular;
        private ListaCircularDuplamenteEncadeada _listaCircular;

        public PesquisaRecursivaListaCircularTest()
        {
            _pesquisaRecursivaListaCircular = new PesquisaRecursivaListaCircular();

            _listaCircular = new ListaCircularDuplamenteEncadeada();
            _listaCircular.AdicionarNoInicio(1);
            _listaCircular.AdicionarNoInicio(2);
            _listaCircular.AdicionarNoInicio(3);
            _listaCircular.AdicionarNoInicio(4);
            _listaCircular.AdicionarNoInicio(5);
        }

        [Fact]
        public void Pesquisa_Binaria_Recursiva_Deve_Retornar_True_Quando_Encontrar_Valor_Pesquisado()
        {
            int valor = 5;

            bool valorFoiEncontrado = _pesquisaRecursivaListaCircular.Pesquisar(_listaCircular, valor);

            Assert.True(valorFoiEncontrado);
        }

        [Fact]
        public void Pesquisa_Binaria_Recursiva_Deve_Retornar_False_Quando_Nao_Encontrar_Valor_Pesquisado()
        {
            int valor = 50;

            bool valorFoiEncontrado = _pesquisaRecursivaListaCircular.Pesquisar(_listaCircular, valor);

            Assert.False(valorFoiEncontrado);
        }
    }
}