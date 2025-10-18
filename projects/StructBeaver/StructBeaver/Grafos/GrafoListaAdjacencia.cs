namespace StructBeaver.Grafos
{
    public class GrafoListaAdjacencia
    {
        private List<List<int>> adjacencias;
        private bool grafoDirecionado;
        public int numeroDeVertices => adjacencias.Count;

        public GrafoListaAdjacencia(int numeroVertices, bool direcionado = false)
        {
            adjacencias = new List<List<int>>(numeroVertices);
            grafoDirecionado = direcionado;

            for (int i = 0; i < numeroVertices; i++)
                adjacencias.Add(new List<int>());
        }

        public void AdicionarAresta(int origem, int destino)
        {
            adjacencias[origem].Add(destino);

            if (!grafoDirecionado)
                adjacencias[destino].Add(origem);
        }

        public void RemoverAresta(int origem, int destino)
        {
            adjacencias[origem].Remove(destino);

            if (!grafoDirecionado)
                adjacencias[destino].Remove(origem);
        }

        public void AdicionarVertice()
            => adjacencias.Add(new List<int>());

        public void RemoverVertice(int vertice)
        {
            adjacencias.RemoveAt(vertice);

            foreach (List<int> lista in adjacencias)
                lista.Remove(vertice);

            for (int i = 0; i < adjacencias.Count; i++)
            {
                for (int j = 0; j < adjacencias[i].Count; j++)
                {
                    int verticeAtual = adjacencias[i][j];

                    if (verticeAtual > vertice)
                        adjacencias[i][j] = verticeAtual - 1;
                }
            }
        }        

        public List<int> ObterAdjacencias(int vertice)
        {
            if (vertice < 0 || vertice >= adjacencias.Count)
                throw new ArgumentOutOfRangeException(nameof(vertice));

            return adjacencias[vertice];
        }

        public bool TemAresta(int origem, int destino)
        {
            if (origem < 0 || origem >= adjacencias.Count)
                throw new ArgumentOutOfRangeException(nameof(origem));
            if (destino < 0 || destino >= adjacencias.Count)
                throw new ArgumentOutOfRangeException(nameof(destino));
            return adjacencias[origem].Contains(destino);
        }
    }
}
