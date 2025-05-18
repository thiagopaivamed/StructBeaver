using Shouldly;
using StructBeaver.Listas.ListaDuplamenteEncadeada;

namespace StructBeaver.Tests.Listas.ListasDuplamenteEncadeadas
{
    public class ListaDuplamenteEncadeadaPadraoTest
    {
        private readonly ListaDuplamenteEncadeadaPadrao _listaDuplamenteEncadeadaPadrao;

        public ListaDuplamenteEncadeadaPadraoTest()
            => _listaDuplamenteEncadeadaPadrao = new();

        [Fact]
        public void Adicionar_No_Inicio_Deve_Atualizar_Primeiro_No()
        {
            LinkedListNode<int> no = _listaDuplamenteEncadeadaPadrao.AdicionarNoInicio(10);

            _listaDuplamenteEncadeadaPadrao.PrimeiroNo.ShouldNotBeNull();
            _listaDuplamenteEncadeadaPadrao.PrimeiroNo.Value.ShouldBe(10);
            _listaDuplamenteEncadeadaPadrao.PrimeiroNo.ShouldBe(no);
        }

        [Fact]
        public void Adicionar_No_Final_Deve_Atualizar_Ultimo_No()
        {
            LinkedListNode<int> no = _listaDuplamenteEncadeadaPadrao.AdicionarNoFinal(20);

            _listaDuplamenteEncadeadaPadrao.UltimoNo.ShouldNotBeNull();
            _listaDuplamenteEncadeadaPadrao.UltimoNo.Value.ShouldBe(20);
            _listaDuplamenteEncadeadaPadrao.UltimoNo.ShouldBe(no);
        }

        [Fact]
        public void Adicionar_Multiplos_Elementos_Deve_Manter_Ordem()
        {
            _listaDuplamenteEncadeadaPadrao.AdicionarNoFinal(1);
            _listaDuplamenteEncadeadaPadrao.AdicionarNoFinal(2);
            _listaDuplamenteEncadeadaPadrao.AdicionarNoFinal(3);

            _listaDuplamenteEncadeadaPadrao.PrimeiroNo?.Value.ShouldBe(1);
            _listaDuplamenteEncadeadaPadrao.UltimoNo?.Value.ShouldBe(3);
        }

        [Fact]
        public void Remover_Elemento_Existente_Deve_Remover_E_Nao_Estar_Mais_Na_Lista()
        {
            _listaDuplamenteEncadeadaPadrao.AdicionarNoFinal(5);
            _listaDuplamenteEncadeadaPadrao.AdicionarNoFinal(10);
            _listaDuplamenteEncadeadaPadrao.AdicionarNoFinal(15);

            LinkedListNode<int>? removido = _listaDuplamenteEncadeadaPadrao.Remover(10);

            removido.ShouldNotBeNull();
            removido?.Value.ShouldBe(10);

            LinkedListNode<int>? primeiro = _listaDuplamenteEncadeadaPadrao.PrimeiroNo;

            primeiro?.Value.ShouldBe(5);
            primeiro?.Next?.Value.ShouldBe(15);
            primeiro?.Next?.Next.ShouldBeNull();
        }

        [Fact]
        public void Remover_Elemento_Inexistente_Deve_Retornar_Null()
        {
            _listaDuplamenteEncadeadaPadrao.AdicionarNoFinal(100);

            LinkedListNode<int>? removido = _listaDuplamenteEncadeadaPadrao.Remover(999);

            removido.ShouldBeNull();
        }

        [Fact]
        public void Remover_No_Inicio_Deve_Atualizar_Primeiro_No()
        {
            _listaDuplamenteEncadeadaPadrao.AdicionarNoFinal(1);
            _listaDuplamenteEncadeadaPadrao.AdicionarNoFinal(2);

            _listaDuplamenteEncadeadaPadrao.RemoverNoInicio();

            _listaDuplamenteEncadeadaPadrao.PrimeiroNo?.Value.ShouldBe(2);
        }

        [Fact]
        public void Remover_No_Final_Deve_Atualizar_Ultimo_No()
        {
            _listaDuplamenteEncadeadaPadrao.AdicionarNoFinal(1);
            _listaDuplamenteEncadeadaPadrao.AdicionarNoFinal(2);

            _listaDuplamenteEncadeadaPadrao.RemoverNoFinal();

            _listaDuplamenteEncadeadaPadrao.UltimoNo?.Value.ShouldBe(1);
        }

        [Fact]
        public void Lista_Vazia_Apos_Remover_Todos_Deve_Ter_Primeiro_E_Ultimo_Nulos()
        {
            _listaDuplamenteEncadeadaPadrao.AdicionarNoFinal(1);
            _listaDuplamenteEncadeadaPadrao.RemoverNoFinal();

            _listaDuplamenteEncadeadaPadrao.PrimeiroNo.ShouldBeNull();
            _listaDuplamenteEncadeadaPadrao.UltimoNo.ShouldBeNull();
        }
    }
}