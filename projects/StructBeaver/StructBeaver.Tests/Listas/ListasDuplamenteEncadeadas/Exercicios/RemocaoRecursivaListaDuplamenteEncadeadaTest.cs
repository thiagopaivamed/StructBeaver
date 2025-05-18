using Shouldly;
using StructBeaver.Listas.ListaDuplamenteEncadeada;
using StructBeaver.Listas.ListaDuplamenteEncadeada.Exercicios;

namespace StructBeaver.Tests.Listas.ListasDuplamenteEncadeadas.Exercicios
{
    public class RemocaoRecursivaListaDuplamenteEncadeadaTest
    {
        private readonly RemocaoRecursivaListaDuplamenteEncadeada _remocaoRecursivaListaDuplamenteEncadeada;
        private readonly ListaDuplamenteEncadeada listaDuplamenteEncadeada;

        public RemocaoRecursivaListaDuplamenteEncadeadaTest()
        {
            _remocaoRecursivaListaDuplamenteEncadeada = new();

            listaDuplamenteEncadeada = new();
            listaDuplamenteEncadeada.AdicionarNoInicio(1);
            listaDuplamenteEncadeada.AdicionarNoInicio(2);
            listaDuplamenteEncadeada.AdicionarNoInicio(3);
        }

        [Fact]
        public void Remover_Valor_Presente_Na_Lista_Deve_Retornar_No_Removido()
        {
            NoDuplamenteEncadeado? noRemovido = _remocaoRecursivaListaDuplamenteEncadeada.Remover(listaDuplamenteEncadeada, 2);

            noRemovido.ShouldNotBeNull();
            noRemovido.Valor.ShouldBe(2);
        }

        [Fact]
        public void Remover_Valor_Ausente_Na_Lista_Deve_Retornar_Null()
        {
            NoDuplamenteEncadeado? noRemovido = _remocaoRecursivaListaDuplamenteEncadeada.Remover(listaDuplamenteEncadeada, 27);

            noRemovido.ShouldBeNull();
        }
    }
}