using Shouldly;
using StructBeaver.TabelasHash;

namespace StructBeaver.Tests.TabelasHash
{
    public class TabelaHashPadraoTest
    {
        private readonly TabelaHashPadrao _tabelaHashPadrao;

        public TabelaHashPadraoTest()
            => _tabelaHashPadrao = new();

        [Fact]
        public void Inserir_Deve_Adicionar_Chave_E_Valor_Se_Nao_Existir()
        {
            bool resultado = _tabelaHashPadrao.Inserir(1, 100);

            resultado.ShouldBeTrue();
            _tabelaHashPadrao.Pesquisar(1).ShouldBe(100);
        }

        [Fact]
        public void Inserir_Deve_Retornar_False_Se_Chave_Ja_Existir()
        {
            _tabelaHashPadrao.Inserir(2, 200);

            bool resultado = _tabelaHashPadrao.Inserir(2, 999);

            resultado.ShouldBeFalse();
            _tabelaHashPadrao.Pesquisar(2).ShouldBe(200);
        }

        [Fact]
        public void Pesquisar_Deve_Retornar_Null_Se_Chave_Nao_Existir()
        {
            int? resultado = _tabelaHashPadrao.Pesquisar(42);

            resultado.ShouldBeNull();
        }

        [Fact]
        public void Remover_Deve_Remover_Chave_Existente()
        {
            _tabelaHashPadrao.Inserir(5, 500);

            bool resultado = _tabelaHashPadrao.Remover(5);

            resultado.ShouldBeTrue();
            _tabelaHashPadrao.Pesquisar(5).ShouldBeNull();
        }

        [Fact]
        public void Remover_Deve_Retornar_False_Se_Chave_Nao_Existir()
        {
            bool resultado = _tabelaHashPadrao.Remover(99);

            resultado.ShouldBeFalse();
        }
    }
}