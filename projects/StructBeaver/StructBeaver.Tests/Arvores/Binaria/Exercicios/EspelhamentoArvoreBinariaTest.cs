using Shouldly;
using StructBeaver.Arvores;
using StructBeaver.Arvores.ArvoreBinaria;
using StructBeaver.Arvores.ArvoreBinaria.Exercicios;

namespace StructBeaver.Tests.Arvores.Binaria.Exercicios
{
    public class EspelhamentoArvoreBinariaTest
    {
        private readonly EspelhamentoArvoreBinaria _espelhamentoArvoreBinaria;

        public EspelhamentoArvoreBinariaTest()
            => _espelhamentoArvoreBinaria = new();

        [Fact]
        public void Espelhamento_Deve_Retornar_Nulo_Quando_Arvore_For_Nula()
        {
            ArvoreBinaria arvoreBinaria = null!;

            arvoreBinaria = _espelhamentoArvoreBinaria.Espelhar(arvoreBinaria)!;

            arvoreBinaria.ShouldBeNull();
        }

        [Fact]
        public void Espelhamento_Deve_Retornar_Nulo_Quando_Raiz_For_Nula()
        {
            ArvoreBinaria arvoreBinaria = new(null!);

            arvoreBinaria = _espelhamentoArvoreBinaria.Espelhar(arvoreBinaria)!;

            arvoreBinaria?.Raiz.ShouldBeNull();
        }

        [Fact]
        public void Espelhar_Deve_Inverter_Filhos_Corretamente()
        {
            NoArvore no4 = new(4);
            NoArvore no5 = new(5);
            NoArvore no6 = new(6);
            NoArvore no7 = new(7);

            NoArvore no2 = new(2);
            no2.NoEsquerdo = no4;
            no2.NoDireito = no5;

            NoArvore no3 = new(3);
            no3.NoEsquerdo = no6;
            no3.NoDireito = no7;

            NoArvore raiz = new(1);
            raiz.NoEsquerdo = no2;
            raiz.NoDireito = no3;

            ArvoreBinaria arvore = new(raiz);

            ArvoreBinaria? arvoreEspelhada = _espelhamentoArvoreBinaria.Espelhar(arvore);

            arvoreEspelhada!.Raiz.Valor.ShouldBe(1);
            arvoreEspelhada.Raiz.NoEsquerdo!.Valor.ShouldBe(3);
            arvoreEspelhada.Raiz.NoDireito!.Valor.ShouldBe(2);

            arvoreEspelhada.Raiz.NoEsquerdo.NoEsquerdo!.Valor.ShouldBe(7);
            arvoreEspelhada.Raiz.NoEsquerdo.NoDireito!.Valor.ShouldBe(6);

            arvoreEspelhada.Raiz.NoDireito.NoEsquerdo!.Valor.ShouldBe(5);
            arvoreEspelhada.Raiz.NoDireito.NoDireito!.Valor.ShouldBe(4);
        }

        [Fact]
        public void Espelhar_Arvore_Com_Apenas_Um_No_Deve_Manter_No()
        {
            NoArvore raiz = new(42);
            ArvoreBinaria arvore = new(raiz);

            ArvoreBinaria? arvoreEspelhada = _espelhamentoArvoreBinaria.Espelhar(arvore);

            arvoreEspelhada!.Raiz.Valor.ShouldBe(42);
            arvoreEspelhada.Raiz.NoEsquerdo.ShouldBeNull();
            arvoreEspelhada.Raiz.NoDireito.ShouldBeNull();
        }
    }
}