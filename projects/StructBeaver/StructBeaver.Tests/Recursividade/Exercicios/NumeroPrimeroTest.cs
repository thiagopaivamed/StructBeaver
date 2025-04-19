﻿using StructBeaver.Recursividade.Exercicios;

namespace StructBeaver.Tests.Recursividade.Exercicios
{
    public class NumeroPrimeroTest
    {
        private readonly NumeroPrimo _numeroPrimero;

        public NumeroPrimeroTest()
            => _numeroPrimero = new NumeroPrimo();

        [Fact]
        public void VerificaPrimo_Deve_Retornar_True_Quando_Numero_For_Primo()
        {
            int numero = 7;

            bool primo = _numeroPrimero.VerificarPrimo(numero, 2);

            Assert.True(primo);

            Console.WriteLine($"O numero {numero} é primo.");
        }

        [Fact]
        public void VerificaPrimo_Deve_Retornar_False_Quando_Numero_Nao_For_Primo()
        {
            int numero = 36;

            bool primo = _numeroPrimero.VerificarPrimo(numero, 2);

            Assert.False(primo);

            Console.WriteLine($"O numero {numero} não é primo.");
        }

    }
}
