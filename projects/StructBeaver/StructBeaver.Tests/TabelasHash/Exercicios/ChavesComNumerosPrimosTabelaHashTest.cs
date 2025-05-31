using StructBeaver.TabelasHash.Exercicios;
using StructBeaver.TabelasHash;
using Shouldly;

namespace StructBeaver.Tests.TabelasHash.Exercicios
{
    public class ChavesComNumerosPrimosTabelaHashTest
    {
        private readonly ChavesComNumerosPrimosTabelaHash _chavesComPrimos;
        private readonly TabelaHash _tabelaHash;

        public ChavesComNumerosPrimosTabelaHashTest()
        {
            _chavesComPrimos = new();
            _tabelaHash = new(10);
        }

        [Fact]
        public void Deve_Retornar_Chaves_Com_Valores_Primos()
        {
            _tabelaHash.Inserir(1, 2);
            _tabelaHash.Inserir(2, 4);
            _tabelaHash.Inserir(3, 7);
            _tabelaHash.Inserir(4, 9);
            _tabelaHash.Inserir(5, 11);

            List<int> chavesPrimas = _chavesComPrimos.PegarChavesComNumerosPrimos(_tabelaHash);

            chavesPrimas.ShouldBe([1, 3, 5]);
        }

        [Fact]
        public void Deve_Retornar_Lista_Vazia_Se_Tabela_Estiver_Vazia()
        {
            List<int> chavesPrimas = _chavesComPrimos.PegarChavesComNumerosPrimos(_tabelaHash);

            chavesPrimas.ShouldBeEmpty();
        }

        [Fact]
        public void Deve_Retornar_Lista_Vazia_Se_Nao_Houver_Valores_Primos()
        {
            _tabelaHash.Inserir(1, 1);
            _tabelaHash.Inserir(2, 4);
            _tabelaHash.Inserir(3, 9);
            _tabelaHash.Inserir(4, 10);

            List<int> chavesPrimas = _chavesComPrimos.PegarChavesComNumerosPrimos(_tabelaHash);

            chavesPrimas.ShouldBeEmpty();
        }

        [Fact]
        public void Deve_Retornar_Todas_Chaves_Se_Todos_Valores_Forem_Primos()
        {
            _tabelaHash.Inserir(1, 2);
            _tabelaHash.Inserir(2, 3);
            _tabelaHash.Inserir(3, 5);
            _tabelaHash.Inserir(4, 7);

            List<int> chavesPrimas = _chavesComPrimos.PegarChavesComNumerosPrimos(_tabelaHash);

            chavesPrimas.ShouldBe([1, 2, 3, 4]);
        }

        [Fact]
        public void Deve_Retornar_Chaves_Duplicadas_Se_Mesmo_Valor_Primo_Estiver_Em_Multiplas_Chaves()
        {
            _tabelaHash.Inserir(10, 13);
            _tabelaHash.Inserir(20, 13);
            _tabelaHash.Inserir(30, 4);

            List<int> chavesPrimas = _chavesComPrimos.PegarChavesComNumerosPrimos(_tabelaHash);

            chavesPrimas.ShouldBe([10, 20]);
        }
    }
}