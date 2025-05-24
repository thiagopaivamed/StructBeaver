using Shouldly;
using StructBeaver.TabelasHash;

namespace StructBeaver.Tests.TabelasHash
{
    public class TabelaHashTest
    {
        private readonly TabelaHash tabelaHash;

        public TabelaHashTest()
            => tabelaHash = new TabelaHash(10);

        [Fact]
        public void Inserir_Deve_Retornar_Indice_Correto_Quando_Inserir_Chave_Nova()
        {
            int indice = tabelaHash.Inserir(15, 100);

            indice.ShouldBeInRange(0, 9);
        }

        [Fact]
        public void Inserir_Deve_Retornar_Menos_Um_Quando_Chave_Ja_Existe()
        {
            tabelaHash.Inserir(5, 50);
            int resultado = tabelaHash.Inserir(5, 70);

            resultado.ShouldBe(-1);
        }

        [Fact]
        public void Buscar_Deve_Retornar_Indice_Correto_Quando_Chave_Existe()
        {
            tabelaHash.Inserir(7, 70);

            int indice = tabelaHash.Buscar(7);

            indice.ShouldBeInRange(0, 9);
        }

        [Fact]
        public void Buscar_Deve_Retornar_Menos_Um_Quando_Chave_Nao_Existe()
        {
            int indice = tabelaHash.Buscar(999);

            indice.ShouldBe(-1);
        }

        [Fact]
        public void Remover_Deve_Retornar_True_Quando_Chave_Existe()
        {
            tabelaHash.Inserir(3, 30);

            bool removido = tabelaHash.Remover(3);

            removido.ShouldBeTrue();
        }

        [Fact]
        public void Remover_Deve_Retornar_False_Quando_Chave_Nao_Existe()
        {
            bool removido = tabelaHash.Remover(100);

            removido.ShouldBeFalse();
        }
    }
}