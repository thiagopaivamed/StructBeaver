using Shouldly;
using StructBeaver.Filas;
using StructBeaver.Filas.Exercicios;

namespace StructBeaver.Tests.Filas.Exercicios
{
    public class CopiaFilaTest
    {
        private readonly CopiaFila copiaFila;

        public CopiaFilaTest()
            => copiaFila = new();

        [Fact]
        public void CopiarDados_Deve_Retornar_Fila_Preenchida()
        {
            Fila filaOriginal = new ();

            filaOriginal.Enqueue(1);
            filaOriginal.Enqueue(2);
            filaOriginal.Enqueue(3);
            filaOriginal.Enqueue(4);
            filaOriginal.Enqueue(5);

            Fila filaCopia = copiaFila.CopiarDados(filaOriginal);

            filaCopia.Dequeue().ShouldBe(1);

            filaCopia.Dequeue().ShouldBe(2);

            filaCopia.Dequeue().ShouldBe(3);

            filaCopia.Dequeue().ShouldBe(4);

            filaCopia.Dequeue().ShouldBe(5);
        }
    }
}