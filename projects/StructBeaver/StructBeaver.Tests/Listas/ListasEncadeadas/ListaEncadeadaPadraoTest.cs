using Shouldly;
using StructBeaver.Listas.ListaEncadeada;

namespace StructBeaver.Tests.Listas.ListasEncadeadas
{
    public class ListaEncadeadaPadraoTest
    {
        private readonly ListaEncadeadaPadrao _listaEncadeadaPadrao;

        public ListaEncadeadaPadraoTest()
           => _listaEncadeadaPadrao = new();

        [Fact]
        public void Deve_Adicionar_Elemento_Na_Lista()
        {
            _listaEncadeadaPadrao.Adicionar(10);
            _listaEncadeadaPadrao.Adicionar(20);
            _listaEncadeadaPadrao.Adicionar(30);

            bool removido = _listaEncadeadaPadrao.Remover(20);

            removido.ShouldBeTrue();
        }

        [Fact]
        public void Deve_Remover_Elemento_Existente()
        {
            _listaEncadeadaPadrao.Adicionar(1);
            _listaEncadeadaPadrao.Adicionar(2);
            _listaEncadeadaPadrao.Adicionar(3);

            bool removido = _listaEncadeadaPadrao.Remover(2);

            removido.ShouldBeTrue();
        }

        [Fact]
        public void Nao_Deve_Remover_Elemento_Inexistente()
        {
            _listaEncadeadaPadrao.Adicionar(100);

            bool removido = _listaEncadeadaPadrao.Remover(200);

            removido.ShouldBeFalse();
        }
    }
}