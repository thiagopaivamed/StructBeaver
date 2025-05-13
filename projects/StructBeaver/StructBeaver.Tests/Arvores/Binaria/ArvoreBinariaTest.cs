using Shouldly;
using StructBeaver.Arvores;
using StructBeaver.Arvores.ArvoreBinaria;

namespace StructBeaver.Tests.Arvores.Binaria
{
    public class ArvoreBinariaTest
    {
        private ArvoreBinaria _arvoreBinaria;

        public ArvoreBinariaTest()
            => _arvoreBinaria = new(null);

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
        public void Pesquisar_Deve_Retornar_No_Quando_Ele_For_Encontrado()
        {
            _arvoreBinaria.Inserir(10);
            _arvoreBinaria.Inserir(5);
            _arvoreBinaria.Inserir(15);

            NoArvore noEncontrado = _arvoreBinaria.Pesquisar(5);
            noEncontrado.ShouldNotBeNull();
            noEncontrado.Valor.ShouldBe(5);
        }

        [Fact]
        public void Pesquisar_Deve_Retornar_Null_Quando_No_Nao_For_Encontrado()
        {
            _arvoreBinaria.Inserir(10);
            _arvoreBinaria.Inserir(5);
            _arvoreBinaria.Inserir(15);

            NoArvore noEncontrado = _arvoreBinaria.Pesquisar(30);
            noEncontrado.ShouldBeNull();
        }

        [Fact]
        public void Remover_Deve_Remover_No_Sem_Filhos()
        {
            _arvoreBinaria.Inserir(10);
            _arvoreBinaria.Inserir(5);
            _arvoreBinaria.Inserir(15);

            _arvoreBinaria.Remover(5);

            _arvoreBinaria.Pesquisar(5).ShouldBeNull();
        }

        [Fact]
        public void Remover_Deve_Remover_No_Com_Um_Filho()
        {
            ArvoreBinaria arvore = new(null);
            _arvoreBinaria.Inserir(10);
            _arvoreBinaria.Inserir(5);
            _arvoreBinaria.Inserir(15);
            _arvoreBinaria.Inserir(7);  

            _arvoreBinaria.Remover(5);

            _arvoreBinaria.Pesquisar(5).ShouldBeNull();
            _arvoreBinaria.Pesquisar(7).ShouldNotBeNull();
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

            _arvoreBinaria.Pesquisar(5).ShouldBeNull();
            _arvoreBinaria.Pesquisar(7).ShouldNotBeNull();
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

            _arvoreBinaria.Pesquisar(10).ShouldBeNull();
            _arvoreBinaria.Pesquisar(7).ShouldNotBeNull();
            _arvoreBinaria.Pesquisar(15).ShouldNotBeNull();
        }
    }
}