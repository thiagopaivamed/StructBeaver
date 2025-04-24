using StructBeaver.Filas;
using StructBeaver.Filas.Exercicios;

namespace StructBeaver.Tests.Filas.Exercicios
{
    public class OrdenacaoFilaTest
    {
        private OrdenacaoFila _ordenacaoFila;

        public OrdenacaoFilaTest()
            => _ordenacaoFila = new OrdenacaoFila();

        [Fact]
        public void OrdenacaoFila_Deve_Retornar_Fila_Ordenada()
        {
            Fila fila = new Fila();

            fila.Enqueue(5);
            fila.Enqueue(3);
            fila.Enqueue(1);
            fila.Enqueue(4);
            fila.Enqueue(2);

            fila = _ordenacaoFila.Ordenar(fila);

            Console.WriteLine($"A fila ordenada é ");

            Console.WriteLine($"{fila.Peek()}");
            Assert.Equal(1, fila.Dequeue());

            Console.WriteLine($"{fila.Peek()}");
            Assert.Equal(2, fila.Dequeue());

            Console.WriteLine($"{fila.Peek()}");
            Assert.Equal(3, fila.Dequeue());

            Console.WriteLine($"{fila.Peek()}");
            Assert.Equal(4, fila.Dequeue());

            Console.WriteLine($"{fila.Peek()}");
            Assert.Equal(5, fila.Dequeue());
        }
    }
}