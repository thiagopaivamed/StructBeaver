using Shouldly;
using StructBeaver.Grafos;

namespace StructBeaver.Tests.Grafos
{
    public class GrafoListaAdjacenciaTests
    {
        [Fact]
        public void AdicionarAresta_GrafoNaoDirecionado_DeveAdicionarNasDuasListas()
        {
            GrafoListaAdjacencia grafo = new GrafoListaAdjacencia(3, false);

            grafo.AdicionarAresta(0, 1);

            grafo.TemAresta(0, 1).ShouldBeTrue();
            grafo.TemAresta(1, 0).ShouldBeTrue();
        }

        [Fact]
        public void AdicionarAresta_GrafoDirecionado_DeveAdicionarApenasNaOrigem()
        {
            GrafoListaAdjacencia grafo = new GrafoListaAdjacencia(3, true);

            grafo.AdicionarAresta(0, 1);

            grafo.TemAresta(0, 1).ShouldBeTrue();
            grafo.TemAresta(1, 0).ShouldBeFalse();
        }

        [Fact]
        public void RemoverAresta_GrafoNaoDirecionado_DeveRemoverDasDuasListas()
        {
            GrafoListaAdjacencia grafo = new GrafoListaAdjacencia(3, false);
            grafo.AdicionarAresta(0, 1);

            grafo.RemoverAresta(0, 1);

            grafo.TemAresta(0, 1).ShouldBeFalse();
            grafo.TemAresta(1, 0).ShouldBeFalse();
        }

        [Fact]
        public void AdicionarVertice_DeveAumentarNumeroDeVertices()
        {
            GrafoListaAdjacencia grafo = new GrafoListaAdjacencia(2);
            int antes = grafo.numeroDeVertices;

            grafo.AdicionarVertice();

            grafo.numeroDeVertices.ShouldBe(antes + 1);
        }

        [Fact]
        public void RemoverVertice_DeveRemoverVerticeEAtualizarArestas()
        {
            GrafoListaAdjacencia grafo = new GrafoListaAdjacencia(4, false);
            grafo.AdicionarAresta(0, 1);
            grafo.AdicionarAresta(1, 2);
            grafo.AdicionarAresta(2, 3);

            grafo.RemoverVertice(1);

            grafo.numeroDeVertices.ShouldBe(3);

            grafo.TemAresta(0, 1).ShouldBeFalse(); 
            grafo.TemAresta(1, 2).ShouldBeTrue();  
        }

        [Fact]
        public void RemoverVertice_UltimoVertice_DeveRemoverSemErros()
        {
            var grafo = new GrafoListaAdjacencia(3);
            grafo.AdicionarAresta(0, 2);

            grafo.RemoverVertice(2);

            grafo.numeroDeVertices.ShouldBe(2);
            grafo.TemAresta(0, 1).ShouldBeFalse();
        }
    }
}
