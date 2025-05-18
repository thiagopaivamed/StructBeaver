using Shouldly;
using StructBeaver.Filas;
using StructBeaver.Filas.Exercicios;

namespace StructBeaver.Tests.Filas.Exercicios
{
    public class VerificaFilasTest
    {
        private readonly VerificaFilas _verificaFilas;

        public VerificaFilasTest()
            => _verificaFilas = new();

        [Fact]
        public void VerificarFilas_Deve_Retornar_True_Quando_Filas_Sao_Iguais()
        {
            Fila fila1 = new();
            Fila fila2 = new();

            fila1.Enqueue(1);
            fila1.Enqueue(2);
            fila1.Enqueue(3);
            fila1.Enqueue(4);
            fila1.Enqueue(5);

            fila2.Enqueue(1);
            fila2.Enqueue(2);
            fila2.Enqueue(3);
            fila2.Enqueue(4);
            fila2.Enqueue(5);

            bool filasSaoIguais = _verificaFilas.VerificarFilasPorOrdemValores(fila1, fila2);

            filasSaoIguais.ShouldBeTrue();
        }

        [Fact]
        public void VerificarFilas_Deve_Retornar_False_Quando_Filas_Nao_Sao_Iguais()
        {
            Fila fila1 = new();
            Fila fila2 = new();

            fila1.Enqueue(5);
            fila1.Enqueue(8);
            fila1.Enqueue(1);
            fila1.Enqueue(9);
            fila1.Enqueue(4);

            fila2.Enqueue(1);
            fila2.Enqueue(2);
            fila2.Enqueue(3);
            fila2.Enqueue(4);
            fila2.Enqueue(5);

            bool filasSaoIguais = _verificaFilas.VerificarFilasPorOrdemValores(fila1, fila2);

            filasSaoIguais.ShouldBeFalse();
        }
    }
}