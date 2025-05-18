using Shouldly;
using StructBeaver.Filas;
using StructBeaver.Filas.Exercicios;

namespace StructBeaver.Tests.Filas.Exercicios
{
    public class MediaValoresFilaTest
    {
        private readonly MediaValoresFila _mediaValoresFila;

        public MediaValoresFilaTest()
            => _mediaValoresFila = new();

        [Fact]
        public void MediaValoresFila_Deve_Retornar_Media_Dos_Valores_Da_Fila()
        {
            Fila fila = new();

            fila.Enqueue(1);
            fila.Enqueue(2);
            fila.Enqueue(3);
            fila.Enqueue(4);
            fila.Enqueue(5);

            double media = _mediaValoresFila.CalcularMedia(fila);

            media.ShouldBe(3);
        }
    }
}