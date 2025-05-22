using Shouldly;
using StructBeaver.Arvores.Avl.Exercicios;
using StructBeaver.Arvores.Avl;
using StructBeaver.Arvores;

namespace StructBeaver.Tests.Arvores.Avl.Exercicios
{
    public class QuantidadeNosDesbalanceadosAvlTest
    {
        private readonly QuantidadeNosDesbalanceadosAvl _quantidadeNosDesbalanceadosAvl;

        public QuantidadeNosDesbalanceadosAvlTest()
            => _quantidadeNosDesbalanceadosAvl = new();

        [Fact]
        public void Contar_Nos_Desbalanceados_Deve_Retornar_Zero_Quando_Arvore_For_Nula()
        {
            ArvoreAvl arvore = new(null!);

            int quantidadeNosDesbalanceados = _quantidadeNosDesbalanceadosAvl.ContarNosDesbalanceados(arvore);

            quantidadeNosDesbalanceados.ShouldBe(0);
        }

        [Fact]
        public void Contar_Nos_Desbalanceados_Deve_Retornar_Zero_Quando_Arvore_Balanceada()
        {
            NoAvl noEsquerdo = new(5) { Altura = 1 };

            NoAvl noDireito = new(15) { Altura = 1 };

            NoAvl raiz = new(10)
            {
                Altura = 2,
                NoEsquerdo = noEsquerdo,
                NoDireito = noDireito
            };

            ArvoreAvl arvore = new(raiz);

            int quantidadeNosDesbalanceados = _quantidadeNosDesbalanceadosAvl.ContarNosDesbalanceados(arvore);

            quantidadeNosDesbalanceados.ShouldBe(0);
        }        

        [Fact]
        public void Contar_Nos_Desbalanceados_Deve_Retornar_Quantidade_Correta_Quando_Ha_Multiplos_Nos_Desbalanceados()
        {
            NoAvl noEsquerdoFilhoEsquerdo = new(3)
            {
                Altura = 2,
                NoEsquerdo = new(2) { Altura = 1 }
            };

            NoAvl noEsquerdo = new(5)
            {
                Altura = 3,
                NoEsquerdo = noEsquerdoFilhoEsquerdo
            };

            NoAvl noDireito = new(15) { Altura = 1 };

            NoAvl raiz = new(10)
            {
                Altura = 4,
                NoEsquerdo = noEsquerdo,
                NoDireito = noDireito
            };

            ArvoreAvl arvore = new(raiz);

            int quantidadeNosDesbalanceados = _quantidadeNosDesbalanceadosAvl.ContarNosDesbalanceados(arvore);

            quantidadeNosDesbalanceados.ShouldBe(2);
        }
    }
}