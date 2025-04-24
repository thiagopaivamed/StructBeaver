using StructBeaver.Filas;
using StructBeaver.Filas.Exercicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

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

            Console.WriteLine($"Os valores da fila copiada são ");

            Console.WriteLine($"{filaCopia.Peek()} ");
            Assert.Equal(1, filaCopia.Dequeue());

            Console.WriteLine($"{filaCopia.Peek()} ");
            Assert.Equal(2, filaCopia.Dequeue());

            Console.WriteLine($"{filaCopia.Peek()} ");
            Assert.Equal(3, filaCopia.Dequeue());

            Console.WriteLine($"{filaCopia.Peek()} ");
            Assert.Equal(4, filaCopia.Dequeue());

            Console.WriteLine($"{filaCopia.Peek()} ");
            Assert.Equal(5, filaCopia.Dequeue());
        }

    }
}
