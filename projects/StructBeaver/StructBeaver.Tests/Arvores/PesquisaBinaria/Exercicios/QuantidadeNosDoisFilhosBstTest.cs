using Shouldly;
using StructBeaver.Arvores.ArvorePesquisaBinaria;
using StructBeaver.Arvores;
using StructBeaver.Arvores.ArvorePesquisaBinaria.Exercicios;

namespace StructBeaver.Tests.Arvores.PesquisaBinaria.Exercicios
{
    public class QuantidadeNosDoisFilhosBstTest
    {
        private readonly QuantidadeNosDoisFilhosBst _quantidadeNosDoisFilhosBst;

        public QuantidadeNosDoisFilhosBstTest()
            => _quantidadeNosDoisFilhosBst = new QuantidadeNosDoisFilhosBst();

        [Fact]
        public void Contar_Nos_Dois_Filhos_Deve_Retornar_Zero_Quando_Arvore_Nula()
        {
            ArvorePesquisaBinaria? arvore = null;

            int quantidadeNosComDoisFilhos = _quantidadeNosDoisFilhosBst.ContarNosDoisFilhos(arvore);

            quantidadeNosComDoisFilhos.ShouldBe(0);
        }

        [Fact]
        public void Contar_Nos_Dois_Filhos_Deve_Retornar_Zero_Quando_Raiz_Nula()
        {
            ArvorePesquisaBinaria arvore = new(null!);

            int quantidadeNosComDoisFilhos = _quantidadeNosDoisFilhosBst.ContarNosDoisFilhos(arvore);

            quantidadeNosComDoisFilhos.ShouldBe(0);
        }

        [Fact]
        public void Contar_Nos_Dois_Filhos_Deve_Retornar_Zero_Quando_Arvore_Com_Um_No_Sem_Filhos()
        {
            NoArvore raiz = new(10);
            ArvorePesquisaBinaria arvore = new(raiz);

            int quantidadeNosComDoisFilhos = _quantidadeNosDoisFilhosBst.ContarNosDoisFilhos(arvore);

            quantidadeNosComDoisFilhos.ShouldBe(0);
        }

        [Fact]
        public void Contar_Nos_Dois_Filhos_Deve_Retornar_Um_Quando_Arvore_Com_Um_No_Com_Dois_Filhos()
        {
            NoArvore noEsquerdo = new(5);
            NoArvore noDireito = new(15);
            NoArvore raiz = new(10) { NoEsquerdo = noEsquerdo, NoDireito = noDireito };
            ArvorePesquisaBinaria arvore = new(raiz);

            int quantidadeNosComDoisFilhos = _quantidadeNosDoisFilhosBst.ContarNosDoisFilhos(arvore);

            quantidadeNosComDoisFilhos.ShouldBe(1);
        }

        [Fact]
        public void Contar_Nos_Dois_Filhos_Deve_Retornar_Quantidade_Correta_Quando_Arvore_Mais_Completa()
        {
            NoArvore no1 = new(1);
            NoArvore no3 = new(3);
            NoArvore no2 = new(2) { NoEsquerdo = no1, NoDireito = no3 };

            NoArvore no7 = new(7);
            NoArvore no9 = new(9);
            NoArvore no8 = new(8) { NoEsquerdo = no7, NoDireito = no9 };

            NoArvore raiz = new(5) { NoEsquerdo = no2, NoDireito = no8 };

            ArvorePesquisaBinaria arvore = new(raiz);

            int quantidadeNosComDoisFilhos = _quantidadeNosDoisFilhosBst.ContarNosDoisFilhos(arvore);

            quantidadeNosComDoisFilhos.ShouldBe(3);
        }
    }
}