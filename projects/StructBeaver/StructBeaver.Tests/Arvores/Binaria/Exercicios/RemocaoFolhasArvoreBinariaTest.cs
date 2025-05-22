using Shouldly;
using StructBeaver.Arvores;
using StructBeaver.Arvores.ArvoreBinaria;
using StructBeaver.Arvores.ArvoreBinaria.Exercicios;

namespace StructBeaver.Tests.Arvores.Binaria.Exercicios
{
    public class RemocaoFolhasArvoreBinariaTest
    {
        private readonly RemocaoFolhasArvoreBinaria _remocaoFolhasArvoreBinaria;

        public RemocaoFolhasArvoreBinariaTest()        
            => _remocaoFolhasArvoreBinaria = new();

        [Fact]
        public void Remocao_Folhas_Deve_Retornar_Nulo_Quando_Arvore_For_Nula()
        {
            ArvoreBinaria arvoreBinaria = null!;

            arvoreBinaria = _remocaoFolhasArvoreBinaria.RemoverFolhas(arvoreBinaria)!;

            arvoreBinaria.ShouldBeNull();
        }

        [Fact]
        public void Remocao_Folhas_Deve_Retornar_Nulo_Quando_Raiz_For_Nula()
        {
            ArvoreBinaria arvoreBinaria = new(null!);

            arvoreBinaria = _remocaoFolhasArvoreBinaria.RemoverFolhas(arvoreBinaria)!;

            arvoreBinaria?.Raiz.ShouldBeNull();
        }

        [Fact]
        public void Remocao_Folhas_Deve_Retornar_Raiz_Quando_For_Unico_No()
        {
            NoArvore raiz = new (90);
            ArvoreBinaria arvoreBinaria = new(raiz);

            arvoreBinaria = _remocaoFolhasArvoreBinaria.RemoverFolhas(arvoreBinaria)!;

            arvoreBinaria.Raiz.ShouldBeNull();
        }

        [Fact]
        public void Remocao_Folhas_Deve_Retornar_Sem_Folhas()
        {
            NoArvore raiz = new(90);

            ArvoreBinaria arvoreBinaria = new(raiz);
            arvoreBinaria.Inserir(60);
            arvoreBinaria.Inserir(55);
            arvoreBinaria.Inserir(80);
            arvoreBinaria.Inserir(120);
            arvoreBinaria.Inserir(115);
            arvoreBinaria.Inserir(130);

            arvoreBinaria = _remocaoFolhasArvoreBinaria.RemoverFolhas(arvoreBinaria)!;

            arvoreBinaria.Raiz.ShouldNotBeNull();
            arvoreBinaria.Raiz.Valor.ShouldBe(90);

            arvoreBinaria.Raiz.NoEsquerdo!.Valor.ShouldBe(60);
            arvoreBinaria.Raiz.NoEsquerdo.NoEsquerdo.ShouldBeNull();
            arvoreBinaria.Raiz.NoEsquerdo.NoDireito.ShouldBeNull();

            arvoreBinaria.Raiz.NoDireito!.Valor.ShouldBe(120);
            arvoreBinaria.Raiz.NoDireito.NoEsquerdo.ShouldBeNull();
            arvoreBinaria.Raiz.NoDireito.NoDireito.ShouldBeNull();
        }
    }
}
