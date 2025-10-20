namespace StructBeaver.Grafos
{
    public class GrafoListaAdjacencia
    {
        private Dictionary<int, List<int>> verticesAdjacentes;
        private bool grafoDirecionado;

        public int NumeroDeVertices => verticesAdjacentes.Count;

        public GrafoListaAdjacencia(bool direcionado = false)
        {
            verticesAdjacentes = new Dictionary<int, List<int>>();
            grafoDirecionado = direcionado;
        }

        public bool AdicionarVertice(int vertice)
        {
            bool verticeFoiAdicionado = false;

            if (verticesAdjacentes.ContainsKey(vertice))
                return false;

            verticesAdjacentes[vertice] = new List<int>();

            verticeFoiAdicionado = true;
            return verticeFoiAdicionado;
        }

        public bool RemoverVertice(int vertice)
        {
            bool verticeFoiRemovido = false;

            if (!verticesAdjacentes.TryGetValue(vertice, out _))
                return verticeFoiRemovido;

            verticesAdjacentes.Remove(vertice);

            foreach (List<int> valoresAdjacencia in verticesAdjacentes.Values)
                valoresAdjacencia.Remove(vertice);

            verticeFoiRemovido = true;
            return true;
        }

        public bool AdicionarAresta(int origem, int destino)
        {
            bool arestaFoiAdicionada = false;

            if (!verticesAdjacentes.TryGetValue(origem, out List<int> listaOrigem))
                return arestaFoiAdicionada;

            if (!verticesAdjacentes.TryGetValue(destino, out List<int> listaDestino))
                return arestaFoiAdicionada;

            if (!listaOrigem.Contains(destino))
            {
                listaOrigem.Add(destino);
                arestaFoiAdicionada = true;
            }

            if (!grafoDirecionado && !listaDestino.Contains(origem))
            {
                listaDestino.Add(origem);
                arestaFoiAdicionada = true;
            }

            return arestaFoiAdicionada;
        }

        public bool RemoverAresta(int origem, int destino)
        {
            bool arestaFoiRemovida = false;

            if (!verticesAdjacentes.TryGetValue(origem, out List<int> listaOrigem))
                return arestaFoiRemovida;

            if (!verticesAdjacentes.TryGetValue(destino, out List<int> listaDestino))
                return arestaFoiRemovida;

            if (listaOrigem.Remove(destino))
                arestaFoiRemovida = true;

            if (!grafoDirecionado && listaDestino.Remove(origem))
                arestaFoiRemovida = true;

            return arestaFoiRemovida;
        }

        public List<int> ObterAdjacencias(int vertice)
        {
            if (!verticesAdjacentes.TryGetValue(vertice, out List<int> arestasAdjacentes))
                throw new ArgumentOutOfRangeException(nameof(vertice));

            return arestasAdjacentes;
        }

        public bool TemAresta(int origem, int destino)
        {
            if (!verticesAdjacentes.ContainsKey(origem) || !verticesAdjacentes.ContainsKey(destino))
                return false;

            return verticesAdjacentes[origem].Contains(destino);
        }        
    }
}