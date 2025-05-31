using StructBeaver.TabelasHash.Exercicios;
using StructBeaver.TabelasHash;
using Shouldly;

namespace StructBeaver.Tests.TabelasHash.Exercicios
{
    public class EstaVaziaTabelaHashTest
    {
        private readonly EstaVaziaTabelaHash _estaVaziaTabelaHash;
        private readonly TabelaHash _tabelaHash;

        public EstaVaziaTabelaHashTest()
        {
            _estaVaziaTabelaHash = new();
            _tabelaHash = new(5);
        }

        [Fact]
        public void Deve_Retornar_True_Se_Tabela_Estiver_Vazia()
        {
            bool estaVazia = _estaVaziaTabelaHash.Verificar(_tabelaHash);

            estaVazia.ShouldBeTrue();
        }

        [Fact]
        public void Deve_Retornar_False_Se_Tabela_Possuir_Um_Elemento()
        {
            _tabelaHash.Inserir(1, 100);

            bool estaVazia = _estaVaziaTabelaHash.Verificar(_tabelaHash);

            estaVazia.ShouldBeFalse();
        }

        [Fact]
        public void Deve_Retornar_False_Se_Tabela_Contiver_Multiplos_Elementos()
        {
            _tabelaHash.Inserir(1, 10);
            _tabelaHash.Inserir(2, 20);
            _tabelaHash.Inserir(3, 30);

            bool estaVazia = _estaVaziaTabelaHash.Verificar(_tabelaHash);

            estaVazia.ShouldBeFalse();
        }

        [Fact]
        public void DeveRetornarTrue_AposRemoverTodosOsElementos()
        {
            _tabelaHash.Inserir(1, 10);
            _tabelaHash.Remover(1, 10);

            bool estaVazia = _estaVaziaTabelaHash.Verificar(_tabelaHash);

            estaVazia.ShouldBeTrue();
        }
    }
}