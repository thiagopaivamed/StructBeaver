﻿using Shouldly;
using StructBeaver.Recursividade.Exercicios;

namespace StructBeaver.Tests.Recursividade.Exercicios
{
    public class PesquisaSimplesRecursivaTest
    {
        private readonly PesquisaSimplesRecursiva _pesquisaSimplesRecursiva;

        public PesquisaSimplesRecursivaTest()
            => _pesquisaSimplesRecursiva = new();

        [Fact]
        public void PesquisaSimplesRecursiva_Deve_Encontrar_Elemento()
        {
            int[] vetor = [3, 1, 2, 7, 10, 4, 8, 6, 12, 15];
            int elementoProcurado = 2;

            int indiceElementoProcurado = _pesquisaSimplesRecursiva.ExecutarPesquisaSimplesRecursiva(vetor, elementoProcurado, 0);

            indiceElementoProcurado.ShouldNotBe(-1);
        }

        [Fact]
        public void PesquisaSimplesRecursiva_Nao_Deve_Encontrar_Elemento()
        {
            int[] vetor = [3, 1, 2, 7, 10, 4, 8, 6, 12, 15];
            int elementoProcurado = 20;

            int indiceElementoProcurado = _pesquisaSimplesRecursiva.ExecutarPesquisaSimplesRecursiva(vetor, elementoProcurado, 0);

            indiceElementoProcurado.ShouldBe(-1);
        }
    }
}