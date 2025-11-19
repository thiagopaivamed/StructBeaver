namespace StructBeaver.Grafos
{
    public class GrafoListaAdjacenciaDfs
    {
        public List<int> Executar(GrafoListaAdjacencia grafo, int verticeInicial)
        {
            HashSet<int> visitados = [];
            List<int> ordem = [];

            Dfs(verticeInicial, grafo, visitados, ordem);

            return ordem;
        }

        private void Dfs(int vertice, GrafoListaAdjacencia grafo, HashSet<int> visitados, List<int> ordem)
        {
            visitados.Add(vertice);
            ordem.Add(vertice);

            List<int> adjacentes;

            try
            {
                adjacentes = grafo.ObterAdjacencias(vertice);
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }

            foreach (int adj in adjacentes)
            {
                if (!visitados.Contains(adj))
                    Dfs(adj, grafo, visitados, ordem);
            }
        }
    }
}