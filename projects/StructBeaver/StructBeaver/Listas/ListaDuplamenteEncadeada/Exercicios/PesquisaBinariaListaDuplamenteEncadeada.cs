namespace StructBeaver.Listas.ListaDuplamenteEncadeada.Exercicios
{
    public class PesquisaBinariaListaDuplamenteEncadeada
    {
        public bool Pesquisar(ListaDuplamenteEncadeada listaParaProcura, int valorProcurado)
        {
            NoDuplamenteEncadeado primeiroNo = listaParaProcura.PegarPrimeiroNo();
            NoDuplamenteEncadeado ultimoNo = listaParaProcura.PegarUltimoNo();

            return PesquisaBinariaRecursiva(primeiroNo, ultimoNo, valorProcurado);
        }

        private bool PesquisaBinariaRecursiva(NoDuplamenteEncadeado noInicial, NoDuplamenteEncadeado noFinal, int valorProcurado)
        {
            if (noInicial is null || noFinal is null)
                return false;

            NoDuplamenteEncadeado atual = noInicial;

            while (atual is not null && atual != noFinal)
                atual = atual.Proximo;

            if (atual != noFinal)
                return false;

            NoDuplamenteEncadeado ponteiroInicio = noInicial;
            NoDuplamenteEncadeado ponteiroFim = noFinal;

            while (ponteiroInicio != ponteiroFim && ponteiroInicio.Proximo != ponteiroFim)
            {
                ponteiroInicio = ponteiroInicio?.Proximo;
                ponteiroFim = ponteiroFim?.Anterior;
            }

            NoDuplamenteEncadeado noMeio = ponteiroInicio;

            if (noMeio is null)
                return false;

            if (noMeio.Valor == valorProcurado)
                return true;

            if (valorProcurado < noMeio.Valor)
                return PesquisaBinariaRecursiva(noMeio.Proximo, noFinal, valorProcurado);

            return PesquisaBinariaRecursiva(noInicial, noMeio.Anterior, valorProcurado);
        }
    }
}