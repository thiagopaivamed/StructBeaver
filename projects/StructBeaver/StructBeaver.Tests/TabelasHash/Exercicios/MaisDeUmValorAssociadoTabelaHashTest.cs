using Shouldly;
using StructBeaver.TabelasHash;
using StructBeaver.TabelasHash.Exercicios;

namespace StructBeaver.Tests.TabelasHash.Exercicios
{
    public class ExistemChavesDuplicadasTests
    {
        private readonly ExistemChavesDuplicadasTabelaHash _chavesDuplicadas;
        private readonly TabelaHash _tabelaHash;

        public ExistemChavesDuplicadasTests()
        {
            _chavesDuplicadas = new ExistemChavesDuplicadasTabelaHash();
            _tabelaHash = new TabelaHash(10);
        }

        [Fact]
        public void Deve_Retornar_False_Quando_Nao_Ha_Chaves_Duplicadas()
        {            
            _tabelaHash.Inserir(1, 100);
            _tabelaHash.Inserir(2, 200);
            _tabelaHash.Inserir(3, 300);

            bool existemChavesDuplicadas = _chavesDuplicadas.Verificar(_tabelaHash);
            existemChavesDuplicadas.ShouldBeFalse();
        }

        [Fact]
        public void Deve_Retornar_True_Quando_Ha_Chaves_Duplicadas()
        {
            _tabelaHash.Inserir(1, 100);
            _tabelaHash.Inserir(2, 200);

            int indiceDuplicado = -1;
            for (int i = 0; i < _tabelaHash.Tabela.Length; i++)
            {
                foreach ((int chave, int valor) in _tabelaHash.Tabela[i])
                {
                    if (chave == 1)
                        indiceDuplicado = i;
                    
                }
            }

            _tabelaHash.Tabela[indiceDuplicado].AddLast((1, 999));

            bool existemChavesDuplicadas = _chavesDuplicadas.Verificar(_tabelaHash);
            existemChavesDuplicadas.ShouldBeTrue();
        }

        [Fact]
        public void Deve_Retornar_False_Quando_Tabela_Esta_Vazia()
        {
            bool existemChavesDuplicadas = _chavesDuplicadas.Verificar(_tabelaHash);
            existemChavesDuplicadas.ShouldBeFalse();
        }
    }
}