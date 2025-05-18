using Shouldly;
using StructBeaver.Listas.ListaCircular;

namespace StructBeaver.Tests.Listas.ListaCircular
{
    public class ListaCircularDuplamenteEncadeadaTest
    {
        private readonly ListaCircularDuplamenteEncadeada _listaCircularDuplamenteEncadeada;

        public ListaCircularDuplamenteEncadeadaTest()
            => _listaCircularDuplamenteEncadeada = new();


        [Fact]
        public void Adicionar_No_Inicio_Deve_Inserir_E_Retornar_No()
        {
            NoCircular noAdicionado = _listaCircularDuplamenteEncadeada.AdicionarNoInicio(10);

            noAdicionado.ShouldNotBeNull();
            noAdicionado.Valor.ShouldBe(10);
            noAdicionado.Proximo.ShouldBe(noAdicionado);
            noAdicionado.Anterior.ShouldBe(noAdicionado);
            _listaCircularDuplamenteEncadeada.PrimeiroNo.ShouldBe(noAdicionado);
        }

        [Fact]
        public void Adicionar_No_Fim_Deve_Inserir_Nos_Na_Ordem_Certa_E_Retornar()
        {
            NoCircular noAdicionado1 = _listaCircularDuplamenteEncadeada.AdicionarNoFim(10);
            NoCircular noAdicionado2 = _listaCircularDuplamenteEncadeada.AdicionarNoFim(20);

            noAdicionado1.ShouldNotBeNull();
            noAdicionado2.ShouldNotBeNull();
            noAdicionado1.Valor.ShouldBe(10);
            noAdicionado2.Valor.ShouldBe(20);
            noAdicionado1.Proximo.ShouldBe(noAdicionado2);
            noAdicionado2.Proximo.ShouldBe(noAdicionado1);
            _listaCircularDuplamenteEncadeada.PrimeiroNo!.Anterior.ShouldBe(noAdicionado2);
        }

        [Fact]
        public void Remover_No_Deve_Retornar_No_Removido()
        {
            _listaCircularDuplamenteEncadeada.AdicionarNoInicio(5);

            NoCircular? noRemovido = _listaCircularDuplamenteEncadeada.Remover(5);

            noRemovido.ShouldNotBeNull();
            noRemovido.Valor.ShouldBe(5);
            _listaCircularDuplamenteEncadeada.PrimeiroNo.ShouldBeNull();
        }

        [Fact]
        public void Remover_No_Do_Meio_Deve_Retornar_No_Removido()
        {
            _listaCircularDuplamenteEncadeada.AdicionarNoFim(1);
            _listaCircularDuplamenteEncadeada.AdicionarNoFim(2);
            _listaCircularDuplamenteEncadeada.AdicionarNoFim(3);

            NoCircular? noRemovido = _listaCircularDuplamenteEncadeada.Remover(2);

            noRemovido.ShouldNotBeNull();
            noRemovido.Valor.ShouldBe(2);

            NoCircular? primeiro = _listaCircularDuplamenteEncadeada.PrimeiroNo;
            NoCircular? segundo = primeiro!.Proximo;

            primeiro.Valor.ShouldBe(1);
            segundo!.Valor.ShouldBe(3);
            primeiro.Proximo.ShouldBe(segundo);
            segundo.Anterior.ShouldBe(primeiro);
        }

        [Fact]
        public void Remover_Elemento_Inexistente_Deve_Retornar_Null()
        {
            _listaCircularDuplamenteEncadeada.AdicionarNoFim(1);
            _listaCircularDuplamenteEncadeada.AdicionarNoFim(2);

            NoCircular? noRemovido = _listaCircularDuplamenteEncadeada.Remover(99);

            noRemovido.ShouldBeNull();

            NoCircular? primeiro = _listaCircularDuplamenteEncadeada.PrimeiroNo;
            NoCircular? segundo = primeiro!.Proximo;

            primeiro.Valor.ShouldBe(1);
            segundo!.Valor.ShouldBe(2);
            primeiro.Proximo.ShouldBe(segundo);
            segundo.Anterior.ShouldBe(primeiro);
        }
    }
}