using Shouldly;
using StructBeaver.Arvores;
using StructBeaver.Arvores.ArvoreBinaria;
using StructBeaver.Arvores.ArvoreBinaria.Exercicios;

namespace StructBeaver.Tests.Arvores.Binaria.Exercicios
{
    public class MaiorValorArvoreBinariaTest
    {
        private readonly MaiorValorArvoreBinaria _maiorValorArvoreBinaria;

        public MaiorValorArvoreBinariaTest()
            => _maiorValorArvoreBinaria = new();

        [Fact]
        public void Maior_Valor_Deve_Retornar_Zero_Quando_Arvore_For_Nula()
        {
            ArvoreBinaria arvoreBinaria = null!;

            int maiorValor = _maiorValorArvoreBinaria.PegarMaiorValor(arvoreBinaria);

            maiorValor.ShouldBe(0);
        }

        [Fact]
        public void Maior_Valor_Deve_Retornar_Zero_Quando_Raiz_For_Nula()
        {
            ArvoreBinaria arvoreBinaria = new(null!);

            int maiorValor = _maiorValorArvoreBinaria.PegarMaiorValor(arvoreBinaria);

            maiorValor.ShouldBe(0);
        }

        [Fact]
        public void Maior_Valor_Deve_Retornar_Valor_Da_Raiz_Quando_Existir_Apenas_Raiz()
        {
            NoArvore raiz = new(70);
            ArvoreBinaria arvoreBinaria = new(raiz);

            int maiorValor = _maiorValorArvoreBinaria.PegarMaiorValor(arvoreBinaria);

            maiorValor.ShouldBe(raiz.Valor);
        }

        [Fact]
        public void Maior_Valor_Deve_Retornar_Maior_Valor_na_Arvore()
        {
            ArvoreBinaria arvoreBinaria = new(null!);
            arvoreBinaria.Inserir(10);
            arvoreBinaria.Inserir(5);
            arvoreBinaria.Inserir(15);

            int maiorValor = _maiorValorArvoreBinaria.PegarMaiorValor(arvoreBinaria);

            maiorValor.ShouldBe(15);
        }
    }
}