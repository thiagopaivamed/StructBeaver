using StructBeaver.Listas.ListaDuplamenteEncadeada;

namespace StructBeaver.Tests.Listas.ListasDuplamenteEncadeadas
{
    public class ListaDuplamenteEncadeadaPadraoTest
    {
        private ListaDuplamenteEncadeadaPadrao _listaDuplamenteEncadeadaCSharp;

        public ListaDuplamenteEncadeadaPadraoTest()
            => _listaDuplamenteEncadeadaCSharp = new ListaDuplamenteEncadeadaPadrao();

        [Fact]
        public void Adicionar_No_Inicio_Deve_Atualizar_Primeiro_No()
        {
            LinkedListNode<int> no = _listaDuplamenteEncadeadaCSharp.AdicionarNoInicio(10);

            Assert.NotNull(_listaDuplamenteEncadeadaCSharp.PrimeiroNo);
            Assert.Equal(10, _listaDuplamenteEncadeadaCSharp.PrimeiroNo.Value);
            Assert.Equal(no, _listaDuplamenteEncadeadaCSharp.PrimeiroNo);
        }

        [Fact]
        public void Adicionar_No_Final_Deve_Atualizar_Ultimo_No()
        {
            LinkedListNode<int> no = _listaDuplamenteEncadeadaCSharp.AdicionarNoFinal(20);

            Assert.NotNull(_listaDuplamenteEncadeadaCSharp.UltimoNo);
            Assert.Equal(20, _listaDuplamenteEncadeadaCSharp.UltimoNo.Value);
            Assert.Equal(no, _listaDuplamenteEncadeadaCSharp.UltimoNo);
        }

        [Fact]
        public void Adicionar_Multiplos_Elementos_Deve_Manter_Ordem()
        {
            _listaDuplamenteEncadeadaCSharp.AdicionarNoFinal(1);
            _listaDuplamenteEncadeadaCSharp.AdicionarNoFinal(2);
            _listaDuplamenteEncadeadaCSharp.AdicionarNoFinal(3);

            Assert.Equal(1, _listaDuplamenteEncadeadaCSharp.PrimeiroNo?.Value);
            Assert.Equal(3, _listaDuplamenteEncadeadaCSharp.UltimoNo?.Value);
        }

        [Fact]
        public void Remover_Elemento_Existente_Deve_Remover_E_Nao_Estar_Mais_Na_Lista()
        {
            _listaDuplamenteEncadeadaCSharp.AdicionarNoFinal(5);
            _listaDuplamenteEncadeadaCSharp.AdicionarNoFinal(10);
            _listaDuplamenteEncadeadaCSharp.AdicionarNoFinal(15);

            LinkedListNode<int>? removido = _listaDuplamenteEncadeadaCSharp.Remover(10);

            Assert.NotNull(removido);
            Assert.Equal(10, removido.Value);

            LinkedListNode<int>? primeiro = _listaDuplamenteEncadeadaCSharp.PrimeiroNo;
            Assert.Equal(5, primeiro?.Value);
            Assert.Equal(15, primeiro?.Next?.Value);
            Assert.Null(primeiro?.Next?.Next);
        }

        [Fact]
        public void Remover_Elemento_Inexistente_Deve_Retornar_Null()
        {
            _listaDuplamenteEncadeadaCSharp.AdicionarNoFinal(100);

            LinkedListNode<int>? removido = _listaDuplamenteEncadeadaCSharp.Remover(999);

            Assert.Null(removido);
        }

        [Fact]
        public void Remover_No_Inicio_Deve_Atualizar_Primeiro_No()
        {
            _listaDuplamenteEncadeadaCSharp.AdicionarNoFinal(1);
            _listaDuplamenteEncadeadaCSharp.AdicionarNoFinal(2);

            _listaDuplamenteEncadeadaCSharp.RemoverNoInicio();

            Assert.Equal(2, _listaDuplamenteEncadeadaCSharp.PrimeiroNo?.Value);
        }

        [Fact]
        public void Remover_No_Final_Deve_Atualizar_Ultimo_No()
        {
            _listaDuplamenteEncadeadaCSharp.AdicionarNoFinal(1);
            _listaDuplamenteEncadeadaCSharp.AdicionarNoFinal(2);

            _listaDuplamenteEncadeadaCSharp.RemoverNoFinal();

            Assert.Equal(1, _listaDuplamenteEncadeadaCSharp.UltimoNo?.Value);
        }

        [Fact]
        public void Lista_Vazia_Apos_Remover_Todos_Deve_Ter_Primeiro_E_Ultimo_Nulos()
        {
            _listaDuplamenteEncadeadaCSharp.AdicionarNoFinal(1);
            _listaDuplamenteEncadeadaCSharp.RemoverNoFinal();

            Assert.Null(_listaDuplamenteEncadeadaCSharp.PrimeiroNo);
            Assert.Null(_listaDuplamenteEncadeadaCSharp.UltimoNo);
        }
    }
}