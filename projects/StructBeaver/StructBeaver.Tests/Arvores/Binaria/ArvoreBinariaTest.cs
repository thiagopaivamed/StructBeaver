using Shouldly;
using StructBeaver.Arvores;
using StructBeaver.Arvores.ArvoreBinaria;

namespace StructBeaver.Tests.Arvores.Binaria
{
    public class ArvoreBinariaTest
    {
        private ArvoreBinaria _arvoreBinaria;

        public ArvoreBinariaTest()
            => _arvoreBinaria = new(null!);

        [Fact]
        public void Inserir_Deve_Definir_Raiz_Se_Arvore_Estiver_Vazia()
        {
            NoArvore raizAntesDaInsercao = _arvoreBinaria.Raiz;

            raizAntesDaInsercao.ShouldBeNull();
            raizAntesDaInsercao?.NoEsquerdo.ShouldBeNull();
            raizAntesDaInsercao?.NoDireito.ShouldBeNull();

             _arvoreBinaria.Inserir(10);

            NoArvore raizDepoisDaInsercao = _arvoreBinaria.Raiz;

            raizDepoisDaInsercao.ShouldNotBeNull();
            raizDepoisDaInsercao.Valor.ShouldBe(10);
            raizDepoisDaInsercao.NoEsquerdo.ShouldBeNull();
            raizDepoisDaInsercao.NoDireito.ShouldBeNull();
        }

        [Fact]
        public void Inserir_Deve_Retornar_Nos_Esquerdo_E_Direito()
        {
            NoArvore raizAntesDaInsercao = _arvoreBinaria.Raiz;

            raizAntesDaInsercao.ShouldBeNull();
            raizAntesDaInsercao?.NoEsquerdo.ShouldBeNull();
            raizAntesDaInsercao?.NoDireito.ShouldBeNull();

            _arvoreBinaria.Inserir(10);
            NoArvore raizDepoisDaInsercao = _arvoreBinaria.Raiz;

            raizDepoisDaInsercao.ShouldNotBeNull();
            raizDepoisDaInsercao.NoEsquerdo.ShouldBeNull();
            raizDepoisDaInsercao.NoDireito.ShouldBeNull();

            _arvoreBinaria.Inserir(5);
            raizDepoisDaInsercao.NoEsquerdo.ShouldNotBeNull();
            raizDepoisDaInsercao.NoEsquerdo.Valor.ShouldBe(5);
            raizDepoisDaInsercao.NoDireito.ShouldBeNull();

            _arvoreBinaria.Inserir(15);
            raizDepoisDaInsercao.NoEsquerdo.ShouldNotBeNull();
            raizDepoisDaInsercao.NoDireito.ShouldNotBeNull();
            raizDepoisDaInsercao.NoDireito.Valor.ShouldBe(15);
        }

        [Fact]
        public void PesquisarComBfs_Deve_Retornar_No_QuandoValor_Esta_Na_Raiz()
        {
            InicializarArvore();

            NoArvore? noProcurado = _arvoreBinaria.PesquisarComBfs(1);

            noProcurado.ShouldNotBeNull();
            noProcurado.Valor.ShouldBe(1);
        }

        [Fact]
        public void PesquisarComBfs_Deve_Retornar_No_Quando_Valor_Esta_No_Meio()
        {
            InicializarArvore();

            NoArvore? noProcurado = _arvoreBinaria.PesquisarComBfs(3);

            noProcurado.ShouldNotBeNull();
            noProcurado.Valor.ShouldBe(3);
        }

        [Fact]
        public void PesquisarComBfs_Deve_Retornar_No_Quando_Valor_Esta_Na_Folha()
        {
            InicializarArvore();

            NoArvore? noProcurado = _arvoreBinaria.PesquisarComBfs(5);

            noProcurado.ShouldNotBeNull();
            noProcurado.Valor.ShouldBe(5);
        }

        [Fact]
        public void PesquisarComBfs_DeveRetornar_Null_Quando_Valor_Nao_Existe()
        {
            InicializarArvore();

            NoArvore? noProcurado = _arvoreBinaria.PesquisarComBfs(999);

            noProcurado.ShouldBeNull();
        }

        [Fact]
        public void PesquisarComDfsPreOrdem_Deve_Retornar_No_Quando_Valor_Esta_Na_Raiz()
        {
            InicializarArvore();

            NoArvore? noProcurado = _arvoreBinaria.PesquisarComDfsPreOrdem(4);

            noProcurado.ShouldNotBeNull();
            noProcurado.Valor.ShouldBe(4);
        }

        [Fact]
        public void PesquisarComDfsPreOrdem_Deve_Retornar_No_Quando_Valor_Esta_No_Meio()
        {
            InicializarArvore();
            NoArvore? noProcurado = _arvoreBinaria.PesquisarComDfsPreOrdem(2);

            noProcurado.ShouldNotBeNull();
            noProcurado.Valor.ShouldBe(2);
        }

        [Fact]
        public void PesquisarComDfsPreOrdem_Deve_Retornar_No_Quando_Valor_Esta_Na_Folha()
        {
            InicializarArvore();

            NoArvore? noProcurado = _arvoreBinaria.PesquisarComDfsPreOrdem(1);

            noProcurado.ShouldNotBeNull();
            noProcurado.Valor.ShouldBe(1);
        }

        [Fact]
        public void PesquisarComDfsPreOrdem_Deve_Retornar_Null_Quando_Valor_Nao_Existe()
        {
            InicializarArvore();

            NoArvore? noProcurado = _arvoreBinaria.PesquisarComDfsPreOrdem(999);

            noProcurado.ShouldBeNull();
        }

        [Fact]
        public void PesquisarDfsEmOrdem_Deve_Retornar_Null_Quando_Valor_Nao_Existe()
        {
            InicializarArvore();

            NoArvore? noProcurado = _arvoreBinaria.PesquisarDfsEmOrdem(999);

            noProcurado.ShouldBeNull();
        }

        [Fact]
        public void PesquisarDfsEmOrdem_Deve_Retornar_No_Quando_Valor_Existe()
        {
            InicializarArvore();

            NoArvore? noProcurado = _arvoreBinaria.PesquisarDfsEmOrdem(5);

            noProcurado.ShouldNotBeNull();
            noProcurado.Valor.ShouldBe(5);
        }

        [Fact]
        public void PesquisarDfsPosOrdem_Deve_Retornar_Null_Quando_Valor_Nao_Existe()
        {
            InicializarArvore();

            NoArvore? noProcurado = _arvoreBinaria.PesquisarDfsPosOrdem(999);

            noProcurado.ShouldBeNull();
        }

        [Fact]
        public void PesquisarDfsPosOrdem_Deve_Retornar_No_Quando_Valor_Existe()
        {
            InicializarArvore();

            NoArvore? noProcurado = _arvoreBinaria.PesquisarDfsPosOrdem(6);

            noProcurado.ShouldNotBeNull();
            noProcurado.Valor.ShouldBe(6);
        }


        [Fact]
        public void Remover_Deve_Remover_No_Sem_Filhos()
        {
            _arvoreBinaria.Inserir(10);
            _arvoreBinaria.Inserir(5);
            _arvoreBinaria.Inserir(15);

            _arvoreBinaria.Remover(5);

            _arvoreBinaria.PesquisarComBfs(5).ShouldBeNull();
        }

        [Fact]
        public void Remover_Deve_Remover_No_Com_Um_Filho()
        {
            ArvoreBinaria arvore = new(null!);
            _arvoreBinaria.Inserir(10);
            _arvoreBinaria.Inserir(5);
            _arvoreBinaria.Inserir(15);
            _arvoreBinaria.Inserir(7);  

            _arvoreBinaria.Remover(5);

            _arvoreBinaria.PesquisarComBfs(5).ShouldBeNull();
            _arvoreBinaria.PesquisarComBfs(7).ShouldNotBeNull();
        }

        [Fact]
        public void Remover_Deve_Remover_No_Com_Dois_Filhos()
        {
            _arvoreBinaria.Inserir(10);
            _arvoreBinaria.Inserir(5);
            _arvoreBinaria.Inserir(15);
            _arvoreBinaria.Inserir(3);
            _arvoreBinaria.Inserir(7);

            _arvoreBinaria.Remover(5);

            _arvoreBinaria.PesquisarComBfs(5).ShouldBeNull();
            _arvoreBinaria.PesquisarComBfs(7).ShouldNotBeNull();
        }

        [Fact]
        public void Remover_Deve_Remover_Raiz_Com_Dois_Filhos()
        {
            _arvoreBinaria.Inserir(10);
            _arvoreBinaria.Inserir(5);
            _arvoreBinaria.Inserir(15);
            _arvoreBinaria.Inserir(3);
            _arvoreBinaria.Inserir(7);

            _arvoreBinaria.Remover(10);

            _arvoreBinaria.PesquisarComBfs(10).ShouldBeNull();
            _arvoreBinaria.PesquisarComBfs(7).ShouldNotBeNull();
            _arvoreBinaria.PesquisarComBfs(15).ShouldNotBeNull();
        }

        private void InicializarArvore()
        {            
            _arvoreBinaria.Inserir(1);
            _arvoreBinaria.Inserir(2);
            _arvoreBinaria.Inserir(3);
            _arvoreBinaria.Inserir(4);
            _arvoreBinaria.Inserir(5);
            _arvoreBinaria.Inserir(6);
        }
    }
}