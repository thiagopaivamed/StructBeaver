using Shouldly;
using StructBeaver.Grafos;

namespace StructBeaver.Tests.Grafos
{
    public sealed class GrafoListaAdjacenciaBfsTest
    {
        [Fact(DisplayName = "BFS deve visitar todos os vértices conectados na ordem correta")]
        public void ExecutarBuscaEmLargura_DeveVisitarVerticesNaOrdemCorreta()
        {
            GrafoListaAdjacencia grafo = new GrafoListaAdjacencia();
            grafo.AdicionarVertice(0);
            grafo.AdicionarVertice(1);
            grafo.AdicionarVertice(2);
            grafo.AdicionarVertice(3);

            grafo.AdicionarAresta(0, 1);
            grafo.AdicionarAresta(0, 2);
            grafo.AdicionarAresta(1, 3);

            GrafoListaAdjacenciaBfs bfs = new GrafoListaAdjacenciaBfs();

            List<int> resultado = bfs.ExecutarBuscaEmLargura(grafo, 0);

            resultado.ShouldBe([0, 1, 2, 3]);
        }

        [Fact(DisplayName = "BFS deve retornar apenas o vértice de origem quando não há conexões")]
        public void ExecutarBuscaEmLargura_GrafoIsolado_DeveRetornarSomenteOrigem()
        {
            GrafoListaAdjacencia grafo = new GrafoListaAdjacencia();
            grafo.AdicionarVertice(0);
            grafo.AdicionarVertice(1);
            grafo.AdicionarVertice(2);

            GrafoListaAdjacenciaBfs bfs = new GrafoListaAdjacenciaBfs();

            List<int> resultado = bfs.ExecutarBuscaEmLargura(grafo, 1);

            resultado.ShouldBe([1]);
        }

        [Fact(DisplayName = "BFS deve percorrer todos os vértices de um grafo não direcionado")]
        public void ExecutarBuscaEmLargura_GrafoNaoDirecionado_DevePercorrerTodosOsVertices()
        {
            GrafoListaAdjacencia grafo = new GrafoListaAdjacencia(direcionado: false);
            grafo.AdicionarVertice(0);
            grafo.AdicionarVertice(1);
            grafo.AdicionarVertice(2);
            grafo.AdicionarVertice(3);
            grafo.AdicionarVertice(4);

            grafo.AdicionarAresta(0, 1);
            grafo.AdicionarAresta(1, 2);
            grafo.AdicionarAresta(2, 3);
            grafo.AdicionarAresta(3, 4);

            GrafoListaAdjacenciaBfs bfs = new GrafoListaAdjacenciaBfs();

            List<int> resultado = bfs.ExecutarBuscaEmLargura(grafo, 0);

            resultado.ShouldBe([0, 1, 2, 3, 4]);
        }
    }
}