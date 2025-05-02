using StructBeaver.Listas;

public class ListaEncadeadaCSharpTests
{
    private ListaEncadeadaCSharp _listaEncadeadaCSharp;

    public ListaEncadeadaCSharpTests()    
       => _listaEncadeadaCSharp = new ListaEncadeadaCSharp();    

    [Fact]
    public void Deve_Adicionar_Elemento_Na_Lista()
    {
        _listaEncadeadaCSharp.Adicionar(10);
        _listaEncadeadaCSharp.Adicionar(20);
        _listaEncadeadaCSharp.Adicionar(30);

        bool removido = _listaEncadeadaCSharp.Remover(20);

        Assert.True(removido);
    }

    [Fact]
    public void Deve_Remover_Elemento_Existente()
    {
        _listaEncadeadaCSharp.Adicionar(1);
        _listaEncadeadaCSharp.Adicionar(2);
        _listaEncadeadaCSharp.Adicionar(3);

        bool removido = _listaEncadeadaCSharp.Remover(2);

        Assert.True(removido);
    }

    [Fact]
    public void Nao_Deve_Remover_Elemento_Inexistente()
    {
        _listaEncadeadaCSharp.Adicionar(100);

        bool removido = _listaEncadeadaCSharp.Remover(200);

        Assert.False(removido);
    }
}