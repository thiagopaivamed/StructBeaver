using StructBeaver.Listas;

namespace StructBeaver.Tests.Listas
{
    public class ListaDuplamenteEncadeadaTests
    {
        private ListaDuplamenteEncadeada _listaDuplamenteEncadeada;

        public ListaDuplamenteEncadeadaTests()
            => _listaDuplamenteEncadeada = new ListaDuplamenteEncadeada();

        [Fact]
        public void Adicionar_No_Inicio_Deve_Retornar_Nos_Inseridos()
        {
            ListaDuplamenteEncadeada.No no1 = _listaDuplamenteEncadeada.AdicionarNoInicio(10);
            ListaDuplamenteEncadeada.No no2 = _listaDuplamenteEncadeada.AdicionarNoInicio(20);
            ListaDuplamenteEncadeada.No no3 = _listaDuplamenteEncadeada.AdicionarNoInicio(30);

            Assert.Equal(30, no3.Valor);
            Assert.Equal(no2, no3.Proximo);
            Assert.Equal(no1, no2.Proximo);
            Assert.Null(no3.Anterior);
            Assert.Equal(no3, no2.Anterior);
            Assert.Equal(no2, no1.Anterior);
        }

        [Fact]
        public void Adicionar_No_Final_Deve_Retornar_Nos_Inseridos()
        {
            ListaDuplamenteEncadeada.No no1 = _listaDuplamenteEncadeada.AdicionarNoFinal(1);
            ListaDuplamenteEncadeada.No no2 = _listaDuplamenteEncadeada.AdicionarNoFinal(2);
            ListaDuplamenteEncadeada.No no3 = _listaDuplamenteEncadeada.AdicionarNoFinal(3);

            Assert.Equal(1, no1.Valor);
            Assert.Equal(no2, no1.Proximo);
            Assert.Equal(no3, no2.Proximo);
            Assert.Null(no1.Anterior);
            Assert.Equal(no1, no2.Anterior);
            Assert.Equal(no2, no3.Anterior);
        }

        [Fact]
        public void Remover_Do_Meio_Deve_Retornar_Nos_Removidos()
        {
            ListaDuplamenteEncadeada.No no1 = _listaDuplamenteEncadeada.AdicionarNoFinal(5);
            ListaDuplamenteEncadeada.No no2 = _listaDuplamenteEncadeada.AdicionarNoFinal(6);
            ListaDuplamenteEncadeada.No no3 = _listaDuplamenteEncadeada.AdicionarNoFinal(7);

            ListaDuplamenteEncadeada.No? removido = _listaDuplamenteEncadeada.Remover(6);

            Assert.NotNull(removido);
            Assert.Equal(6, removido!.Valor);
            Assert.Equal(no3, no1.Proximo);
            Assert.Equal(no1, no3.Anterior);
            Assert.Null(removido.Proximo);
            Assert.Null(removido.Anterior);
        }

        [Fact]
        public void Remover_Primeiro_Deve_Retornar_Nos_Removidos()
        {
            ListaDuplamenteEncadeada.No no1 = _listaDuplamenteEncadeada.AdicionarNoFinal(1);
            ListaDuplamenteEncadeada.No no2 = _listaDuplamenteEncadeada.AdicionarNoFinal(2);

            ListaDuplamenteEncadeada.No? removido = _listaDuplamenteEncadeada.Remover(1);

            Assert.NotNull(removido);
            Assert.Equal(1, removido!.Valor);
            Assert.Null(no2.Anterior);
            Assert.Null(removido.Proximo);
            Assert.Null(removido.Anterior);
        }

        [Fact]
        public void Remover_Ultimo_Deve_Retornar_Nos_Removidos()
        {
            ListaDuplamenteEncadeada.No no1 = _listaDuplamenteEncadeada.AdicionarNoFinal(1);
            ListaDuplamenteEncadeada.No no2 = _listaDuplamenteEncadeada.AdicionarNoFinal(2);

            ListaDuplamenteEncadeada.No? removido = _listaDuplamenteEncadeada.Remover(2);

            Assert.NotNull(removido);
            Assert.Equal(2, removido!.Valor);
            Assert.Null(no1.Proximo);
            Assert.Null(removido.Proximo);
            Assert.Null(removido.Anterior);
        }

        [Fact]
        public void Remover_Elemento_Inexistente_Deve_Retornar_Null()
        {
            _listaDuplamenteEncadeada.AdicionarNoFinal(10);
            _listaDuplamenteEncadeada.AdicionarNoFinal(20);

            ListaDuplamenteEncadeada.No? removido = _listaDuplamenteEncadeada.Remover(999);

            Assert.Null(removido);
        }

        [Fact]
        public void Remover_Ultimo_Elemento_Deve_Esvaziar_Lista()
        {
            ListaDuplamenteEncadeada.No no = _listaDuplamenteEncadeada.AdicionarNoFinal(77);

            ListaDuplamenteEncadeada.No? removido = _listaDuplamenteEncadeada.Remover(77);

            Assert.NotNull(removido);
            Assert.Equal(77, removido!.Valor);
            Assert.Null(removido.Proximo);
            Assert.Null(removido.Anterior);
        }
    }
}
