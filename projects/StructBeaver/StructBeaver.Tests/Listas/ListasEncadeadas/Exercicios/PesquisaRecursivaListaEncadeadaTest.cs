﻿using Shouldly;
using StructBeaver.Listas.ListaEncadeada;
using StructBeaver.Listas.ListaEncadeada.Exercicios;

namespace StructBeaver.Tests.Listas.ListasEncadeadas.Exercicios
{
    public class PesquisaRecursivaListaEncadeadaTest
    {
        private readonly PesquisaRecursivaListaEncadeada _pesquisaRecursivaListaEncadeada;
        private readonly ListaEncadeada _listaEncadeada;

        public PesquisaRecursivaListaEncadeadaTest()
        {
            _pesquisaRecursivaListaEncadeada = new();

            _listaEncadeada = new();
            _listaEncadeada.AdicionarNoFim(1);
            _listaEncadeada.AdicionarNoFim(2);
            _listaEncadeada.AdicionarNoFim(3);
            _listaEncadeada.AdicionarNoFim(4);
            _listaEncadeada.AdicionarNoFim(5);
        }

        [Fact]
        public void Pesquisa_Recursiva_Lista_Deve_Retornar_True_Quando_Encontrar_Valor_Pesquisado()
        {
            int valorProcurado = 3;

            bool valorFoiEncontrado = _pesquisaRecursivaListaEncadeada.Pesquisar(_listaEncadeada, valorProcurado);

            valorFoiEncontrado.ShouldBeTrue();
        }

        [Fact]
        public void Pesquisa_Recursiva_Lista_Deve_Retornar_False_Quando_Nao_Encontrar_Valor_Pesquisado()
        {
            int valorProcurado = 36;

            bool valorFoiEncontrado = _pesquisaRecursivaListaEncadeada.Pesquisar(_listaEncadeada, valorProcurado);

            valorFoiEncontrado.ShouldBeFalse();
        }
    }
}