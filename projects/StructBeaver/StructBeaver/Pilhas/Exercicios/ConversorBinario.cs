namespace StructBeaver.Pilhas.Exercicios
{
    public class ConversorBinario
    {
        public string ConverterParaBinario(int numero)
        {
            Pilha pilha = new();

            while (numero > 0)
            {
                int resto = numero % 2;
                pilha.Push(resto);
                numero = numero / 2;
            }

            string numeroBinario = string.Empty;

            while (!pilha.IsEmpty())
            {
                int bit = pilha.Pop();
                numeroBinario = numeroBinario + bit.ToString();
            }

            return numeroBinario;
        }
    }
}