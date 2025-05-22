using Shouldly;
using StructBeaver.Arvores;
using StructBeaver.Arvores.Avl;
using StructBeaver.Arvores.Avl.Exercicios;

namespace StructBeaver.Tests.Arvores.Avl.Exercicios
{
    public class BalanceamentoAvlTest
    {
        private readonly BalanceamentoAvl _balanceamentoAvl;

        public BalanceamentoAvlTest()
            => _balanceamentoAvl = new BalanceamentoAvl();

        [Fact]
        public void Eh_Balanceada_Deve_Retornar_True_Quando_Arvore_Estiver_Balanceada()
        {
            ArvoreAvl arvore = new(null!);

            arvore.RaizAvl = arvore.Inserir(arvore.RaizAvl, 30)!;
            arvore.RaizAvl = arvore.Inserir(arvore.RaizAvl, 20)!;
            arvore.RaizAvl = arvore.Inserir(arvore.RaizAvl, 40)!;
            arvore.RaizAvl = arvore.Inserir(arvore.RaizAvl, 10)!;
            arvore.RaizAvl = arvore.Inserir(arvore.RaizAvl, 25)!;

            bool ehBalanceada = _balanceamentoAvl.EhBalanceada(arvore);

            ehBalanceada.ShouldBeTrue();
        }

        [Fact]
        public void Eh_Balanceada_Deve_Retornar_False_Quando_Fator_Balanceamento_For_Maior_Que_Um()
        {
            NoAvl no3 = new(3)
            {
                Altura = 1
            };

            NoAvl no5 = new(5)
            {
                Altura = 2,
                NoEsquerdo = no3
            };

            NoAvl no10 = new(10)
            {
                Altura = 3,
                NoEsquerdo = no5
            };

            NoAvl no30 = new(30)
            {
                Altura = 1
            };

            NoAvl raiz = new(20)
            {
                Altura = 4,
                NoEsquerdo = no10,
                NoDireito = no30
            };

            ArvoreAvl arvore = new(raiz);

            bool ehBalanceada = _balanceamentoAvl.EhBalanceada(arvore);

            ehBalanceada.ShouldBeFalse();
        }
    }
}