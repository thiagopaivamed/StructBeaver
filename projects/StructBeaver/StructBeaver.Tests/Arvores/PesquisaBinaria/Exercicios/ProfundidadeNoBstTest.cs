using Shouldly;
using StructBeaver.Arvores;
using StructBeaver.Arvores.ArvorePesquisaBinaria;
using StructBeaver.Arvores.ArvorePesquisaBinaria.Exercicios;

namespace StructBeaver.Tests.Arvores.PesquisaBinaria.Exercicios
{
    public class ProfundidadeNoBstTest
    {
        private readonly ProfundidadeNoBst _profundidadeNoBst;

        public ProfundidadeNoBstTest()
            => _profundidadeNoBst = new ProfundidadeNoBst();

        [Fact]
        public void Profundidade_No_BST_Deve_Retornar_Menos_Um_Quando_Arvore_For_Nula()
        {
            ArvorePesquisaBinaria arvorePesquisaBinaria = null!;

            int profundidade = _profundidadeNoBst.ProfundidadeEmNo(arvorePesquisaBinaria, null!);

            profundidade.ShouldBe(-1);
        }

        [Fact]
        public void Profundidade_No_BST_Deve_Retornar_Menos_Um_Quando_Raiz_For_Nula()
        {
            NoArvore raiz = null!;
            ArvorePesquisaBinaria arvorePesquisaBinaria = new(raiz);

            int profundidade = _profundidadeNoBst.ProfundidadeEmNo(arvorePesquisaBinaria, null!);

            profundidade.ShouldBe(-1);
        }

        [Fact]
        public void Profundidade_No_BST_Deve_Retornar_Menos_Um_Quando_Nao_Achar_No_Procurado()
        {
            NoArvore raiz = new(90);
            ArvorePesquisaBinaria arvorePesquisaBinaria = new(raiz);

            NoArvore noProcurado = new(100);
            int profundidade = _profundidadeNoBst.ProfundidadeEmNo(arvorePesquisaBinaria, noProcurado);

            profundidade.ShouldBe(-1);
        }

        [Fact]
        public void Profundidade_No_BST_Deve_Retornar_Zero_Quando_Existir_Apenas_Raiz()
        {
            NoArvore raiz = new(90);
            ArvorePesquisaBinaria arvorePesquisaBinaria = new(raiz);

            int profundidade = _profundidadeNoBst.ProfundidadeEmNo(arvorePesquisaBinaria, raiz);

            profundidade.ShouldBe(0);
        }


        [Fact]
        public void Profundidade_No_BST_Deve_Retornar_Prondidade_Quando_Achar_No_Procurado()
        {
            NoArvore raiz = new(90);
            ArvorePesquisaBinaria arvorePesquisaBinaria = new(raiz);
            arvorePesquisaBinaria.Inserir(80);
            arvorePesquisaBinaria.Inserir(95);
            arvorePesquisaBinaria.Inserir(94);
            arvorePesquisaBinaria.Inserir(96);
            arvorePesquisaBinaria.Inserir(79);
            arvorePesquisaBinaria.Inserir(81);

            NoArvore? noProcurado = arvorePesquisaBinaria.Raiz.NoEsquerdo!.NoEsquerdo;
            int profundidade = _profundidadeNoBst.ProfundidadeEmNo(arvorePesquisaBinaria, noProcurado);

            noProcurado = arvorePesquisaBinaria.Raiz.NoDireito;
            int profundidadeNoDireito = _profundidadeNoBst.ProfundidadeEmNo(arvorePesquisaBinaria, noProcurado);
            
            profundidade.ShouldBe(2);
            profundidadeNoDireito.ShouldBe(1);
        }
    }
}