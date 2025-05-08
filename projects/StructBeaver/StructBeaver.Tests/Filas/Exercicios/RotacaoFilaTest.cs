using StructBeaver.Filas;
using StructBeaver.Filas.Exercicios;

namespace StructBeaver.Tests.Filas.Exercicios
{
    public class RotacaoFilaTest
    {
        private RotacaoFila _rotacaoFila;
        public RotacaoFilaTest()
            => _rotacaoFila = new RotacaoFila();

        [Fact]
        public void RotacaoFila_Deve_Retornar_Fila_Rotacionada()
        {
            Fila fila = new Fila();

            fila.Enqueue(1);
            fila.Enqueue(2);
            fila.Enqueue(3);
            fila.Enqueue(4);
            fila.Enqueue(5);

            fila = _rotacaoFila.Rotacionar(fila, 2);

            Assert.Equal(3, fila.Dequeue());

            Assert.Equal(4, fila.Dequeue());

            Assert.Equal(5, fila.Dequeue());

            Assert.Equal(1, fila.Dequeue());

            Assert.Equal(2, fila.Dequeue());
        }
    }
}