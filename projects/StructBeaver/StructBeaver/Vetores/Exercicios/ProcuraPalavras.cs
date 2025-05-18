namespace StructBeaver.Vetores.Exercicios
{
    public class ProcuraPalavras
    {
        public bool PalavraEstaNoTexto(string texto, string palavra)
        {
            int indiceTexto = 0;
            int indicePalavra = 0;
            int quantidadeCaracteres = palavra.Length;

            while(indiceTexto <= texto.Length - 1 && indicePalavra <= quantidadeCaracteres - 1)
            {
                if (palavra[indicePalavra] == texto[indiceTexto])
                {
                    if (indicePalavra == quantidadeCaracteres - 1)
                        return true;

                    else if (indicePalavra < quantidadeCaracteres - 1)
                        indicePalavra = indicePalavra + 1;

                    else
                    {
                        if (indicePalavra > 0)
                            indicePalavra = 0;
                    }
                }

                indiceTexto = indiceTexto + 1;
            }

            return false;
        }
    }
}