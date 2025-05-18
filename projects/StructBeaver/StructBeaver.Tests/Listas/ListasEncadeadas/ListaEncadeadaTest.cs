using Shouldly;
using StructBeaver.Listas.ListaEncadeada;

namespace StructBeaver.Tests.Listas.ListasEncadeadas
{
    public class ListaEncadeadaTest
    {
        private readonly ListaEncadeada _listaEncadeada;

        public ListaEncadeadaTest()
            => _listaEncadeada = new();


        [Fact]
        public void AdicionarInicio_Deve_Adicionar_No_Inicio()
        {
            No no = _listaEncadeada.AdicionarNoInicio(10);

            no.Valor.ShouldBe(10);
            _listaEncadeada.Size().ShouldBe(1);
        }

        [Fact]
        public void AdicionarFim_Deve_Adicionar_No_Fim()
        {
            No no = _listaEncadeada.AdicionarNoFim(20);

            no.Valor.ShouldBe(20);
            _listaEncadeada.Size().ShouldBe(1);
        }

        [Fact]
        public void RemoverInicio_Deve_Remover_Primeiro_Elemento()
        {
            _listaEncadeada.AdicionarNoInicio(5);
            _listaEncadeada.AdicionarNoInicio(10);

            No? removido = _listaEncadeada.RemoverNoInicio();

            removido?.Valor.ShouldBe(10);
            _listaEncadeada.Size().ShouldBe(1);
        }

        [Fact]
        public void RemoverInicio_Em_Lista_Vazia_Deve_Retornar_Null()
        {
            No? removido = _listaEncadeada.RemoverNoInicio();

            removido.ShouldBeNull();
        }

        [Fact]
        public void RemoverFim_ListaComUmElemento_DeveZerarLista()
        {
            _listaEncadeada.AdicionarNoInicio(42);

            No? removido = _listaEncadeada.RemoverNoFim();

            removido?.Valor.ShouldBe(42);
            _listaEncadeada.IsEmpty().ShouldBeTrue();
        }

        [Fact]
        public void RemoverFim_Deve_Remover_Ultimo_No()
        {
            _listaEncadeada.AdicionarNoInicio(1);
            _listaEncadeada.AdicionarNoFim(2);
            _listaEncadeada.AdicionarNoFim(3);

            No? removido = _listaEncadeada.RemoverNoFim();

            removido?.Valor.ShouldBe(3);
            _listaEncadeada.Size().ShouldBe(2);
        }

        [Fact]
        public void RemoverFim_Em_Lista_Vazia_Deve_Retornar_Null()
        {
            No? removido = _listaEncadeada.RemoverNoFim();

            removido.ShouldBeNull();
        }

        [Fact]
        public void Pesquisar_Valor_Existente_Deve_Retornar_No()
        {
            _listaEncadeada.AdicionarNoInicio(7);
            _listaEncadeada.AdicionarNoFim(15);

            No? resultado = _listaEncadeada.Pesquisar(15);

            resultado.ShouldNotBeNull();
            resultado.Valor.ShouldBe(15);
        }

        [Fact]
        public void Pesquisar_Valor_Inexistente_Deve_Retornar_Null()
        {
            _listaEncadeada.AdicionarNoInicio(7);
            _listaEncadeada.AdicionarNoFim(15);

            No? resultado = _listaEncadeada.Pesquisar(99);

            resultado.ShouldBeNull();
        }

        [Fact]
        public void Size_Lista_Vazia_Deve_Ser_Zero()
            => _listaEncadeada.Size().ShouldBe(0);

        [Fact]
        public void Size_Apos_Insercoes_Deve_Retornar_Maior_Que_Zero()
        {
            _listaEncadeada.AdicionarNoInicio(1);
            _listaEncadeada.AdicionarNoFim(2);
            _listaEncadeada.AdicionarNoFim(3);

            _listaEncadeada.Size().ShouldBe(3);
        }

        [Fact]
        public void IsEmpty_Lista_Nova_Deve_Ser_Verdadeiro()
            => _listaEncadeada.IsEmpty().ShouldBeTrue();

        [Fact]
        public void IsEmpty_AposInsercao_DeveSerFalso()
        {
            _listaEncadeada.AdicionarNoInicio(99);

            _listaEncadeada.IsEmpty().ShouldBeFalse();
        }
    }
}