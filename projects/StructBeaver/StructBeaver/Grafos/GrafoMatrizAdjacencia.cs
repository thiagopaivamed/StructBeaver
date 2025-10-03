namespace StructBeaver.Grafos
{
    public class GrafoMatrizAdjacencia
    {
        private int[,] matrizAdjacencia;
        private int quantidadeVertices;
        private bool grafoDirecionado;

        public GrafoMatrizAdjacencia(int numVertices, bool direcionado = false)
        {
            if (numVertices <= 0)
                throw new ArgumentException("Número de vértices deve ser maior que zero.", nameof(numVertices));

            quantidadeVertices = numVertices;
            matrizAdjacencia = new int[numVertices, numVertices];
            grafoDirecionado = direcionado;
        }

        public bool AdicionarAresta(int origem, int destino, int peso = 1)
        {
            if (!VerticesSaoValidos(origem, destino))
                return false;

            matrizAdjacencia[origem, destino] = peso;

            if (!grafoDirecionado)
                matrizAdjacencia[destino, origem] = peso;

            return true;
        }

        public bool RemoverAresta(int origem, int destino)
        {
            if (!VerticesSaoValidos(origem, destino))
                return false;

            matrizAdjacencia[origem, destino] = 0;

            if (!grafoDirecionado)
                matrizAdjacencia[destino, origem] = 0;

            return true;
        }

        public bool ExisteAresta(int origem, int destino)
            => VerticesSaoValidos(origem, destino) && matrizAdjacencia[origem, destino] != 0;

        private bool VerticesSaoValidos(int origem, int destino)
            => origem >= 0 && origem < quantidadeVertices &&
            destino >= 0 && destino < quantidadeVertices;
    }
}