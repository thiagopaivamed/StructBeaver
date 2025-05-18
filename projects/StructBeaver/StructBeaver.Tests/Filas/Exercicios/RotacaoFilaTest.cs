using Shouldly;
using StructBeaver.Filas;
using StructBeaver.Filas.Exercicios;

namespace StructBeaver.Tests.Filas.Exercicios
{
    public class RotacaoFilaTest
    {
        private readonly RotacaoFila _rotacaoFila;
        public RotacaoFilaTest()
            => _rotacaoFila = new();

        [Fact]
        public void RotacaoFila_Deve_Retornar_Fila_Rotacionada()
        {
            Fila fila = new();

            fila.Enqueue(1);
            fila.Enqueue(2);
            fila.Enqueue(3);
            fila.Enqueue(4);
            fila.Enqueue(5);

            fila = _rotacaoFila.Rotacionar(fila, 2);

            fila.Dequeue().ShouldBe(3);

            fila.Dequeue().ShouldBe(4);

            fila.Dequeue().ShouldBe(5);

            fila.Dequeue().ShouldBe(1);

            fila.Dequeue().ShouldBe(2);
        }
    }
}