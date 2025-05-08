using StructBeaver.Filas;
using StructBeaver.Filas.Exercicios;

namespace StructBeaver.Tests.Filas.Exercicios
{
    public class CopiaFilaTest
    {
        private CopiaFila copiaFila;

        public CopiaFilaTest()
            => copiaFila = new CopiaFila();

        [Fact]
        public void CopiarDados_Deve_Retornar_Fila_Preenchida()
        {
            Fila filaOriginal = new Fila();

            filaOriginal.Enqueue(1);
            filaOriginal.Enqueue(2);
            filaOriginal.Enqueue(3);
            filaOriginal.Enqueue(4);
            filaOriginal.Enqueue(5);

            Fila filaCopia = copiaFila.CopiarDados(filaOriginal);

            Assert.Equal(1, filaCopia.Dequeue());

            Assert.Equal(2, filaCopia.Dequeue());

            Assert.Equal(3, filaCopia.Dequeue());

            Assert.Equal(4, filaCopia.Dequeue());

            Assert.Equal(5, filaCopia.Dequeue());
        }
    }
}