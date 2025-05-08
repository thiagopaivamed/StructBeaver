using StructBeaver.Listas.ListaDuplamenteEncadeada;
using StructBeaver.Listas.ListaDuplamenteEncadeada.Exercicios;

namespace StructBeaver.Tests.Listas.ListasDuplamenteEncadeadas.Exercicios
{
    public class RemocaoRecursivaListaDuplamenteEncadeadaTest
    {
        private RemocaoRecursivaListaDuplamenteEncadeada _remocaoRecursivaListaDuplamenteEncadeada;
        private ListaDuplamenteEncadeada listaDuplamenteEncadeada;

        public RemocaoRecursivaListaDuplamenteEncadeadaTest()
        {
            _remocaoRecursivaListaDuplamenteEncadeada = new RemocaoRecursivaListaDuplamenteEncadeada();

            listaDuplamenteEncadeada = new ListaDuplamenteEncadeada();
            listaDuplamenteEncadeada.AdicionarNoInicio(1);
            listaDuplamenteEncadeada.AdicionarNoInicio(2);
            listaDuplamenteEncadeada.AdicionarNoInicio(3);
        }

        [Fact]
        public void Remover_Valor_Presente_Na_Lista_Deve_Retornar_No_Removido()
        {  
            NoDuplamenteEncadeado noRemovido = _remocaoRecursivaListaDuplamenteEncadeada.Remover(listaDuplamenteEncadeada, 2);

            Assert.NotNull(noRemovido);
            Assert.Equal(2, noRemovido.Valor);
        }

        [Fact]
        public void Remover_Valor_Ausente_Na_Lista_Deve_Retornar_Null()
        {
            NoDuplamenteEncadeado noRemovido = _remocaoRecursivaListaDuplamenteEncadeada.Remover(listaDuplamenteEncadeada, 27);

            Assert.Null(noRemovido);
        }
    }
}