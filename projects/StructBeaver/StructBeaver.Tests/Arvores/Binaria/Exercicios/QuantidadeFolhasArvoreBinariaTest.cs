using Shouldly;
using StructBeaver.Arvores;
using StructBeaver.Arvores.ArvoreBinaria;
using StructBeaver.Arvores.ArvoreBinaria.Exercicios;

namespace StructBeaver.Tests.Arvores.Binaria.Exercicios
{
    public class QuantidadeFolhasArvoreBinariaTest
    {
        private readonly QuantidadeFolhasArvoreBinaria _quantidadeFolhas;

        public QuantidadeFolhasArvoreBinariaTest()
            => _quantidadeFolhas = new();

        [Fact]
        public void Quantidade_Folhas_Deve_Retornar_Zero_Quando_Arvore_For_Nula()
        {
            ArvoreBinaria arvoreBinaria = null!;

            int quantidadeFolhas = _quantidadeFolhas.ContarFolhas(arvoreBinaria);

            quantidadeFolhas.ShouldBe(0);
        }

        [Fact]
        public void Quantidade_Folhas_Deve_Retornar_Zero_Quando_Raiz_For_Nula()
        {
            ArvoreBinaria arvoreBinaria = new(null!);

            int quantidadeFolhas = _quantidadeFolhas.ContarFolhas(arvoreBinaria);

            quantidadeFolhas.ShouldBe(0);
        }

        [Fact]
        public void Quantidade_Folhas_Deve_Retornar_Um_Quando_Existir_Apenas_Raiz()
        {
            NoArvore raiz = new(75);
            ArvoreBinaria arvoreBinaria = new(raiz);

            int quantidadeFolhas = _quantidadeFolhas.ContarFolhas(arvoreBinaria);

            quantidadeFolhas.ShouldBe(1);
        }

        [Fact]
        public void Quantidade_Folhas_Deve_Retornar_Quantidade_De_Folhas()
        {
            ArvoreBinaria arvoreBinaria = new(null!);
            arvoreBinaria.Inserir(10);
            arvoreBinaria.Inserir(5);
            arvoreBinaria.Inserir(15);

            int quantidadeFolhas = _quantidadeFolhas.ContarFolhas(arvoreBinaria);

            quantidadeFolhas.ShouldBe(2);
        }
    }
}
