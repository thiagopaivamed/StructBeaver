using Shouldly;
using StructBeaver.Arvores;
using StructBeaver.Arvores.ArvoreBinaria;
using StructBeaver.Arvores.ArvoreBinaria.Exercicios;

namespace StructBeaver.Tests.Arvores.Binaria.Exercicios
{
    public class RemocaoNoComFilhoUnicoArvoreBinariaTest
    {
        private readonly RemocaoNoComFilhoUnicoArvoreBinaria _remocaoNoComFilhoUnicoArvoreBinaria;

        public RemocaoNoComFilhoUnicoArvoreBinariaTest()
            => _remocaoNoComFilhoUnicoArvoreBinaria = new();

        [Fact]
        public void Remocao_No_Com_Filho_Unico_Deve_Retornar_Null_Quando_Arvore_For_Nula()
        {            
            ArvoreBinaria? arvoreBinaria = null; 

            arvoreBinaria = _remocaoNoComFilhoUnicoArvoreBinaria.RemoverFilhoUnico(arvoreBinaria);

            arvoreBinaria.ShouldBeNull();
        }

        [Fact]
        public void Remocao_No_Com_Filho_Unico_Deve_Retornar_Null_Quando_Raiz_For_Nula()
        {
            NoArvore? raiz = null;
            ArvoreBinaria? arvoreBinaria = new(raiz);

            arvoreBinaria = _remocaoNoComFilhoUnicoArvoreBinaria.RemoverFilhoUnico(arvoreBinaria);

            arvoreBinaria?.Raiz.ShouldBeNull();
        }

        [Fact]
        public void Remocao_No_Com_Filho_Unico_Deve_Retornar_Raiz_Quando_Somente_Ela_Existir()
        {
            NoArvore? raiz = new(99);
            ArvoreBinaria? arvoreBinaria = new(raiz);

            arvoreBinaria = _remocaoNoComFilhoUnicoArvoreBinaria.RemoverFilhoUnico(arvoreBinaria);

            arvoreBinaria!.Raiz.Valor.ShouldBe(99);
            arvoreBinaria.Raiz.NoEsquerdo.ShouldBeNull();
            arvoreBinaria.Raiz.NoDireito.ShouldBeNull();
        }

        [Fact]
        public void Remocao_No_Com_Filho_Unico_Deve_Retornar_Arvore_Original_Quando_Nao_Ha_Nos_Com_Somente_Um_Filho()
        {
            NoArvore? raiz = new(99);
            ArvoreBinaria? arvoreBinaria = new(raiz);

            arvoreBinaria.Inserir(60);
            arvoreBinaria.Inserir(115);

            arvoreBinaria = _remocaoNoComFilhoUnicoArvoreBinaria.RemoverFilhoUnico(arvoreBinaria);

            arvoreBinaria!.Raiz.Valor.ShouldBe(99);
            arvoreBinaria.Raiz.NoEsquerdo.ShouldNotBeNull();
            arvoreBinaria.Raiz.NoDireito.ShouldNotBeNull();

            arvoreBinaria!.Raiz.NoEsquerdo.Valor.ShouldBe(60);
            arvoreBinaria.Raiz.NoEsquerdo.NoEsquerdo.ShouldBeNull();
            arvoreBinaria.Raiz.NoEsquerdo.NoDireito.ShouldBeNull();

            arvoreBinaria!.Raiz.NoDireito.Valor.ShouldBe(115);
            arvoreBinaria.Raiz.NoDireito.NoEsquerdo.ShouldBeNull();
            arvoreBinaria.Raiz.NoDireito.NoDireito.ShouldBeNull();
        }

        [Fact]
        public void Remocao_No_Com_Filho_Unico_Deve_Retornar_Arvore_Sem_Nos_Que_Possuem_Somente_Um_Filho()
        {
            NoArvore? raiz = new(99);
            ArvoreBinaria? arvoreBinaria = new(raiz);

            arvoreBinaria.Inserir(60);
            arvoreBinaria.Inserir(70);
            arvoreBinaria.Inserir(115);
            arvoreBinaria.Inserir(120);

            arvoreBinaria = _remocaoNoComFilhoUnicoArvoreBinaria.RemoverFilhoUnico(arvoreBinaria);

            arvoreBinaria!.Raiz.Valor.ShouldBe(99);
            arvoreBinaria.Raiz.NoEsquerdo.ShouldBeNull();
            arvoreBinaria.Raiz.NoDireito.ShouldBeNull();            
        }
    }
}