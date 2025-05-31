using StructBeaver.TabelasHash.Exercicios;
using StructBeaver.TabelasHash;
using Shouldly;

namespace StructBeaver.Tests.TabelasHash.Exercicios
{
    public class QuantidadeChavesTabelaHashTest
    {
        private readonly QuantidadeChavesTabelaHash _quantidadeChavesTabelaHash;
        private readonly TabelaHash _tabelaHash;

        public QuantidadeChavesTabelaHashTest()
        {
            _quantidadeChavesTabelaHash = new();
            _tabelaHash = new(5);
        }

        [Fact]
        public void DeveRetornarZero_SeTabelaEstiverVazia()
        {
            int quantidade = _quantidadeChavesTabelaHash.Contar(_tabelaHash);

            quantidade.ShouldBe(0);
        }

        [Fact]
        public void DeveContarChavesUnicasCorretamente()
        {
            _tabelaHash.Inserir(1, 100);
            _tabelaHash.Inserir(2, 200);
            _tabelaHash.Inserir(3, 300);

            int quantidade = _quantidadeChavesTabelaHash.Contar(_tabelaHash);

            quantidade.ShouldBe(3);
        }

        [Fact]
        public void DeveIgnorarChavesDuplicadas()
        {
            _tabelaHash.Inserir(1, 100);
            _tabelaHash.Inserir(1, 200);

            int quantidade = _quantidadeChavesTabelaHash.Contar(_tabelaHash);

            quantidade.ShouldBe(1);
        }

        [Fact]
        public void DeveContarCorretamenteAposRemocoes()
        {
            _tabelaHash.Inserir(1, 100);
            _tabelaHash.Inserir(2, 200);
            _tabelaHash.Remover(1, 100);

            int quantidade = _quantidadeChavesTabelaHash.Contar(_tabelaHash);

            quantidade.ShouldBe(1);
        }
    }
}