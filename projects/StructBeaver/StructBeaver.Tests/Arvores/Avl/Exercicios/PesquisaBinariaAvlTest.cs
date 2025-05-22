using Shouldly;
using StructBeaver.Arvores.Avl.Exercicios;
using StructBeaver.Arvores.Avl;
using StructBeaver.Arvores;

namespace StructBeaver.Tests.Arvores.Avl.Exercicios
{
    public class PesquisaBinariaAvlTest
    {
        private readonly PesquisaBinariaAvl _pesquisaBinariaAvl;

        public PesquisaBinariaAvlTest()
            => _pesquisaBinariaAvl = new();

        private ArvoreAvl CriarArvore()
        {
            NoAvl no5 = new(5) { Altura = 1 };
            NoAvl no10 = new(10) { Altura = 2, NoEsquerdo = no5 };
            NoAvl no40 = new(40) { Altura = 1 };
            NoAvl no30 = new(30) { Altura = 2, NoDireito = no40 };
            NoAvl raiz = new(20) { Altura = 3, NoEsquerdo = no10, NoDireito = no30 };

            return new(raiz);
        }

        [Fact]
        public void Pesquisar_Deve_Retornar_No_Quando_Valor_Existe_Na_Raiz()
        {
            ArvoreAvl arvore = CriarArvore();

            NoAvl? noProcurado = _pesquisaBinariaAvl.Pesquisar(arvore, 20);

            noProcurado.ShouldNotBeNull();
            noProcurado!.Valor.ShouldBe(20);
        }

        [Fact]
        public void Pesquisar_Deve_Retornar_No_Quando_Valor_Existe_Na_Subarvore()
        {
            ArvoreAvl arvore = CriarArvore();

            NoAvl? noProcurado = _pesquisaBinariaAvl.Pesquisar(arvore, 5);

            noProcurado.ShouldNotBeNull();
            noProcurado!.Valor.ShouldBe(5);
        }

        [Fact]
        public void Pesquisar_Deve_Retornar_Null_Quando_Valor_Nao_Existe()
        {
            ArvoreAvl arvore = CriarArvore();

            NoAvl? noProcurado = _pesquisaBinariaAvl.Pesquisar(arvore, 100);

            noProcurado.ShouldBeNull();
        }

        [Fact]
        public void Pesquisar_Deve_Retornar_Null_Quando_Arvore_Eh_Null()
        {
            NoAvl? noProcurado = _pesquisaBinariaAvl.Pesquisar(null!, 10);

            noProcurado.ShouldBeNull();
        }

        [Fact]
        public void Pesquisar_Deve_Retornar_Null_Quando_Raiz_Eh_Null()
        {
            ArvoreAvl arvoreComRaizNula = new(null!);

            NoAvl? noProcurado = _pesquisaBinariaAvl.Pesquisar(arvoreComRaizNula, 10);

            noProcurado.ShouldBeNull();
        }
    }
}