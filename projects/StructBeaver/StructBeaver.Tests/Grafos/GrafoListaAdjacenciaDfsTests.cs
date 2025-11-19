using Shouldly;
using StructBeaver.Grafos;

namespace StructBeaver.Tests.Grafos
{
    public sealed class GrafoListaAdjacenciaDfsTests
    {
        [Fact(DisplayName = "DFS deve visitar todos os vértices de um grafo simples")]
        public void Executar_VisitaTodosVertices()
        {
            GrafoListaAdjacencia grafo = new(false);
            GrafoListaAdjacenciaDfs dfs = new();

            grafo.AdicionarVertice(1);
            grafo.AdicionarVertice(2);
            grafo.AdicionarVertice(3);
            grafo.AdicionarVertice(4);
            grafo.AdicionarVertice(5);
            grafo.AdicionarVertice(6);

            grafo.AdicionarAresta(1, 2);
            grafo.AdicionarAresta(1, 3);
            grafo.AdicionarAresta(2, 4);
            grafo.AdicionarAresta(2, 5);
            grafo.AdicionarAresta(3, 6);

            List<int> visitados = dfs.Executar(grafo, 1);

            visitados.Count.ShouldBe(6);
            visitados.ShouldBeSubsetOf([1, 2, 3, 4, 5, 6]);
        }

        [Fact(DisplayName = "DFS deve visitar vértice isolado corretamente")]
        public void Executar_VertexIsolado()
        {
            GrafoListaAdjacencia grafo = new();
            GrafoListaAdjacenciaDfs dfs = new();

            grafo.AdicionarVertice(1);
            grafo.AdicionarVertice(2);
            grafo.AdicionarVertice(3);

            grafo.AdicionarAresta(1, 2);

            List<int> visitados = dfs.Executar(grafo, 3);

            visitados.Count.ShouldBe(1);
            visitados.ShouldContain(3);
        }

        [Fact(DisplayName = "DFS deve lidar com vértice inicial inexistente")]
        public void Executar_VerticeInicialNaoExiste()
        {
            GrafoListaAdjacencia grafo = new();
            GrafoListaAdjacenciaDfs dfs = new();

            List<int> visitados = dfs.Executar(grafo, 10);

            visitados.Count.ShouldBe(1);
            visitados.ShouldContain(10);
        }

        [Fact(DisplayName = "DFS deve lidar com grafo vazio corretamente")]
        public void Executar_GrafoVazio()
        {
            GrafoListaAdjacencia grafo = new();
            GrafoListaAdjacenciaDfs dfs = new();

            List<int> visitados = dfs.Executar(grafo, 1);

            visitados.Count.ShouldBe(1);
            visitados.ShouldContain(1);
        }

        [Fact(DisplayName = "DFS deve lidar com ciclos sem entrar em loop")]
        public void Executar_ComCiclo()
        {
            GrafoListaAdjacencia grafo = new(false);
            GrafoListaAdjacenciaDfs dfs = new();

            grafo.AdicionarVertice(1);
            grafo.AdicionarVertice(2);
            grafo.AdicionarVertice(3);

            grafo.AdicionarAresta(1, 2);
            grafo.AdicionarAresta(2, 3);
            grafo.AdicionarAresta(3, 1);  // ciclo

            List<int> visitados = dfs.Executar(grafo, 1);

            visitados.Count.ShouldBe(3);
            visitados.ShouldBeSubsetOf([1, 2, 3]);
        }

        [Fact(DisplayName = "DFS deve visitar somente o componente conexo do vértice inicial")]
        public void Executar_GrafoDesconexo()
        {
            GrafoListaAdjacencia grafo = new(false);
            GrafoListaAdjacenciaDfs dfs = new();

            grafo.AdicionarVertice(1);
            grafo.AdicionarVertice(2);
            grafo.AdicionarVertice(3);
            grafo.AdicionarVertice(4);

            grafo.AdicionarAresta(1, 2);
            grafo.AdicionarAresta(2, 3);

            List<int> visitados = dfs.Executar(grafo, 1);

            visitados.Count.ShouldBe(3);
            visitados.ShouldBe([1, 2, 3]);
        }

        [Fact(DisplayName = "DFS deve respeitar a ordem de adjacências")]
        public void Executar_OrdemDeVisita()
        {
            GrafoListaAdjacencia grafo = new();
            GrafoListaAdjacenciaDfs dfs = new();

            grafo.AdicionarVertice(1);
            grafo.AdicionarVertice(2);
            grafo.AdicionarVertice(3);
            grafo.AdicionarVertice(4);

            grafo.AdicionarAresta(1, 2);
            grafo.AdicionarAresta(1, 3);
            grafo.AdicionarAresta(2, 4);

            List<int> visitados = dfs.Executar(grafo, 1);

            visitados.ShouldBe(new List<int> { 1, 2, 4, 3 });
        }

        [Fact(DisplayName = "DFS deve funcionar em grafo direcionado")]
        public void Executar_GrafoDirecionado()
        {
            GrafoListaAdjacencia grafo = new(true);
            GrafoListaAdjacenciaDfs dfs = new();

            grafo.AdicionarVertice(1);
            grafo.AdicionarVertice(2);
            grafo.AdicionarVertice(3);

            grafo.AdicionarAresta(1, 2);
            grafo.AdicionarAresta(2, 3);

            List<int> visitados = dfs.Executar(grafo, 1);

            visitados.ShouldBe([1, 2, 3]);
        }
    }
}