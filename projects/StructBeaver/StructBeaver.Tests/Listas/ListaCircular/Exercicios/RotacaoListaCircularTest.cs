using Shouldly;
using StructBeaver.Listas.ListaCircular;
using StructBeaver.Listas.ListaCircular.Exercicios;

namespace StructBeaver.Tests.Listas.ListaCircular.Exercicios
{
    public class RotacaoListaCircularTest
    {
        private readonly RotacaoListaCircular _rotacaoListaCircular;

        public RotacaoListaCircularTest()
            => _rotacaoListaCircular = new();

        [Fact]
        public void Rotacao_Lista_Circular_Deve_Retornar_Lista_Circular_Rotacionada()
        {
            ListaCircularDuplamenteEncadeada listaCircular = new ListaCircularDuplamenteEncadeada();
            listaCircular.AdicionarNoFim(1);
            listaCircular.AdicionarNoFim(2);
            listaCircular.AdicionarNoFim(3);

            _rotacaoListaCircular.Rotacionar(listaCircular, 1);

            listaCircular.PrimeiroNo!.Valor.ShouldBe(2);
            listaCircular.PrimeiroNo.Proximo!.Valor.ShouldBe(3);
            listaCircular.PrimeiroNo.Proximo.Proximo!.Valor.ShouldBe(1);
        }
    }
}