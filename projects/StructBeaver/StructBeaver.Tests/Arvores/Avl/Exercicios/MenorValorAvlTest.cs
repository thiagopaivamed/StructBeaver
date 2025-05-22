using Shouldly;
using StructBeaver.Arvores.Avl.Exercicios;
using StructBeaver.Arvores.Avl;
using StructBeaver.Arvores;

namespace StructBeaver.Tests.Arvores.Avl.Exercicios
{
    public class MenorValorAvlTest
    {
        private readonly MenorValorAvl _menorValorAvl;

        public MenorValorAvlTest()
            => _menorValorAvl = new MenorValorAvl();
        
        [Fact]
        public void Pegar_Menor_Valor_Deve_Retornar_Null_Quando_Arvore_For_Nula()
        {
            ArvoreAvl arvore = null!;

            int? menorValor = _menorValorAvl.PegarMenorValor(arvore);

            menorValor.ShouldBeNull();
        }

        [Fact]
        public void PegarMenorValor_Deve_Retornar_Null_Quando_Raiz_For_Nula()
        {
            ArvoreAvl arvore = new(null!);

            int? menorValor = _menorValorAvl.PegarMenorValor(arvore);

            menorValor.ShouldBeNull();
        }

        [Fact]
        public void Pegar_Menor_Valor_Deve_Retornar_Valor_Da_Raiz_Quando_Existe_Somente_Raiz_Na_Arvore()
        {
            NoAvl raiz = new(10) { Altura = 1 };
            ArvoreAvl arvore = new(raiz);

            int? menorValor = _menorValorAvl.PegarMenorValor(arvore);

            menorValor.ShouldBe(10);
        }

        [Fact]
        public void Pegar_Menor_Valor_Deve_Retornar_Menor_Valor_Correto()
        {
            NoAvl noEsquerdoProfundo = new(3) { Altura = 1 };
            NoAvl noEsquerdo = new(5) { Altura = 2, NoEsquerdo = noEsquerdoProfundo };
            NoAvl noDireito = new(15) { Altura = 1 };
            NoAvl raiz = new(10) { Altura = 3, NoEsquerdo = noEsquerdo, NoDireito = noDireito };
            ArvoreAvl arvore = new(raiz);

            int? menorValor = _menorValorAvl.PegarMenorValor(arvore);

            menorValor.ShouldBe(3);
        }
    }
}