using Shouldly;
using StructBeaver.Listas.ListaEncadeada;
using StructBeaver.Listas.ListaEncadeada.Exercicios;

namespace StructBeaver.Tests.Listas.ListasEncadeadas.Exercicios
{
    public class JuncaoListasEncadeadasTest
    {
        private readonly JuncaoListasEncadeadas _juncaoListasEncadeadas;

        public JuncaoListasEncadeadasTest()
            => _juncaoListasEncadeadas = new();

        [Fact]
        public void Juncao_Listas_Deve_Retornar_Lista_Combinada()
        {
            ListaEncadeada lista1 = new();
            lista1.AdicionarNoFim(1);
            lista1.AdicionarNoFim(2);
            lista1.AdicionarNoFim(3);
            lista1.AdicionarNoFim(4);
            lista1.AdicionarNoFim(5);

            ListaEncadeada lista2 = new();
            lista2.AdicionarNoFim(6);
            lista2.AdicionarNoFim(7);
            lista2.AdicionarNoFim(8);
            lista2.AdicionarNoFim(9);

            ListaEncadeada listaCombinada = _juncaoListasEncadeadas.FazerMerge(lista1, lista2);

            listaCombinada.RemoverNoInicio()!.Valor.ShouldBe(1);
            listaCombinada.RemoverNoInicio()!.Valor.ShouldBe(6);
            listaCombinada.RemoverNoInicio()!.Valor.ShouldBe(2);
            listaCombinada.RemoverNoInicio()!.Valor.ShouldBe(7);
            listaCombinada.RemoverNoInicio()!.Valor.ShouldBe(3);
            listaCombinada.RemoverNoInicio()!.Valor.ShouldBe(8);
            listaCombinada.RemoverNoInicio()!.Valor.ShouldBe(4);
            listaCombinada.RemoverNoInicio()!.Valor.ShouldBe(9);
            listaCombinada.RemoverNoInicio()!.Valor.ShouldBe(5);
        }
    }
}