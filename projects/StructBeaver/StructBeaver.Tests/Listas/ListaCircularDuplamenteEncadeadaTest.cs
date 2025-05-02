using StructBeaver.Listas;

namespace StructBeaver.Tests.Listas
{
    public class ListaCircularDuplamenteEncadeadaTest
    {
        private ListaCircularDuplamenteEncadeada _listaCircularDuplamenteEncadeada;

        public ListaCircularDuplamenteEncadeadaTest()
            => _listaCircularDuplamenteEncadeada = new ListaCircularDuplamenteEncadeada();
        

        [Fact]
        public void Adicionar_No_Inicio_Deve_Inserir_E_Retornar_No()
        {
            ListaCircularDuplamenteEncadeada.No? noAdicionado = _listaCircularDuplamenteEncadeada.AdicionarNoInicio(10);

            Assert.NotNull(noAdicionado);
            Assert.Equal(10, noAdicionado.Valor);
            Assert.Same(noAdicionado, noAdicionado.Proximo);
            Assert.Same(noAdicionado, noAdicionado.Anterior);
            Assert.Same(noAdicionado, _listaCircularDuplamenteEncadeada.primeiroNo);
        }

        [Fact]
        public void Adicionar_No_Fim_Deve_Inserir_Nos_Na_Ordem_Certa_E_Retornar()
        {
            ListaCircularDuplamenteEncadeada.No? noAdicionado1 = _listaCircularDuplamenteEncadeada.AdicionarNoFim(10);
            ListaCircularDuplamenteEncadeada.No? noAdicionado2 = _listaCircularDuplamenteEncadeada.AdicionarNoFim(20);

            Assert.NotNull(noAdicionado1);
            Assert.NotNull(noAdicionado2);
            Assert.Equal(10, noAdicionado1.Valor);
            Assert.Equal(20, noAdicionado2.Valor);
            Assert.Same(noAdicionado1, noAdicionado2.Proximo);
            Assert.Same(noAdicionado2, noAdicionado1.Anterior);
            Assert.Same(noAdicionado2, _listaCircularDuplamenteEncadeada.primeiroNo.Anterior);
        }

        [Fact]
        public void Remover_No_Deve_Retornar_No_Removido()
        {
            _listaCircularDuplamenteEncadeada.AdicionarNoInicio(5);

            ListaCircularDuplamenteEncadeada.No? noRemovido = _listaCircularDuplamenteEncadeada.Remover(5);

            Assert.NotNull(noRemovido);
            Assert.Equal(5, noRemovido.Valor);
            Assert.Null(_listaCircularDuplamenteEncadeada.primeiroNo);
        }

        [Fact]
        public void Remover_No_Do_Meio_Deve_Retornar_No_Removido()
        {
            _listaCircularDuplamenteEncadeada.AdicionarNoFim(1);
            _listaCircularDuplamenteEncadeada.AdicionarNoFim(2);
            _listaCircularDuplamenteEncadeada.AdicionarNoFim(3);

            ListaCircularDuplamenteEncadeada.No? noRemovido = _listaCircularDuplamenteEncadeada.Remover(2);

            Assert.NotNull(noRemovido);
            Assert.Equal(2, noRemovido.Valor);

            ListaCircularDuplamenteEncadeada.No? primeiro = _listaCircularDuplamenteEncadeada.primeiroNo;
            ListaCircularDuplamenteEncadeada.No segundo = primeiro.Proximo;

            Assert.Equal(1, primeiro.Valor);
            Assert.Equal(3, segundo.Valor);
            Assert.Same(primeiro, segundo.Proximo);
            Assert.Same(segundo, primeiro.Anterior);
        }

        [Fact]
        public void RemoverElementoInexistente_DeveRetornarNull()
        {
            _listaCircularDuplamenteEncadeada.AdicionarNoFim(1);
            _listaCircularDuplamenteEncadeada.AdicionarNoFim(2);

            ListaCircularDuplamenteEncadeada.No? noRemovido = _listaCircularDuplamenteEncadeada.Remover(99);

            Assert.Null(noRemovido);

            ListaCircularDuplamenteEncadeada.No? primeiro = _listaCircularDuplamenteEncadeada.primeiroNo;
            ListaCircularDuplamenteEncadeada.No segundo = primeiro.Proximo;

            Assert.Equal(1, primeiro.Valor);
            Assert.Equal(2, segundo.Valor);
            Assert.Same(primeiro, segundo.Proximo);
            Assert.Same(segundo, primeiro.Anterior);
        }
    }
}