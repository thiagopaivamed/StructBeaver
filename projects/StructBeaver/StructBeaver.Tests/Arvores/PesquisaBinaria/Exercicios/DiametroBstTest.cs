using Shouldly;
using StructBeaver.Arvores;
using StructBeaver.Arvores.ArvorePesquisaBinaria.Exercicios;
using StructBeaver.Arvores.ArvorePesquisaBinaria;

namespace StructBeaver.Tests.Arvores.PesquisaBinaria.Exercicios
{
    public class DiametroBstTest
    {
        private readonly DiametroBst _diametroBst;

        public DiametroBstTest()
            => _diametroBst = new DiametroBst();

        [Fact]
        public void Diametro_Deve_Retornar_Um_Quando_Arvore_Tem_Apenas_Um_No()
        {
            NoArvore raiz = new(10);
            ArvorePesquisaBinaria arvore = new(raiz);

            int diametro = _diametroBst.CalcularDiametro(arvore);

            diametro.ShouldBe(1);
        }

        [Fact]
        public void Diametro_Deve_Retornar_Tres_Quando_Arvore_Tem_Formato_Linear()
        {
            NoArvore no3 = new(3);
            NoArvore no2 = new(2) { NoDireito = no3 };
            NoArvore no1 = new(1) { NoDireito = no2 };
            ArvorePesquisaBinaria arvore = new(no1);

            int diametro = _diametroBst.CalcularDiametro(arvore);

            diametro.ShouldBe(3);
        }

        [Fact]
        public void Diametro_Deve_Retornar_Quatro_Quando_Arvore_Tem_Dois_Ramos_Longos()
        {

            NoArvore no2 = new(2);
            NoArvore no5 = new(5) { NoEsquerdo = no2 };
            NoArvore no20 = new(20);
            NoArvore no15 = new(15) { NoDireito = no20 };
            NoArvore no10 = new(10) { NoEsquerdo = no5, NoDireito = no15 };
            ArvorePesquisaBinaria arvore = new(no10);

            int diametro = _diametroBst.CalcularDiametro(arvore);

            diametro.ShouldBe(5);
        }

        [Fact]
        public void Diametro_Deve_Retornar_Zero_Quando_Arvore_For_Nula()
        {
            ArvorePesquisaBinaria arvore = null!;

            int diametro = _diametroBst.CalcularDiametro(arvore);

            diametro.ShouldBe(0);
        }

        [Fact]
        public void Diametro_Deve_Retornar_Zero_Quando_Raiz_For_Nula()
        {
            ArvorePesquisaBinaria arvore = new(null!);

            int diametro = _diametroBst.CalcularDiametro(arvore);

            diametro.ShouldBe(0);
        }
    }
}