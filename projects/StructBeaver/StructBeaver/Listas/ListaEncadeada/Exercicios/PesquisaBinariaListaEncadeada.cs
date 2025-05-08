namespace StructBeaver.Listas.ListaEncadeada.Exercicios
{
    public class PesquisaBinariaListaEncadeada
    {
        public bool Pesquisar(ListaEncadeada lista, int valor)
        {
            No primeiroNo = lista.PegarPrimeiroNo();

            if (primeiroNo is null)
                return false;

            return PesquisaBinariaRecursiva(primeiroNo, primeiroNo, valor);
        }

        private bool PesquisaBinariaRecursiva(No primeiroNo, No meio, int valor)
        {
            if (meio is null)
                return false;
                        
            if (meio.Valor == valor)
                return true;

            if (valor < meio.Valor)
                return PesquisaBinariaRecursiva(primeiroNo, meio.Proximo, valor);

            return PesquisaBinariaRecursiva(meio.Proximo, meio.Proximo, valor);
        }
    }
}