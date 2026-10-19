namespace ClasseListaMetodo.Rep3.Loja.Exceptions
{
    internal class LimiteDeEscolhaException : Exception
    {
        public LimiteDeEscolhaException(List<Item> itens) : base($"A escolha deve ser entre 1 e {itens.Count}") { }
    }
}
