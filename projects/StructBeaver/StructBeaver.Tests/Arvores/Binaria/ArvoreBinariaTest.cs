using StructBeaver.Arvores;
using StructBeaver.Arvores.ArvoreBinaria;

namespace StructBeaver.Tests.Arvores.Binaria
{
    public class ArvoreBinariaTest
    {
        private ArvoreBinaria _arvoreBinaria;

        public ArvoreBinariaTest()
            => _arvoreBinaria = new ArvoreBinaria(null);

        [Fact]
        public void Inserir_Deve_Definir_Raiz_Se_Arvore_Estiver_Vazia()
        {
            NoArvore raizAntesDaInsercao = _arvoreBinaria.Raiz;

            Assert.Null(raizAntesDaInsercao);
            Assert.Null(raizAntesDaInsercao?.NoEsquerdo);
            Assert.Null(raizAntesDaInsercao?.NoDireito);

             _arvoreBinaria.Inserir(10);

            NoArvore raizDepoisDaInsercao = _arvoreBinaria.Raiz;

            Assert.NotNull(raizDepoisDaInsercao);
            Assert.Equal(raizDepoisDaInsercao.Valor, 10);
            Assert.Null(raizDepoisDaInsercao.NoEsquerdo);
            Assert.Null(raizDepoisDaInsercao.NoDireito);
        }

        [Fact]
        public void Inserir_Deve_Retornar_Nos_Esquerdo_E_Direito()
        {
            NoArvore raizAntesDaInsercao = _arvoreBinaria.Raiz;

            Assert.Null(raizAntesDaInsercao);
            Assert.Null(raizAntesDaInsercao?.NoEsquerdo);
            Assert.Null(raizAntesDaInsercao?.NoDireito);

            _arvoreBinaria.Inserir(10);
            NoArvore raizDepoisDaInsercao = _arvoreBinaria.Raiz;

            Assert.NotNull(raizDepoisDaInsercao);
            Assert.Null(raizDepoisDaInsercao.NoEsquerdo);
            Assert.Null(raizDepoisDaInsercao.NoDireito);

            _arvoreBinaria.Inserir(5);
            Assert.NotNull(raizDepoisDaInsercao.NoEsquerdo);
            Assert.Equal(raizDepoisDaInsercao.NoEsquerdo.Valor, 5);
            Assert.Null(raizDepoisDaInsercao.NoDireito);

            _arvoreBinaria.Inserir(15);
            Assert.NotNull(raizDepoisDaInsercao.NoEsquerdo);
            Assert.NotNull(raizDepoisDaInsercao.NoDireito);
            Assert.Equal(raizDepoisDaInsercao.NoDireito.Valor, 15);
        }

        [Fact]
        public void Pesquisar_Deve_Retornar_No_Quando_Ele_For_Encontrado()
        {
            _arvoreBinaria.Inserir(10);
            _arvoreBinaria.Inserir(5);
            _arvoreBinaria.Inserir(15);

            NoArvore noEncontrado = _arvoreBinaria.Pesquisar(5);
            Assert.NotNull(noEncontrado);
            Assert.Equal(noEncontrado.Valor, 5);
        }

        [Fact]
        public void Pesquisar_Deve_Retornar_Null_Quando_No_Nao_For_Encontrado()
        {
            _arvoreBinaria.Inserir(10);
            _arvoreBinaria.Inserir(5);
            _arvoreBinaria.Inserir(15);

            NoArvore noEncontrado = _arvoreBinaria.Pesquisar(30);
            Assert.Null(noEncontrado);
        }        
    }
}