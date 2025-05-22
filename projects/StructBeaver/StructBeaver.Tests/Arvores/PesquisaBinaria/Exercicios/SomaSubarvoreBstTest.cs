using StructBeaver.Arvores.ArvorePesquisaBinaria;
using StructBeaver.Arvores;
using StructBeaver.Arvores.ArvorePesquisaBinaria.Exercicios;
using Shouldly;

namespace StructBeaver.Tests.Arvores.PesquisaBinaria.Exercicios
{
    public class SomaSubarvoreBstTest
    {
        private readonly SomaSubarvoreBst _somaSubarvoreBst;

        public SomaSubarvoreBstTest()
            => _somaSubarvoreBst = new SomaSubarvoreBst();

        [Fact]
        public void SubstituirPorSomaSubarvore_Deve_Manter_Valor_Quando_Apenas_Raiz()
        {
            NoArvore no10 = new(10);
            ArvorePesquisaBinaria arvore = new(no10);

            ArvorePesquisaBinaria? arvoreComSomas = _somaSubarvoreBst.SubstituirPorSomaSubarvore(arvore);

            arvoreComSomas!.Raiz.Valor.ShouldBe(10);
        }

        [Fact]
        public void SubstituirPorSomaSubarvore_Deve_Somar_Subarvores_Quando_Completa()
        {
            NoArvore no5 = new(5);
            NoArvore no12 = new(12);
            NoArvore no20 = new(20);
            NoArvore no15 = new(15) { NoEsquerdo = no12, NoDireito = no20 };
            NoArvore no10 = new(10) { NoEsquerdo = no5, NoDireito = no15 };

            ArvorePesquisaBinaria arvore = new(no10);

            ArvorePesquisaBinaria? arvoreComSomas = _somaSubarvoreBst.SubstituirPorSomaSubarvore(arvore);

            arvoreComSomas?.Raiz.Valor.ShouldBe(62);
            arvoreComSomas?.Raiz.NoEsquerdo!.Valor.ShouldBe(5);
            arvoreComSomas?.Raiz.NoDireito!.Valor.ShouldBe(47);
            arvoreComSomas!.Raiz.NoDireito!.NoEsquerdo!.Valor.ShouldBe(12);
            arvoreComSomas.Raiz.NoDireito.NoDireito!.Valor.ShouldBe(20);
        }

        [Fact]
        public void SubstituirPorSomaSubarvore_Deve_Retornar_Zero_Quando_Arvore_Vazia()
        {
            ArvorePesquisaBinaria arvore = new(null!);

            ArvorePesquisaBinaria? arvoreComSomas = _somaSubarvoreBst.SubstituirPorSomaSubarvore(arvore);

            arvoreComSomas!.Raiz.ShouldBeNull();
        }

        [Fact]
        public void SubstituirPorSomaSubarvore_Deve_Atualizar_Nos_Quando_Subarvore_Esquerda()
        {
            NoArvore no5 = new(5);
            NoArvore no10 = new(10) { NoEsquerdo = no5 };

            ArvorePesquisaBinaria arvore = new(no10);

            ArvorePesquisaBinaria? arvoreComSomas = _somaSubarvoreBst.SubstituirPorSomaSubarvore(arvore);

            arvoreComSomas!.Raiz.Valor.ShouldBe(15);
            arvoreComSomas.Raiz.NoEsquerdo!.Valor.ShouldBe(5);
        }

        [Fact]
        public void SubstituirPorSomaSubarvore_Deve_Atualizar_Nos_Quando_Subarvore_Direita()
        {           

            NoArvore no7 = new(7);
            NoArvore no10 = new(10) { NoDireito = no7 };

            ArvorePesquisaBinaria arvore = new(no10);

            ArvorePesquisaBinaria? arvoreComSomas = _somaSubarvoreBst.SubstituirPorSomaSubarvore(arvore);

            arvoreComSomas!.Raiz.Valor.ShouldBe(17);
            arvoreComSomas.Raiz.NoDireito!.Valor.ShouldBe(7);
        }
    }
}