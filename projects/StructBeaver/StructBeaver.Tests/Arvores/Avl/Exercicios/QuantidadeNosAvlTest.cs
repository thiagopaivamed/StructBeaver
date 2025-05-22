using Shouldly;
using StructBeaver.Arvores.Avl;
using StructBeaver.Arvores;
using StructBeaver.Arvores.Avl.Exercicios;

namespace StructBeaver.Tests.Arvores.Avl.Exercicios
{
    public class QuantidadeNosAvlTest
    {
        private readonly QuantidadeNosAvl _quantidadeNosAvl;

        public QuantidadeNosAvlTest()
            => _quantidadeNosAvl = new QuantidadeNosAvl();

        [Fact]
        public void Contar_Quantidade_Nos_Deve_Retornar_Zero_Quando_Arvore_For_Nula()
        {
            ArvoreAvl? arvore = null;

            int quantidadeNos = _quantidadeNosAvl.ContarQuantidadeNos(arvore);

            quantidadeNos.ShouldBe(0);
        }

        [Fact]
        public void ContarQuantidadeNos_Deve_Retornar_Zero_Quando_Raiz_For_Nula()
        {
            ArvoreAvl arvore = new(null!);            

            int quantidadeNos = _quantidadeNosAvl.ContarQuantidadeNos(arvore);

            quantidadeNos.ShouldBe(0);
        }

        [Fact]
        public void Contar_Quantidade_Nos_Deve_Retornar_Um_Quando_Arvore_Tiver_Apenas_Raiz()
        {
            NoAvl noRaiz = new(10);
            ArvoreAvl arvore = new(noRaiz);
            
            int quantidadeNos = _quantidadeNosAvl.ContarQuantidadeNos(arvore);

            quantidadeNos.ShouldBe(1);
        }

        [Fact]
        public void ContarQuantidadeNos_Deve_Retornar_QuantidadeCorreta_Quando_ArvoreComMultiplosNos()
        {
            NoAvl no3 = new(3);
            NoAvl no5 = new(5) { NoEsquerdo = no3 };
            NoAvl no12 = new(12);
            NoAvl no20 = new(20);
            NoAvl no15 = new(15) { NoEsquerdo = no12, NoDireito = no20 };
            NoAvl raiz = new(10) { NoEsquerdo = no5, NoDireito = no15 };

            ArvoreAvl arvore = new(raiz);            

            int quantidadeNos = _quantidadeNosAvl.ContarQuantidadeNos(arvore);

            quantidadeNos.ShouldBe(6);
        }
    }
}