using Shouldly;
using StructBeaver.Arvores;
using StructBeaver.Arvores.ArvorePesquisaBinaria;
using StructBeaver.Arvores.ArvorePesquisaBinaria.Exercicios;

namespace StructBeaver.Tests.Arvores.PesquisaBinaria.Exercicios
{
    public class ArvoreBalanceadaBstTest
    {
        private readonly ArvoreBalanceadaBst _arvoreBalanceadaBst;

        public ArvoreBalanceadaBstTest() =>
            _arvoreBalanceadaBst = new ArvoreBalanceadaBst();

        [Fact]
        public void Arvore_BST_Deve_Retornar_True_Quando_Balanceada()
        {
            NoArvore raiz = new(50);
            ArvorePesquisaBinaria arvore = new(raiz);
            arvore.Inserir(50);
            arvore.Inserir(30);
            arvore.Inserir(70);
            arvore.Inserir(20);
            arvore.Inserir(40);
            arvore.Inserir(60);
            arvore.Inserir(80);

            bool ehBalanceada = _arvoreBalanceadaBst.EhBalanceada(arvore);

            ehBalanceada.ShouldBeTrue();
        }

        [Fact]
        public void Arvore_BST_Deve_Retornar_False_Quando_Totalmente_Desbalanceada_A_Direita()
        {
            NoArvore raiz = new(10);
            ArvorePesquisaBinaria arvore = new(raiz);
            arvore.Inserir(20);
            arvore.Inserir(30);
            arvore.Inserir(40);
            arvore.Inserir(50);

            bool ehBalanceada = _arvoreBalanceadaBst.EhBalanceada(arvore);

            ehBalanceada.ShouldBeFalse();
        }

        [Fact]
        public void Arvore_BST_Deve_Retornar_True_Quando_Tiver_Somente_Um_No()
        {
            NoArvore raiz = new(100);
            ArvorePesquisaBinaria arvore = new(raiz);

            bool ehBalanceada = _arvoreBalanceadaBst.EhBalanceada(arvore);

            ehBalanceada.ShouldBeTrue();
        }

        [Fact]
        public void Arvore_BST_Deve_Retornar_True_Quando_Vazia()
        {
            ArvorePesquisaBinaria arvore = new(null!);

            bool ehBalanceada = _arvoreBalanceadaBst.EhBalanceada(arvore);

            ehBalanceada.ShouldBeTrue();
        }

        [Fact]
        public void Arvore_BST_Deve_Retornar_False_Quando_Desbalanceada_A_Esquerda()
        {
            NoArvore raiz = new(50);
            ArvorePesquisaBinaria arvore = new(raiz);
            arvore.Inserir(40);
            arvore.Inserir(30);
            arvore.Inserir(20);

            bool ehBalanceada = _arvoreBalanceadaBst.EhBalanceada(arvore);

            ehBalanceada.ShouldBeFalse();
        }

        [Fact]
        public void Arvore_BST_Deve_Retornar_False_Quando_Diferenca_De_Altura_Maior_Que_Um()
        {
            NoArvore raiz = new(40);
            ArvorePesquisaBinaria arvore = new(raiz);
            arvore.Inserir(30);
            arvore.Inserir(20);
            arvore.Inserir(10);
            arvore.Inserir(50);

            bool ehBalanceada = _arvoreBalanceadaBst.EhBalanceada(arvore);

            ehBalanceada.ShouldBeFalse();
        }
    }
}