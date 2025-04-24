using StructBeaver.Filas;
using StructBeaver.Filas.Exercicios;

namespace StructBeaver.Tests.Filas.Exercicios
{
    public class MediaValoresFilaTest
    {
        private MediaValoresFila _mediaValoresFila;

        public MediaValoresFilaTest()
            => _mediaValoresFila = new MediaValoresFila();

        [Fact]
        public void MediaValoresFila_Deve_Retornar_Media_Dos_Valores_Da_Fila()
        {
            Fila fila = new Fila();

            fila.Enqueue(1);
            fila.Enqueue(2);
            fila.Enqueue(3);
            fila.Enqueue(4);
            fila.Enqueue(5);

            double media = _mediaValoresFila.CalcularMedia(fila);

            Assert.Equal(3, media);
            Console.WriteLine($"A media dos valores da fila é {media}.");
        }
    }
}
