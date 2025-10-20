using StructBeaver.Grafos;
using Shouldly;

namespace StructBeaver.Tests.Grafos
{
    public sealed class GrafoListaAdjacenciaTests
    {
        [Fact(DisplayName = "AdicionarAresta deve retornar true quando adicionada com sucesso")]
        public void AdicionarAresta_DeveRetornarTrue_QuandoAdicionadaComSucesso()
        {
            GrafoListaAdjacencia grafo = new GrafoListaAdjacencia(false);
            grafo.AdicionarVertice(0);
            grafo.AdicionarVertice(1);

            bool arestaFoiAdicionada = grafo.AdicionarAresta(0, 1);

            arestaFoiAdicionada.ShouldBeTrue();
            grafo.TemAresta(0, 1).ShouldBeTrue();
            grafo.TemAresta(1, 0).ShouldBeTrue();
        }

        [Fact(DisplayName = "AdicionarAresta deve retornar false se vértice não existir")]
        public void AdicionarAresta_VerticeInexistente_DeveRetornarFalse()
        {
            GrafoListaAdjacencia grafo = new GrafoListaAdjacencia();

            bool arestaFoiAdicionada = grafo.AdicionarAresta(0, 1);

            arestaFoiAdicionada.ShouldBeFalse();
        }

        [Fact(DisplayName = "RemoverAresta deve retornar true quando aresta removida com sucesso")]
        public void RemoverAresta_DeveRetornarTrue_QuandoRemovidaComSucesso()
        {
            GrafoListaAdjacencia grafo = new GrafoListaAdjacencia(false);
            grafo.AdicionarVertice(0);
            grafo.AdicionarVertice(1);
            grafo.AdicionarAresta(0, 1);

            bool arestaFoiRemovida = grafo.RemoverAresta(0, 1);

            arestaFoiRemovida.ShouldBeTrue();
            grafo.TemAresta(0, 1).ShouldBeFalse();
            grafo.TemAresta(1, 0).ShouldBeFalse();
        }

        [Fact(DisplayName = "RemoverAresta deve retornar false se vértices não existirem")]
        public void RemoverAresta_VerticeInexistente_DeveRetornarFalse()
        {
            GrafoListaAdjacencia grafo = new GrafoListaAdjacencia();

            bool arestaFoiRemovida = grafo.RemoverAresta(0, 1);

            arestaFoiRemovida.ShouldBeFalse();
        }

        [Fact(DisplayName = "Remover vértice deve apagar todas arestas que apontam para ele")]
        public void RemoverVertice_DeveRemoverTodasArestasAssociadas()
        {
            GrafoListaAdjacencia grafo = new GrafoListaAdjacencia(false);
            grafo.AdicionarVertice(0);
            grafo.AdicionarVertice(1);
            grafo.AdicionarVertice(2);

            grafo.AdicionarAresta(0, 1);
            grafo.AdicionarAresta(1, 2);

            grafo.RemoverVertice(1);

            grafo.TemAresta(0, 1).ShouldBeFalse();
            grafo.TemAresta(1, 0).ShouldBeFalse();
            grafo.NumeroDeVertices.ShouldBe(2);
        }

        [Fact(DisplayName = "TemAresta com vértice inexistente deve retornar false")]
        public void TemAresta_VerticeInexistente_DeveRetornarFalse()
        {
            GrafoListaAdjacencia grafo = new GrafoListaAdjacencia();

            bool arestaExiste = grafo.TemAresta(0, 1);

            arestaExiste.ShouldBeFalse();
        }
    }
}