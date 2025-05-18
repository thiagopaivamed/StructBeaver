using Shouldly;
using StructBeaver.Filas;
using StructBeaver.Filas.Exercicios;

namespace StructBeaver.Tests.Filas.Exercicios
{
    public class OrdenacaoFilaTest
    {
        private readonly OrdenacaoFila _ordenacaoFila;

        public OrdenacaoFilaTest()
            => _ordenacaoFila = new();

        [Fact]
        public void OrdenacaoFila_Deve_Retornar_Fila_Ordenada()
        {
            Fila fila = new();

            fila.Enqueue(5);
            fila.Enqueue(3);
            fila.Enqueue(1);
            fila.Enqueue(4);
            fila.Enqueue(2);

            fila = _ordenacaoFila.Ordenar(fila);

            fila.Dequeue().ShouldBe(1);

            fila.Dequeue().ShouldBe(2);

            fila.Dequeue().ShouldBe(3);

            fila.Dequeue().ShouldBe(4);

            fila.Dequeue().ShouldBe(5);
        }
    }
}