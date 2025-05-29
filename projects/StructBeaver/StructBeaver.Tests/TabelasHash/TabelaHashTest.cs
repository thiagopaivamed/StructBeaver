using Shouldly;
using StructBeaver.TabelasHash;

namespace StructBeaver.Tests.TabelasHash
{
    public class TabelaHashTests
    {
        private readonly TabelaHash _tabelaHash;

        public TabelaHashTests()
            => _tabelaHash = new TabelaHash(10);

        [Fact]
        public void Inserir_Deve_Retornar_Indice_Correto_Quando_Inserir_Chave_Nova()
        {
            int indice = _tabelaHash.Inserir(15, 100);

            indice.ShouldBe(5);
        }

        [Fact]
        public void Inserir_Deve_Retornar_Menos_Um_Quando_Chave_Ja_Existe()
        {
            int primeiraInsercao = _tabelaHash.Inserir(15, 100);
            int segundaInsercao = _tabelaHash.Inserir(15, 200);

            primeiraInsercao.ShouldBe(5);
            segundaInsercao.ShouldBe(-1);
        }

        [Fact]
        public void Pesquisar_Deve_Retornar_Lista_De_Valores_Quando_Chave_Existe()
        {
            _tabelaHash.Inserir(1, 100);
            _tabelaHash.Inserir(11, 200); 

            List<int> valores = _tabelaHash.Pesquisar(1);

            valores.ShouldContain(100);
            valores.ShouldNotContain(200);
        }

        [Fact]
        public void Pesquisar_Deve_Retornar_Lista_Vazia_Quando_Chave_Nao_Existe()
        {
            List<int> valores = _tabelaHash.Pesquisar(99);

            valores.ShouldBeEmpty();
        }

        [Fact]
        public void Remover_Deve_Retornar_True_Quando_Chave_E_Valor_Existem()
        {
            _tabelaHash.Inserir(2, 300);

            bool removido = _tabelaHash.Remover(2, 300);
            List<int> valores = _tabelaHash.Pesquisar(2);

            removido.ShouldBeTrue();
            valores.ShouldBeEmpty();
        }

        [Fact]
        public void Remover_Deve_Retornar_False_Quando_Valor_Nao_Existe()
        {
            _tabelaHash.Inserir(2, 300);

            bool removido = _tabelaHash.Remover(2, 999);
            List<int> valores = _tabelaHash.Pesquisar(2);

            removido.ShouldBeFalse();
            valores.ShouldContain(300);
        }
    }
}