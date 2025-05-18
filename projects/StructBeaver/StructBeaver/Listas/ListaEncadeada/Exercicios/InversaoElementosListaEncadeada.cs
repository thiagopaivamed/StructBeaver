namespace StructBeaver.Listas.ListaEncadeada.Exercicios
{
    public class InversaoElementosListaEncadeada
    {
        public ListaEncadeada Inverter(ListaEncadeada listaParaInversao)
        {
            ListaEncadeada listaInvertida = new();

            while (!listaParaInversao.IsEmpty())
            {
                No? noRemovido = listaParaInversao.RemoverNoInicio();

                if (noRemovido is not null)
                    listaInvertida.AdicionarNoInicio(noRemovido.Valor);
            }

            return listaInvertida;
        }
    }
}