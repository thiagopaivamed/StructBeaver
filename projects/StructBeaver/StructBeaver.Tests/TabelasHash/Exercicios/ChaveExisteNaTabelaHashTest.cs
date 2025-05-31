using StructBeaver.TabelasHash.Exercicios;
using StructBeaver.TabelasHash;
using Shouldly;

namespace StructBeaver.Tests.TabelasHash.Exercicios
{
    public class ChaveExisteNaTabelaHashTest
    {
        private readonly ChaveExisteNaTabelaHash _chaveExisteNaTabelaHash;
        private readonly TabelaHash _tabelaHash;

        public ChaveExisteNaTabelaHashTest()
        {
            _chaveExisteNaTabelaHash = new();
            _tabelaHash = new(5);
        }

        [Fact]
        public void Deve_Retornar_True_Se_Chave_Estiver_Presente()
        {
            _tabelaHash.Inserir(10, 100);
            _tabelaHash.Inserir(20, 200);

            bool chaveExiste = _chaveExisteNaTabelaHash.Pesquisar(_tabelaHash, 10);

            chaveExiste.ShouldBeTrue();
        }

        [Fact]
        public void Deve_Retornar_False_Se_Chave_Nao_Estiver_Presente()
        {
            _tabelaHash.Inserir(1, 50);
            _tabelaHash.Inserir(2, 60);

            bool chaveExiste = _chaveExisteNaTabelaHash.Pesquisar(_tabelaHash, 3);

            chaveExiste.ShouldBeFalse();
        }

        [Fact]
        public void Deve_Lidar_Corretamente_Com_Tabela_Vazia()
        {
            bool chaveExiste = _chaveExisteNaTabelaHash.Pesquisar(_tabelaHash, 1);

            chaveExiste.ShouldBeFalse();
        }

        [Fact]
        public void Deve_Retornar_True_Se_Chave_For_Inserida_Com_Colisao()
        {
            _tabelaHash.Inserir(1, 100);
            _tabelaHash.Inserir(4, 200);

            bool chaveExiste = _chaveExisteNaTabelaHash.Pesquisar(_tabelaHash, 4);

            chaveExiste.ShouldBeTrue();
        }

        [Fact]
        public void Deve_Distinguir_Chaves_Com_Mesmo_Valor()
        {
            _tabelaHash.Inserir(7, 300);
            _tabelaHash.Inserir(8, 300);

            _chaveExisteNaTabelaHash.Pesquisar(_tabelaHash, 7).ShouldBeTrue();
            _chaveExisteNaTabelaHash.Pesquisar(_tabelaHash, 8).ShouldBeTrue();
            _chaveExisteNaTabelaHash.Pesquisar(_tabelaHash, 9).ShouldBeFalse();
        }
    }
}
