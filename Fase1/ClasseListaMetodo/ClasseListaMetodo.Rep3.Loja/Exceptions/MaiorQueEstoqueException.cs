namespace ClasseListaMetodo.Rep3.Loja.Exceptions
{
    internal class MaiorQueEstoqueException : Exception
    {
        public MaiorQueEstoqueException(Item item) : base($"Estoque insuficiente: {item.Nome} tem só {item.Estoque}.") { }
    }
}   
