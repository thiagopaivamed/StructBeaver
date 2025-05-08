using StructBeaver.Listas.ListaEncadeada;

namespace StructBeaver.Tests.Listas.ListasEncadeadas
{
    public class ListaEncadeadaTest
    {
        private ListaEncadeada _listaEncadeada;

        public ListaEncadeadaTest()
            => _listaEncadeada = new ListaEncadeada();


        [Fact]
        public void AdicionarInicio_Deve_Adicionar_No_Inicio()
        {
            No no = _listaEncadeada.AdicionarNoInicio(10);

            Assert.Equal(10, no.Valor);
            Assert.Equal(1, _listaEncadeada.Size());
        }

        [Fact]
        public void AdicionarFim_Deve_Adicionar_No_Fim()
        {
            No no = _listaEncadeada.AdicionarNoFim(20);

            Assert.Equal(20, no.Valor);
            Assert.Equal(1, _listaEncadeada.Size());
        }

        [Fact]
        public void RemoverInicio_Deve_Remover_Primeiro_Elemento()
        {
            _listaEncadeada.AdicionarNoInicio(5);
            _listaEncadeada.AdicionarNoInicio(10);

            No removido = _listaEncadeada.RemoverNoInicio();

            Assert.Equal(10, removido.Valor);
            Assert.Equal(1, _listaEncadeada.Size());
        }

        [Fact]
        public void RemoverInicio_Em_Lista_Vazia_Deve_Retornar_Null()
        {
            No removido = _listaEncadeada.RemoverNoInicio();

            Assert.Null(removido);
        }

        [Fact]
        public void RemoverFim_ListaComUmElemento_DeveZerarLista()
        {
            _listaEncadeada.AdicionarNoInicio(42);

            No removido = _listaEncadeada.RemoverNoFim();

            Assert.Equal(42, removido.Valor);
            Assert.True(_listaEncadeada.IsEmpty());
        }

        [Fact]
        public void RemoverFim_Deve_Remover_Ultimo_No()
        {
            _listaEncadeada.AdicionarNoInicio(1);
            _listaEncadeada.AdicionarNoFim(2);
            _listaEncadeada.AdicionarNoFim(3);

            No removido = _listaEncadeada.RemoverNoFim();

            Assert.Equal(3, removido.Valor);
            Assert.Equal(2, _listaEncadeada.Size());
        }

        [Fact]
        public void RemoverFim_Em_Lista_Vazia_Deve_Retornar_Null()
        {
            No removido = _listaEncadeada.RemoverNoFim();

            Assert.Null(removido);
        }

        [Fact]
        public void Pesquisar_Valor_Existente_Deve_Retornar_No()
        {
            _listaEncadeada.AdicionarNoInicio(7);
            _listaEncadeada.AdicionarNoFim(15);

            No resultado = _listaEncadeada.Pesquisar(15);

            Assert.NotNull(resultado);
            Assert.Equal(15, resultado.Valor);
        }

        [Fact]
        public void Pesquisar_Valor_Inexistente_Deve_Retornar_Null()
        {
            _listaEncadeada.AdicionarNoInicio(7);
            _listaEncadeada.AdicionarNoFim(15);

            No resultado = _listaEncadeada.Pesquisar(99);

            Assert.Null(resultado);
        }

        [Fact]
        public void Size_Lista_Vazia_Deve_Ser_Zero()
            => Assert.Equal(0, _listaEncadeada.Size());

        [Fact]
        public void Size_Apos_Insercoes_Deve_Retornar_Maior_Que_Zero()
        {
            _listaEncadeada.AdicionarNoInicio(1);
            _listaEncadeada.AdicionarNoFim(2);
            _listaEncadeada.AdicionarNoFim(3);

            Assert.Equal(3, _listaEncadeada.Size());
        }

        [Fact]
        public void IsEmpty_Lista_Nova_Deve_Ser_Verdadeiro()
            => Assert.True(_listaEncadeada.IsEmpty());

        [Fact]
        public void IsEmpty_AposInsercao_DeveSerFalso()
        {
            _listaEncadeada.AdicionarNoInicio(99);

            Assert.False(_listaEncadeada.IsEmpty());
        }
    }
}