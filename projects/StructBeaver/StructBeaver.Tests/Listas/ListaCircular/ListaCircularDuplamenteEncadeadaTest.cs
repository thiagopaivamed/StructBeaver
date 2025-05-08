using StructBeaver.Listas.ListaCircular;

namespace StructBeaver.Tests.Listas.ListaCircular
{
    public class ListaCircularDuplamenteEncadeadaTest
    {
        private ListaCircularDuplamenteEncadeada _listaCircularDuplamenteEncadeada;

        public ListaCircularDuplamenteEncadeadaTest()
            => _listaCircularDuplamenteEncadeada = new ListaCircularDuplamenteEncadeada();
        

        [Fact]
        public void Adicionar_No_Inicio_Deve_Inserir_E_Retornar_No()
        {
            NoCircular noAdicionado = _listaCircularDuplamenteEncadeada.AdicionarNoInicio(10);

            Assert.NotNull(noAdicionado);
            Assert.Equal(10, noAdicionado.Valor);
            Assert.Same(noAdicionado, noAdicionado.Proximo);
            Assert.Same(noAdicionado, noAdicionado.Anterior);
            Assert.Same(noAdicionado, _listaCircularDuplamenteEncadeada.PrimeiroNo);
        }

        [Fact]
        public void Adicionar_No_Fim_Deve_Inserir_Nos_Na_Ordem_Certa_E_Retornar()
        {
            NoCircular noAdicionado1 = _listaCircularDuplamenteEncadeada.AdicionarNoFim(10);
            NoCircular noAdicionado2 = _listaCircularDuplamenteEncadeada.AdicionarNoFim(20);

            Assert.NotNull(noAdicionado1);
            Assert.NotNull(noAdicionado2);
            Assert.Equal(10, noAdicionado1.Valor);
            Assert.Equal(20, noAdicionado2.Valor);
            Assert.Same(noAdicionado1, noAdicionado2.Proximo);
            Assert.Same(noAdicionado2, noAdicionado1.Anterior);
            Assert.Same(noAdicionado2, _listaCircularDuplamenteEncadeada.PrimeiroNo.Anterior);
        }

        [Fact]
        public void Remover_No_Deve_Retornar_No_Removido()
        {
            _listaCircularDuplamenteEncadeada.AdicionarNoInicio(5);

            NoCircular noRemovido = _listaCircularDuplamenteEncadeada.Remover(5);

            Assert.NotNull(noRemovido);
            Assert.Equal(5, noRemovido.Valor);
            Assert.Null(_listaCircularDuplamenteEncadeada.PrimeiroNo);
        }

        [Fact]
        public void Remover_No_Do_Meio_Deve_Retornar_No_Removido()
        {
            _listaCircularDuplamenteEncadeada.AdicionarNoFim(1);
            _listaCircularDuplamenteEncadeada.AdicionarNoFim(2);
            _listaCircularDuplamenteEncadeada.AdicionarNoFim(3);

            NoCircular noRemovido = _listaCircularDuplamenteEncadeada.Remover(2);

            Assert.NotNull(noRemovido);
            Assert.Equal(2, noRemovido.Valor);

            NoCircular primeiro = _listaCircularDuplamenteEncadeada.PrimeiroNo;
            NoCircular segundo = primeiro.Proximo;

            Assert.Equal(1, primeiro.Valor);
            Assert.Equal(3, segundo.Valor);
            Assert.Same(primeiro, segundo.Proximo);
            Assert.Same(segundo, primeiro.Anterior);
        }

        [Fact]
        public void Remover_Elemento_Inexistente_Deve_Retornar_Null()
        {
            _listaCircularDuplamenteEncadeada.AdicionarNoFim(1);
            _listaCircularDuplamenteEncadeada.AdicionarNoFim(2);

            NoCircular noRemovido = _listaCircularDuplamenteEncadeada.Remover(99);

            Assert.Null(noRemovido);

            NoCircular primeiro = _listaCircularDuplamenteEncadeada.PrimeiroNo;
            NoCircular segundo = primeiro.Proximo;

            Assert.Equal(1, primeiro.Valor);
            Assert.Equal(2, segundo.Valor);
            Assert.Same(primeiro, segundo.Proximo);
            Assert.Same(segundo, primeiro.Anterior);
        }
    }
}