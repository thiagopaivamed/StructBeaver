using Shouldly;
using StructBeaver.Listas.ListaDuplamenteEncadeada;

namespace StructBeaver.Tests.Listas.ListasDuplamenteEncadeadas
{
    public class ListaDuplamenteEncadeadaTests
    {
        private readonly ListaDuplamenteEncadeada _listaDuplamenteEncadeada;

        public ListaDuplamenteEncadeadaTests()
            => _listaDuplamenteEncadeada = new();

        [Fact]
        public void Adicionar_No_Inicio_Deve_Retornar_Nos_Inseridos()
        {
            NoDuplamenteEncadeado no1 = _listaDuplamenteEncadeada.AdicionarNoInicio(10);
            NoDuplamenteEncadeado no2 = _listaDuplamenteEncadeada.AdicionarNoInicio(20);
            NoDuplamenteEncadeado no3 = _listaDuplamenteEncadeada.AdicionarNoInicio(30);

            no3.Valor.ShouldBe(30);
            no2.ShouldBe(no3.Proximo);
            no1.ShouldBe(no2.Proximo);
            no3.Anterior.ShouldBeNull();
            no3.ShouldBe(no2.Anterior);
            no2.ShouldBe(no1.Anterior);
        }

        [Fact]
        public void Adicionar_No_Final_Deve_Retornar_Nos_Inseridos()
        {
            NoDuplamenteEncadeado no1 = _listaDuplamenteEncadeada.AdicionarNoFinal(1);
            NoDuplamenteEncadeado no2 = _listaDuplamenteEncadeada.AdicionarNoFinal(2);
            NoDuplamenteEncadeado no3 = _listaDuplamenteEncadeada.AdicionarNoFinal(3);

            no1.Valor.ShouldBe(1);
            no2.Valor.ShouldBe(2);
            no3.Valor.ShouldBe(3);

            no1.Proximo.ShouldBe(no2);
            no2.Proximo.ShouldBe(no3);
            no3.Proximo.ShouldBeNull();

            no1.Anterior.ShouldBeNull();
            no2.Anterior.ShouldBe(no1);
            no3.Anterior.ShouldBe(no2);
        }

        [Fact]
        public void Remover_Do_Meio_Deve_Retornar_Nos_Removidos()
        {
            NoDuplamenteEncadeado no1 = _listaDuplamenteEncadeada.AdicionarNoFinal(5);
            NoDuplamenteEncadeado no2 = _listaDuplamenteEncadeada.AdicionarNoFinal(6);
            NoDuplamenteEncadeado no3 = _listaDuplamenteEncadeada.AdicionarNoFinal(7);

            NoDuplamenteEncadeado? removido = _listaDuplamenteEncadeada.Remover(6);

            removido.ShouldNotBeNull();
            removido.Valor.ShouldBe(6);
            no3.ShouldBe(no1.Proximo);
            no1.ShouldBe(no3.Anterior);
            removido.Proximo.ShouldBeNull();
            removido.Anterior.ShouldBeNull();
        }

        [Fact]
        public void Remover_Primeiro_Deve_Retornar_Nos_Removidos()
        {
            NoDuplamenteEncadeado no1 = _listaDuplamenteEncadeada.AdicionarNoFinal(1);
            NoDuplamenteEncadeado no2 = _listaDuplamenteEncadeada.AdicionarNoFinal(2);

            NoDuplamenteEncadeado? removido = _listaDuplamenteEncadeada.Remover(1);

            removido.ShouldNotBeNull();
            removido.Valor.ShouldBe(1);
            no2.Proximo.ShouldBeNull();
            removido.Proximo.ShouldBeNull();
            removido.Anterior.ShouldBeNull();
        }

        [Fact]
        public void Remover_Ultimo_Deve_Retornar_Nos_Removidos()
        {
            NoDuplamenteEncadeado no1 = _listaDuplamenteEncadeada.AdicionarNoFinal(1);
            NoDuplamenteEncadeado no2 = _listaDuplamenteEncadeada.AdicionarNoFinal(2);

            NoDuplamenteEncadeado? removido = _listaDuplamenteEncadeada.Remover(2);

            removido.ShouldNotBeNull();
            removido.Valor.ShouldBe(2);
            no1.Proximo.ShouldBeNull();
            removido.Proximo.ShouldBeNull();
            removido.Anterior.ShouldBeNull();
        }

        [Fact]
        public void Remover_Elemento_Inexistente_Deve_Retornar_Null()
        {
            _listaDuplamenteEncadeada.AdicionarNoFinal(10);
            _listaDuplamenteEncadeada.AdicionarNoFinal(20);

            NoDuplamenteEncadeado? removido = _listaDuplamenteEncadeada.Remover(999);

            removido.ShouldBeNull();
        }

        [Fact]
        public void Remover_Ultimo_Elemento_Deve_Esvaziar_Lista()
        {
            NoDuplamenteEncadeado no = _listaDuplamenteEncadeada.AdicionarNoFinal(77);

            NoDuplamenteEncadeado? removido = _listaDuplamenteEncadeada.Remover(77);

            removido.ShouldBe(no); 
            removido!.Valor.ShouldBe(77);
            removido.Proximo.ShouldBeNull();
            removido.Anterior.ShouldBeNull();

            _listaDuplamenteEncadeada.PrimeiroNo.ShouldBeNull();
            _listaDuplamenteEncadeada.UltimoNo.ShouldBeNull();
        }
    }
}